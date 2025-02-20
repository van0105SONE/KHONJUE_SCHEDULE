using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Controller
{
    public class StudentClassController
    {
        private DatabaseContext _databaseContext;
        private NpgsqlCommand _command;
        public StudentClassController(DatabaseContext context)
        {
            _databaseContext = context;
        }

        public bool createStudentClass(StudentClassModel classParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO student_class (""Code"", ""StudentClassName"",""Description"" ,""LevelId"", ""NumberOfClass"") VALUES ('SCKJ{DateTime.Now.Ticks}', '{classParams.StudentClassName}', '{classParams.Description}',{classParams.LevelId}, '{classParams.NumberOfClass}')";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool editStudentClass(StudentClassModel classParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"UPDATE student_class SET ""StudentClassName""='{classParams.StudentClassName}',""Description""='{classParams.Description}',""NumberOfClass""={classParams.NumberOfClass} ,""LevelId""={classParams.LevelId}  WHERE ""Id"" = '{classParams.Id}';";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool deleteStudent(int Id)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"DELETE FROM student_class WHERE ""Id"" = '{Id}'";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<StudentClassModel> GetStudentClasstList()
        {
            try
            {
                List<StudentClassModel> classes = new List<StudentClassModel>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT student_class.""Id"",student_class.""Code"", student_class.""StudentClassName"", student_class.""Description"", student_class.""LevelId"",level.""LevelCode"" ,level.""LevelName"",student_class.""NumberOfClass""    FROM public.student_class LEFT JOIN  study_level as level ON level.id = student_class.""LevelId"";";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    StudentClassModel studentClass = new StudentClassModel();
                    studentClass.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    studentClass.Code = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("Code")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("Code")).ToString();
                    studentClass.NumberOfClass = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("NumberOfClass")).ToString()) ? 1 : int.Parse( data.GetValue(data.GetOrdinal("NumberOfClass")).ToString());
                    studentClass.StudentClassName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("StudentClassName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("StudentClassName")).ToString();
                    studentClass.Description = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("Description")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("Description")).ToString();
                    studentClass.LevelId = int.Parse(data.GetValue(data.GetOrdinal("LevelId")).ToString());
                    studentClass.LevelCode = data.GetValue(data.GetOrdinal("LevelCode")).ToString();
                    studentClass.LevelName = data.GetValue(data.GetOrdinal("LevelName")).ToString();
                    classes.Add(studentClass);
                }
                data.Close();
                return classes;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
