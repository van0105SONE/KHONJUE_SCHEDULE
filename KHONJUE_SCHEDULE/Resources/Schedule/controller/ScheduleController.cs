using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using KHONJUE_SCHEDULE.Resources.Schedule.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHONJUE_SCHEDULE.Resources.Schedule.controller
{
    class ScheduleController
    {
        private NpgsqlCommand _command;
        private DatabaseContext dbContext { get; set; }
        private List<ScheduleModel> schedule = new List<ScheduleModel>(); 
        public SubjectController _subjectController { get; set; }
        public TeacherController _teacherController { get; set; }
        public TeacherAndSubjectController _teacherSubjectController { get; set; }
        public TimePeriodController _periodController { get; set; }
        public StudentClassController _classController { get; set; }

        private List<DayOfWeek> days = new() {
        DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday,
        DayOfWeek.Thursday, DayOfWeek.Friday
    };
        private int periodsPerDay = 5;


        public ScheduleController(DatabaseContext context)
        {
            _teacherSubjectController = new TeacherAndSubjectController(context);
            _teacherController = new TeacherController(context);
            _subjectController = new SubjectController(context);
            _periodController = new TimePeriodController(context);
            _classController = new StudentClassController(context);
            dbContext = context;
        }


        public List<ScheduleModel> GenerateSchedule()
        {
            List<TeacherModel> teachers = _teacherController.getTeachers();
            List<TermSubjectModel> termSubjects =   _subjectController.GetTermSubjectList();
            List<TimePeriodModel> periods = _periodController.getTimePeriod();
            List<StudentClassModel> rooms = _classController.GetStudentClasstList();
            var teacherScheduleCount = new Dictionary<int, int>();

            foreach (var subjectTeach in termSubjects)
            {
                bool scheduled = false;

                // Sort or shuffle teachers to vary selection per subject
                var eligibleTeachers = teachers
                    .Where(t =>
                        IsTeacherEligible(t.Id, subjectTeach.SubjectId))
                    .OrderBy(t => teacherScheduleCount.TryGetValue(t.Id, out int count) ? count : 0)
                    .ToList();

                foreach (var day in days)
                {
                    foreach (var period in periods)
                    {
                        foreach (var room in rooms)
                        {
                            foreach (var teacher in eligibleTeachers)
                            {
                                // Get current count or 0 if not present
                                teacherScheduleCount.TryGetValue(teacher.Id, out int currentCount);

                                if (currentCount < teacher.QuotaPerWeek &&
                                    !HasTeacherConflict(teacher.Id, day, period.Id) && !HasSubjectConflict(teacher.Id, subjectTeach.Id))
                                {
                                    var item = new ScheduleModel
                                    {
                                        TermSubjectId = subjectTeach.Id,
                                        Day = day.ToString(),
                                        periodId = period.Id,
                                        RoomId = room.Id,
                                        TeacherId = teacher.Id
                                    };

                                    schedule.Add(item);
                                    saveSchedule(item);

                                    teacherScheduleCount[teacher.Id] = currentCount + 1;
                                    scheduled = true;
                                    break;
                                }
                            }
                            if (scheduled) break;
                        }
                        if (scheduled) break;
                    }
                    if (scheduled) break;
                }

                if (!scheduled)
                {
                    Console.WriteLine($"Could not schedule subject: {subjectTeach.SubjectId}");
                }
            }
            Console.WriteLine("schedule data: ", schedule);
            return schedule;
        }

        private bool HasTeacherConflict(int teacherId ,DayOfWeek day, int periodId)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = dbContext.dbConnection;
                command.CommandText = @"
        SELECT 1
        FROM schedule
        WHERE ""Day"" = @Day
          AND ""TimePeriodId"" = @TimePeriodId
          AND ""TeacherId"" = @TeacherId
        LIMIT 1";

                command.Parameters.AddWithValue("@Day", day.ToString());
                command.Parameters.AddWithValue("@TimePeriodId", periodId);
                command.Parameters.AddWithValue("@TeacherId", teacherId);

                using (var reader = command.ExecuteReader())
                {
                    return reader.HasRows; // returns true if a matching row exists
                }
            }
        }

        bool IsTeacherEligible(int teacherId, int subjectId)
        {
            return !HasSubjectConflict(teacherId, subjectId) &&
                   !HasTeacherSubject(teacherId, subjectId);
        }

        private bool HasTeacherSubject(int teacherId,int subjectId)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = dbContext.dbConnection;
                command.CommandText = @"
