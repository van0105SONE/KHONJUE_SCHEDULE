using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using Npgsql;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Controller
{
    public class TeacherAndSubjectController
    {

        private DatabaseContext _databaseContext;
        private NpgsqlCommand _command;

        public TeacherAndSubjectController(DatabaseContext context)
        {
            _databaseContext = context;
        }

        public bool addSubjectTeacher(int subjectId, int teacherId)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO teacher_subject (""SubjectId"", ""TeacherId"") VALUES ({subjectId}, {teacherId})";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteAll()
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"DELETE FROM  teacher_subject;";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteSubjectTeacher(int id)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"DELETE FROM  teacher_subject WHERE ""Id""={id}";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TeacherSubject> GetTeacherSubjectList()
        {
            try
            {
                List<TeacherSubject> teacherSubjects = new List<TeacherSubject>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT teacher_subject.""Id"",teacher_subject.""TeacherId"", subject.""SubjectName"", teachers.""TeacherName"" FROM public.teacher_subject LEFT JOIN  teachers ON teacher_subject.""TeacherId"" =  teachers.""Id""  LEFT JOIN  subject ON teacher_subject.""SubjectId"" = subject.""Id"";";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    TeacherSubject teacherSubject = new TeacherSubject();
                    teacherSubject.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    teacherSubject.TeacherId = int.Parse(data.GetValue(data.GetOrdinal("TeacherId")).ToString(), 0);
                    teacherSubject.SubjectName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("SubjectName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("SubjectName")).ToString();
                    teacherSubject.TeacherName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("TeacherName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("TeacherName")).ToString();

                    teacherSubjects.Add(teacherSubject);
                }
                data.Close();
                return teacherSubjects;
            }
            catch (Exception ex)
            {
                return new List<TeacherSubject>();
            }
        }

    }
}
