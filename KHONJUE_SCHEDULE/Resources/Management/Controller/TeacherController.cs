using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using Microsoft.VisualBasic.Devices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Controller
{
    public class TeacherController
    {
        private DatabaseContext _databaseContext;
        private NpgsqlCommand _command;

        public TeacherController(DatabaseContext context)
        {
            _databaseContext = context;
        }
        public bool CreateTeacher(TeacherModel teacherParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO teachers (""TeacherCode"",""TeacherName"",""Description"", ""QuotaPerWeek"", ""Phone"") VALUES ('KJ{DateTime.Now.Ticks}', '{teacherParams.TeacherName}', '{teacherParams.Description}', {teacherParams.QuotaPerWeek}, '{teacherParams.Phone}')";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool editTeacher(TeacherModel teacherParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"UPDATE teachers SET ""TeacherName""='{teacherParams.TeacherName}',""Description""='{teacherParams.Description}',""QuotaPerWeek""={teacherParams.QuotaPerWeek}, ""Phone""='{teacherParams.Phone}' WHERE  ""Id"" = {teacherParams.Id}";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool deleteTeacher(int Id)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"DELETE FROM teachers  WHERE ""Id"" = {Id};";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool deteleAll()
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"DELETE FROM teachers;";
                _command.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                return false;
            }

        }


        public List<TeacherModel> getTeachers(string keyword)
        {
            try
            {
                string condition = "";
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += $@"WHERE LOWER(""TeacherCode"") LIKE LOWER('%{keyword}%') OR LOWER(""TeacherName"") LIKE LOWER('%{keyword}%')";
                }
                List<TeacherModel> teachers = new List<TeacherModel>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT teachers.""Id"", teachers.""TeacherName"", teachers.""TeacherCode"", teachers.""Description"", teachers.""QuotaPerWeek"", teachers.""Phone"" FROM teachers {condition};";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    TeacherModel teacher = new TeacherModel();
                    teacher.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    teacher.TeacherCode = data.GetValue(data.GetOrdinal("TeacherCode")).ToString();
                    teacher.TeacherName = data.GetValue(data.GetOrdinal("TeacherName")).ToString();
                    teacher.Description = data.GetValue(data.GetOrdinal("Description")).ToString();
                    teacher.Phone = data.GetValue(data.GetOrdinal("Phone")).ToString();
                    teacher.QuotaPerWeek = int.Parse(data.GetValue(data.GetOrdinal("QuotaPerWeek")).ToString());
                    teachers.Add(teacher);
                }
                data.Close();
                return teachers;
            }
            catch (Exception ex)
            {
                return [];
            }
        }

    }
}