SELECT 1
FROM schedule s
LEFT JOIN teacher_subject t ON s.""TermSubjectId"" = t.""Id""
WHERE t.""SubjectId"" = @SubjectId
  AND s.""TeacherId"" = @TeacherId
LIMIT 1;
";

                command.Parameters.AddWithValue("@SubjectId", subjectId);
                command.Parameters.AddWithValue("@TeacherId", teacherId);

                using (var reader = command.ExecuteReader())
                {
                    return reader.HasRows; // returns true if a matching row exists
                }
            }
        }


        private bool HasSubjectConflict(int teacherId,int subjectId)
        {
            using (var command = new NpgsqlCommand())
            {
                command.Connection = dbContext.dbConnection;
                command.CommandText = @"
                SELECT 1
                FROM teacher_subject
                WHERE ""SubjectId"" = @SubjectId
                  AND ""TeacherId"" = @TeacherId
                LIMIT 1";

                command.Parameters.AddWithValue("@SubjectId", subjectId);
                command.Parameters.AddWithValue("@TeacherId", teacherId);
                using (var reader = command.ExecuteReader())
                {
                    return reader.HasRows; // returns true if a matching row exists
                }
            }
        }

        private bool saveSchedule(ScheduleModel param)
        {
            try
            {
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = dbContext.dbConnection;
                    command.CommandText = $@"INSERT INTO schedule (""TermSubjectId"", ""Day"", ""TimePeriodId"", ""RoomId"", ""TeacherId"") VALUES ({param.TermSubjectId}, '{param.Day}', {param.periodId}, {param.RoomId}, {param.TeacherId})";
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving schedule: {ex.Message}");
                return false;
            }
        }

        public List<ScheduleModel> getScheduleReport(int TermId, int majorId, string teacherName)
        {
            try
            {
                string condition = @"WHERE 1=1"; // Makes it easier to append ANDs

                if (TermId != -1)
                {
                    condition += $@" AND schedule.""TermId"" = {TermId}";
                }

                if (majorId != -1)
                {
                    condition += $@" AND ""term_subjects"".""MajorId"" = {majorId}";
                }

                if (!string.IsNullOrWhiteSpace(teacherName))
                {
                    condition += $@" AND LOWER(teachers.""TeacherName"") LIKE LOWER('%{teacherName}%')";
                }

                List<ScheduleModel> scheduls = new List<ScheduleModel>();
                _command = new NpgsqlCommand();
                _command.Connection = dbContext.dbConnection;
                _command.CommandText = $@"
SELECT 
    schedule.""Id"",  
    schedule.""Day"",
    subject.""SubjectName"", 
    teachers.""TeacherName"",  
    time_period.""StartTime"", 
    time_period.""EndTime"",
    majors.""MajorName"",
    student_class.""StudentClassName""
FROM schedule
LEFT JOIN ""term_subjects"" ON schedule.""TermSubjectId"" = ""term_subjects"".""Id""
LEFT JOIN ""subject"" ON ""term_subjects"".""SubjectId"" = ""subject"".""Id""
LEFT JOIN ""majors"" ON ""majors"".""id"" = ""term_subjects"".""MajorId""
LEFT JOIN ""teachers"" ON ""teachers"".""Id"" = ""schedule"".""TeacherId""
LEFT JOIN ""time_period"" ON ""time_period"".""Id"" = ""schedule"".""TimePeriodId""
LEFT JOIN ""student_class"" ON ""student_class"".""Id"" = ""schedule"".""RoomId""
{condition}
ORDER BY teachers.""TeacherName"" ASC;";

                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    ScheduleModel schedule = new ScheduleModel();
                    schedule.Id = int.Parse(data["Id"].ToString());
                    schedule.Day = data["Day"].ToString();
                    schedule.TeacherName = data["TeacherName"].ToString();
                    schedule.subjectName = data["SubjectName"].ToString();
                    schedule.majorName = data["MajorName"].ToString();
                    schedule.period = data["StartTime"].ToString() + " - " + data["EndTime"].ToString();
                    schedule.RoomName = data["StudentClassName"].ToString();

                    scheduls.Add(schedule);
                }
                data.Close();
                return scheduls;
            }
            catch (Exception ex)
            {
                return [];
            }
        }


        public List<ScheduleModel> getScheduleReport(int TermId, int majorId)
        {
            try
            {
                string condition = @" ";
                if (TermId != -1)
                {
                    condition = $@"WHERE ""TermId"" = {TermId}";
                }

                if (majorId != -1)
                {
                    condition += $@" AND ""MajorId"" = {majorId}";
                }

                List<ScheduleModel> scheduls = new List<ScheduleModel>();
                _command = new NpgsqlCommand();
                _command.Connection = dbContext.dbConnection;
                _command.CommandText = $@"SELECT 
    schedule.""Id"",  
     schedule.""Day"",
    Subject.""SubjectName"", 
    teachers.""TeacherName"",  
    time_period.""StartTime"", 
    time_period.""EndTime"",
    majors.""MajorName"",
    student_class.""StudentClassName""
    FROM schedule
    LEFT JOIN ""term_subjects"" ON schedule.""TermSubjectId"" = ""term_subjects"".""Id""
    LEFT JOIN ""subject"" ON ""term_subjects"".""SubjectId"" = ""subject"".""Id""
    LEFT JOIN ""majors"" ON ""majors"".""id"" = ""term_subjects"".""MajorId""
    LEFT JOIN ""teachers"" ON ""teachers"".""Id"" = ""schedule"".""TeacherId""
    LEFT JOIN ""time_period"" ON ""time_period"".""Id"" = ""schedule"".""TimePeriodId""
    LEFT JOIN ""student_class"" ON ""student_class"".""Id"" = ""schedule"".""RoomId"" {condition} ORDER BY  teachers.""TeacherName"" ASC;";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    ScheduleModel schedule = new ScheduleModel();
                    schedule.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    schedule.Day = data.GetValue(data.GetOrdinal("Day")).ToString();
                    schedule.TeacherName = data.GetValue(data.GetOrdinal("TeacherName")).ToString();
                    schedule.subjectName = data.GetValue(data.GetOrdinal("SubjectName")).ToString();
                    schedule.majorName = data.GetValue(data.GetOrdinal("MajorName")).ToString();
                    schedule.period = data.GetValue(data.GetOrdinal("StartTime")).ToString() + " - " + data.GetValue(data.GetOrdinal("EndTime")).ToString();
                    schedule.RoomName = data.GetValue(data.GetOrdinal("StudentClassName")).ToString();

                    scheduls.Add(schedule);
                }
                data.Close();
                return scheduls;
            }
            catch (Exception ex)
            {
                return [];
            }
        }




        public List<ScheduleModel> getScheduleTeachers(string teacherCode)
        {
            try
            {
                string condition = @" ";
                if (teacherCode != null)
                {
                    condition = $@"WHERE ""TeacherCode"" = '{teacherCode}'";
                }



                List<ScheduleModel> scheduls = new List<ScheduleModel>();
                _command = new NpgsqlCommand();
                _command.Connection = dbContext.dbConnection;
                _command.CommandText = $@"SELECT 
    schedule.""Id"",  
     schedule.""Day"",
    Subject.""SubjectName"", 
    teachers.""TeacherCode"",  
    teachers.""TeacherName"",  
    time_period.""StartTime"", 
    time_period.""EndTime"",
    majors.""MajorName"",
    student_class.""StudentClassName""
    FROM schedule
    LEFT JOIN ""term_subjects"" ON schedule.""TermSubjectId"" = ""term_subjects"".""Id""
    LEFT JOIN ""subject"" ON ""term_subjects"".""SubjectId"" = ""subject"".""Id""
    LEFT JOIN ""majors"" ON ""majors"".""id"" = ""term_subjects"".""MajorId""
    LEFT JOIN ""teachers"" ON ""teachers"".""Id"" = ""schedule"".""TeacherId""
    LEFT JOIN ""time_period"" ON ""time_period"".""Id"" = ""schedule"".""TimePeriodId""
    LEFT JOIN ""student_class"" ON ""student_class"".""Id"" = ""schedule"".""RoomId"" {condition} ORDER BY  teachers.""TeacherName"" ASC;";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    ScheduleModel schedule = new ScheduleModel();
                    schedule.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    schedule.Day = data.GetValue(data.GetOrdinal("Day")).ToString();
                    schedule.TeacherName = data.GetValue(data.GetOrdinal("TeacherName")).ToString();
                    schedule.subjectName = data.GetValue(data.GetOrdinal("SubjectName")).ToString();
                    schedule.majorName = data.GetValue(data.GetOrdinal("MajorName")).ToString();
                    schedule.period = data.GetValue(data.GetOrdinal("StartTime")).ToString() + " - " + data.GetValue(data.GetOrdinal("EndTime")).ToString();
                    schedule.RoomName = data.GetValue(data.GetOrdinal("StudentClassName")).ToString();

                    scheduls.Add(schedule);
                }
                data.Close();
                return scheduls;
            }
            catch (Exception ex)
            {
                return [];
            }
        }

        public List<ScheduleModel> getScheduleAll(int TermId, int majorId, string teacherName, string searchType)
        {
            try
            {
                string condition = @"WHERE 1=1"; // Makes it easier to append ANDs
 
                if (TermId != -1)
                {
                    condition += $@" AND term_subjects.""TermId"" = {TermId}";
                }

                if (majorId != -1)
                {
                    condition += $@" AND ""term_subjects"".""MajorId"" = {majorId}";
                }
                if (searchType == "ມື້")
                {
                    if (!string.IsNullOrWhiteSpace(teacherName))
                    {
                        condition += $@" AND LOWER(schedule.""Day"") LIKE LOWER('%{teacherName}%')";
                    }
                }else if (searchType == "ຊື່ອາຈານ")
                {
                    if (!string.IsNullOrWhiteSpace(teacherName))
                    {
                        condition += $@" AND LOWER(teachers.""TeacherName"") LIKE LOWER('%{teacherName}%')";
                    }
                }else if (searchType == "ຊື່ວິຊາ")
                {
                    if (!string.IsNullOrWhiteSpace(teacherName))
                    {
                        condition += $@" AND LOWER(subject.""SubjectName"") LIKE LOWER('%{teacherName}%')";
                    }
                }


                    List<ScheduleModel> scheduls = new List<ScheduleModel>();
                _command = new NpgsqlCommand();
                _command.Connection = dbContext.dbConnection;
                _command.CommandText = $@"
SELECT 
    schedule.""Id"",  
    schedule.""Day"",
    subject.""SubjectName"", 
    teachers.""TeacherName"",  
    time_period.""StartTime"", 
    time_period.""EndTime"",
    majors.""MajorName"",
    student_class.""StudentClassName""
FROM schedule
LEFT JOIN ""term_subjects"" ON schedule.""TermSubjectId"" = ""term_subjects"".""Id""
LEFT JOIN ""subject"" ON ""term_subjects"".""SubjectId"" = ""subject"".""Id""
LEFT JOIN ""majors"" ON ""majors"".""id"" = ""term_subjects"".""MajorId""
LEFT JOIN ""teachers"" ON ""teachers"".""Id"" = ""schedule"".""TeacherId""
LEFT JOIN ""time_period"" ON ""time_period"".""Id"" = ""schedule"".""TimePeriodId""
LEFT JOIN ""student_class"" ON ""student_class"".""Id"" = ""schedule"".""RoomId""
{condition}
ORDER BY teachers.""TeacherName"" ASC;";

                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    ScheduleModel schedule = new ScheduleModel();
                    schedule.Id = int.Parse(data["Id"].ToString());
                    schedule.Day = data["Day"].ToString();
                    schedule.TeacherName = data["TeacherName"].ToString();
                    schedule.subjectName = data["SubjectName"].ToString();
                    schedule.majorName = data["MajorName"].ToString();
                    schedule.period = data["StartTime"].ToString() + " - " + data["EndTime"].ToString();
                    schedule.RoomName = data["StudentClassName"].ToString();

                    scheduls.Add(schedule);
                }
                data.Close();
                return scheduls;
            }
            catch (Exception ex)
            {
                return [];
            }
        }
    }
}
