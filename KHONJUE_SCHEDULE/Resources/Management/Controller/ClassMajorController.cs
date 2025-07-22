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
    public class ClassMajorController
    {
        private DatabaseContext _databaseContext;
        private NpgsqlCommand _command;
        public ClassMajorController(DatabaseContext context)
        {
            _databaseContext = context;
        }

        public bool createStudentClass(ClassMajor classParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO class_major (""ClassName"",""LevelId"" ,""MajorId"") VALUES ('{classParams.ClassName}', '{classParams.LevelId}', '{classParams.MajorId}')";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool editStudentClass(ClassMajor classParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"UPDATE class_major SET ""ClassName""='{classParams.ClassName}',""LevelId""='{classParams.LevelId}' ,""MajorId""={classParams.MajorId}  WHERE ""Id"" = '{classParams.Id}';";
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
                _command.CommandText = $@"DELETE FROM class_major WHERE ""Id"" = '{Id}'";
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
                _command.CommandText = $@"DELETE FROM class_major;";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<ClassMajor> GetStudentClasstList(string keyword)
        {
            try
            {
                List<ClassMajor> classes = new List<ClassMajor>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT class_major.""Id"",class_major.""ClassName"", class_major.""LevelId"", class_major.""MajorId"",majors.""MajorName"",study_level.""LevelName""  FROM public.class_major
                                        LEFT JOIN ""majors"" ON  ""class_major"".""MajorId"" = ""majors"".""id"" 
                                        LEFT JOIN ""study_level"" ON class_major.""LevelId"" = ""study_level"".""Id"";";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    ClassMajor studentClass = new ClassMajor();
                    studentClass.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    studentClass.ClassName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("ClassName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("ClassName")).ToString();
                    studentClass.MajorId = int.Parse( data.GetValue(data.GetOrdinal("MajorId")).ToString());
                    studentClass.LevelId = int.Parse(data.GetValue(data.GetOrdinal("LevelId")).ToString());
                    studentClass.MajorName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("MajorName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("MajorName")).ToString();
                    studentClass.LevelName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("LevelName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("LevelName")).ToString();
                    classes.Add(studentClass);
                }
                data.Close();
                return classes;
            }
            catch (Exception ex)
            {
                return new List<ClassMajor>();
            }
        }

        public List<ClassMajor> GetRoomByMajor(int majorId)
        {
            try
            {
                List<ClassMajor> classes = new List<ClassMajor>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT class_major.""Id"",class_major.""ClassName"", class_major.""LevelId"", class_major.""MajorId"",majors.""MajorName"",study_level.""LevelName""  FROM public.class_major
                                        LEFT JOIN ""majors"" ON  ""class_major"".""MajorId"" = ""majors"".""id"" 
                                        LEFT JOIN ""study_level"" ON class_major.""LevelId"" = ""study_level"".""Id"" WHERE class_major.""MajorId"" = {majorId};";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    ClassMajor studentClass = new ClassMajor();
                    studentClass.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    studentClass.ClassName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("ClassName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("ClassName")).ToString();
                    studentClass.MajorId = int.Parse(data.GetValue(data.GetOrdinal("MajorId")).ToString());
                    studentClass.LevelId = int.Parse(data.GetValue(data.GetOrdinal("LevelId")).ToString());
                    studentClass.MajorName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("MajorName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("MajorName")).ToString();
                    studentClass.LevelName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("LevelName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("LevelName")).ToString();
                    classes.Add(studentClass);
                }
                data.Close();
                return classes;
            }
            catch (Exception ex)
            {
                return new List<ClassMajor>();
            }
        }
    }
}
