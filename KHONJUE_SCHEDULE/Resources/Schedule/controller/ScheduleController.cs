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
        public ClassMajorController _classMajorController { get; set; }

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
            _classMajorController = new ClassMajorController(context);
            dbContext = context;
        }


        public List<ScheduleModel> GenerateSchedule()
        {
            List<ScheduleModel> schedule = new();

            // Get full list of days
            List<DayOfWeek> allDays = days;
            Random rng = new Random(); // For shuffling days

            var teachers = _teacherController.getTeachers("");
            var termSubjects = _subjectController.GetTermSubjectList();
            var periods = _periodController.getTimePeriod("");
            var rooms = _classController.GetStudentClasstList(""); // Must include RoomType ("lecture"/"lab")
            var subjects = _subjectController.GetSubjectList("");
            var classMajors = _classMajorController.GetStudentClasstList("");


            var teacherScheduleCount = new Dictionary<int, int>();
            var teacherOccupation = new HashSet<string>(); // day_period_teacherId
            var roomOccupation = new HashSet<string>();    // day_period_roomId
            var periodADay = new HashSet<string>();        // day_period for any subject
            var subjectDayTracker = new Dictionary<string, HashSet<string>>(); // termSubjectId_roomType -> used days                                                               // NEW – block two sessions of the *same class‑major* from overlapping
            var classMajorOccupation = new HashSet<string>();   // day_period_classMajorId

            var groupedSubjects = new List<(TermSubjectModel termSubject, SubjectModel subject, int type, int count)>();

            foreach (var termSubject in termSubjects)
            {
                var subject = subjects.FirstOrDefault(s => s.Id == termSubject.SubjectId);
                if (subject == null) continue;

                groupedSubjects.Add((termSubject, subject, 0, subject.Lecture)); // lecture
                groupedSubjects.Add((termSubject, subject, 1, subject.Lab));     // lab
            }

            foreach (var (termSubject, subject, type, sessionCount) in groupedSubjects)
            {
                string roomType = type == 0 ? "lecture" : "lab";

                var classList = classMajors
                    .Where(c => c.LevelId == termSubject.LevelId && c.MajorId == termSubject.MajorId)
                    .ToList();

                if (classList.Count == 0 || sessionCount == 0) continue;

                for (int session = 0; session < sessionCount; session++)
                {
                    // 👇 Schedule independently for each classMajor, but same subject/type/session index
                    foreach (var classMajor in classList)
                    {
                        bool scheduled = false;
                        List<DayOfWeek> days = allDays.OrderBy(_ => rng.Next()).ToList();
                        var eligibleTeachers = teachers
                            .Where(t => IsTeacherEligible(t.Id, subject.Id))
                            .OrderBy(t => teacherScheduleCount.TryGetValue(t.Id, out var cnt) ? cnt : 0)
                            .ToList();

                        foreach (var day in days)
                        {
                            string dayStr = day.ToString();
                            foreach (var period in periods)
                            {
                                string classKey = $"{dayStr}_{period.Id}_{classMajor.Id}";
                                if (classMajorOccupation.Contains(classKey)) continue;

                                foreach (var room in rooms.Where(r => r.RoomType.ToLower() == roomType.ToLower()))
                                {
                                    string roomKey = $"{dayStr}_{period.Id}_{room.Id}";
                                    if (roomOccupation.Contains(roomKey)) continue;

                                    foreach (var teacher in eligibleTeachers)
                                    {
                                        teacherScheduleCount.TryGetValue(teacher.Id, out var count);
                                        string teacherKey = $"{dayStr}_{period.Id}_{teacher.Id}_{roomType.ToLower()}";
                                        if (teacherOccupation.Contains(teacherKey)) continue;
                                        if (count >= teacher.QuotaPerWeek) continue;

                                        var item = new ScheduleModel
                                        {
                                            TermSubjectId = termSubject.Id,
                                            ClassMajorId = classMajor.Id,
                                            Day = dayStr,
                                            periodId = period.Id,
                                            RoomId = room.Id,
                                            TeacherId = teacher.Id,
                                            Type = roomType
                                        };

                                        schedule.Add(item);
                                        saveSchedule(item);

                                        // Update trackers
                                        teacherScheduleCount[teacher.Id] = count + 1;
                                        teacherOccupation.Add(teacherKey);
                                        roomOccupation.Add(roomKey);
                                        classMajorOccupation.Add(classKey);

                                        scheduled = true;
                                        break;
                                    }

                                    if (scheduled) break;
                                }

                                if (scheduled) break;
                            }

                            if (scheduled) break;
                        }

                        if (!scheduled)
                        {
                            Console.WriteLine($"⚠️ Could not schedule {subject.SubjectName} ({roomType}) for ClassMajor: {classMajor.Id}");
                        }
                    }
                }
            }



            return schedule;
        }


        bool IsTeacherEligible(int teacherId, int subjectId)
        {
            return HasSubjectConflict(teacherId, subjectId);
        }

