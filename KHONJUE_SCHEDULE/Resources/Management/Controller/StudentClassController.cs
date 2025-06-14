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
                _command.CommandText = $@"INSERT INTO student_class (""Code"", ""StudentClassName"",""Description"" ,""NumberOfClass"", ""RoomType"") VALUES ('SCKJ{DateTime.Now.Ticks}', '{classParams.StudentClassName}', '{classParams.Description}', '{classParams.NumberOfClass}', '{classParams.RoomType}')";
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
                _command.CommandText = $@"UPDATE student_class SET ""StudentClassName""='{classParams.StudentClassName}'  WHERE ""Id"" = '{classParams.Id}';";
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
                _command.CommandText = $@"SELECT student_class.""Id"",student_class.""Code"", student_class.""StudentClassName"", student_class.""Description"",student_class.""NumberOfClass"",student_class.""RoomType""    FROM public.student_class;";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    StudentClassModel studentClass = new StudentClassModel();
                    studentClass.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    studentClass.Code = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("Code")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("Code")).ToString();
                    studentClass.NumberOfClass = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("NumberOfClass")).ToString()) ? 1 : int.Parse( data.GetValue(data.GetOrdinal("NumberOfClass")).ToString());
                    studentClass.StudentClassName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("StudentClassName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("StudentClassName")).ToString();
                    studentClass.Description = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("Description")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("Description")).ToString();
                    studentClass.RoomType = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("RoomType")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("RoomType")).ToString();
                    classes.Add(studentClass);
                }
                data.Close();
                return classes;
            }
            catch (Exception ex)
            {
                return new List<StudentClassModel>();
            }
        }
    }
}