//        private bool HasTeacherSubject(int teacherId,int subjectId)
//        {
//            using (var command = new NpgsqlCommand())
//            {
//                command.Connection = dbContext.dbConnection;
//                command.CommandText = @"
//SELECT 1
//FROM schedule s
//LEFT JOIN teacher_subject t ON s.""TermSubjectId"" = t.""Id""
//WHERE t.""SubjectId"" = @SubjectId
//  AND s.""TeacherId"" = @TeacherId
//LIMIT 1;
//";

//                command.Parameters.AddWithValue("@SubjectId", subjectId);
//                command.Parameters.AddWithValue("@TeacherId", teacherId);

//                using (var reader = command.ExecuteReader())
//                {
//                    return reader.HasRows; // returns true if a matching row exists
//                }
//            }
//        }


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
                    command.CommandText = $@"
INSERT INTO schedule (""TermSubjectId"", ""Day"", ""TimePeriodId"", ""RoomId"", ""TeacherId"", ""Type"", ""ClassMajorId"") VALUES ({param.TermSubjectId}, '{param.Day}', {param.periodId}, {param.RoomId}, {param.TeacherId}, '{param.Type}', {param.ClassMajorId});
";
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

        public bool EditSchedule(int id, ScheduleModel param)
        {
            try
            {
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = dbContext.dbConnection;
                    command.CommandText = $@"UPDATE schedule  SET ""Day"" = '{param.Day}', ""TimePeriodId"" = {param.periodId}, ""RoomId""={param.RoomId}, ""TeacherId""={param.TeacherId} WHERE ""Id"" = {id};";
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
    student_class.""StudentClassName"",
    terms.""TermName"",
    study_level.""LevelName""
    FROM schedule
    LEFT JOIN ""term_subjects"" ON schedule.""TermSubjectId"" = ""term_subjects"".""Id""
    LEFT JOIN ""subject"" ON ""term_subjects"".""SubjectId"" = ""subject"".""Id""
    LEFT JOIN ""terms"" ON term_subjects.""TermId"" = ""terms"".""Id""
    LEFT JOIN ""study_level"" ON term_subjects.""LevelId"" = ""study_level"".""Id""
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
                    schedule.termName = data["TermName"].ToString();
                    schedule.levelName = data["LevelName"].ToString();
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




        public List<ScheduleModel> getScheduleTeachers(string day,string teacherCode)
        {
            try
            {
                string condition = @" ";
     
                if (!string.IsNullOrEmpty(teacherCode) || !string.IsNullOrEmpty(day))
                {
                    condition = $@"WHERE ""TeacherCode"" = '{teacherCode}' AND ""Day"" = '{day}'";
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
    student_class.""StudentClassName"",
    terms.""TermName"",
    study_level.""LevelName""
    FROM schedule
    LEFT JOIN ""term_subjects"" ON schedule.""TermSubjectId"" = ""term_subjects"".""Id""
    LEFT JOIN ""subject"" ON ""term_subjects"".""SubjectId"" = ""subject"".""Id""
    LEFT JOIN ""majors"" ON ""majors"".""id"" = ""term_subjects"".""MajorId""
    LEFT JOIN ""terms"" ON term_subjects.""TermId"" = ""terms"".""Id""
    LEFT JOIN ""study_level"" ON term_subjects.""LevelId"" = ""study_level"".""Id""
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
                    schedule.levelName = data["LevelName"].ToString();
                    schedule.TeacherName = data.GetValue(data.GetOrdinal("TeacherName")).ToString();
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

        public List<ScheduleModel> getScheduleStudent(string keyword)
        {
            try
            {
                string condition = @" ";

                if (!string.IsNullOrEmpty(keyword) )
                {
                    condition = $@"WHERE ""ClassName"" = '{keyword}'";
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
    student_class.""StudentClassName"",
    terms.""TermName"",
    study_level.""LevelName"",
    schedule.""ClassMajorId"",
    class_major.""ClassName""
    FROM schedule
    LEFT JOIN ""term_subjects"" ON schedule.""TermSubjectId"" = ""term_subjects"".""Id""
    LEFT JOIN ""subject"" ON ""term_subjects"".""SubjectId"" = ""subject"".""Id""
    LEFT JOIN ""majors"" ON ""majors"".""id"" = ""term_subjects"".""MajorId""
    LEFT JOIN ""terms"" ON term_subjects.""TermId"" = ""terms"".""Id""
    LEFT JOIN ""study_level"" ON term_subjects.""LevelId"" = ""study_level"".""Id""
    LEFT JOIN ""teachers"" ON ""teachers"".""Id"" = ""schedule"".""TeacherId""
    LEFT JOIN ""time_period"" ON ""time_period"".""Id"" = ""schedule"".""TimePeriodId""
    LEFT JOIN ""class_major"" ON ""class_major"".""Id"" = ""schedule"".""ClassMajorId""
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
                    schedule.levelName = data["LevelName"].ToString();
                    schedule.TeacherName = data.GetValue(data.GetOrdinal("TeacherName")).ToString();
                    schedule.ClassName = data["ClassName"].ToString();
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

        public bool checkHasSchedule()
        {
            string query = @$"SELECT 1 FROM schedule;";
            using (var command = new NpgsqlCommand())
            {
                command.Connection = dbContext.dbConnection;
                command.CommandText = query;

                using (var reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        public bool deleteSchedule()
        {
            string query = @$"delete from schedule;";
            using (var command = new NpgsqlCommand())
            {
                command.Connection = dbContext.dbConnection;
                command.CommandText = query;

                using (var reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        public List<ScheduleModel> getScheduleAll(int levelId, int TermId, int majorId,int classMajorId,string teacherName, string searchType)
        {
            try
            {
                string condition = @"WHERE 1=1"; // Makes it easier to append ANDs
                if (classMajorId != -1)
                {
                    condition += $@" AND schedule.""ClassMajorId"" = {classMajorId}";
                }

                if (levelId != -1)
                {
                    condition += $@" AND term_subjects.""LevelId"" = {levelId}";
                }
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
    schedule.""Type"",
    schedule.""TeacherId"",  
    schedule.""RoomId"",  
    schedule.""TimePeriodId"",
    subject.""SubjectName"", 
    teachers.""TeacherName"",  
    time_period.""StartTime"", 
    time_period.""EndTime"",
    majors.""MajorName"",
    student_class.""StudentClassName"",  
    schedule.""ClassMajorId"",  
    terms.""TermName"",
    study_level.""LevelName"",
    class_major.""ClassName"",
    term_subjects.""MajorId"",
    term_subjects.""LevelId"",
    term_subjects.""TermId"",
    term_subjects.""SubjectId""
FROM schedule
LEFT JOIN ""class_major"" ON schedule.""ClassMajorId"" = ""class_major"".""Id""
LEFT JOIN ""term_subjects"" ON schedule.""TermSubjectId"" = ""term_subjects"".""Id""
LEFT JOIN ""subject"" ON ""term_subjects"".""SubjectId"" = ""subject"".""Id""
LEFT JOIN ""majors"" ON ""majors"".""id"" = ""term_subjects"".""MajorId""
LEFT JOIN ""terms"" ON term_subjects.""TermId"" = ""terms"".""Id""
LEFT JOIN ""study_level"" ON term_subjects.""LevelId"" = ""study_level"".""Id""
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
                    schedule.termName = data["TermName"].ToString();
                    schedule.levelName = data["LevelName"].ToString();
                    schedule.subjectName = data["SubjectName"].ToString();
                    schedule.ClassName = data["ClassName"].ToString();
                    schedule.majorName = data["MajorName"].ToString();
                    schedule.period = data["StartTime"].ToString() + " - " + data["EndTime"].ToString();
                    schedule.TeacherId = int.Parse(data["TeacherId"].ToString());
                    schedule.periodId = int.Parse(data["TimePeriodId"].ToString());
                    schedule.RoomId = int.Parse(data["RoomId"].ToString());
                    schedule.RoomName = data["StudentClassName"].ToString();
                    schedule.Type = data["Type"].ToString();
                    schedule.ClassMajorId = int.Parse(data["ClassMajorId"].ToString());
                    schedule.subjectId = int.Parse(data["SubjectId"].ToString());
                    schedule.majorId = int.Parse(data["MajorId"].ToString());
                    schedule.termId = int.Parse(data["TermId"].ToString());
                    schedule.levelId = int.Parse(data["levelId"].ToString());
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
