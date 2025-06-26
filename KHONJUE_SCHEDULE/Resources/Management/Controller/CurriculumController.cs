using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Controller
{
    class CurriculumController
    {
        private DatabaseContext _databaseContext;
        private NpgsqlCommand _command;
        public CurriculumController(DatabaseContext context)
        {
            _databaseContext = context;
        }

        public bool createCurriculum(CurriculumModel curriculumParam)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO curriculum ( ""CurriculumName"",""Description"" ) VALUES ( '{curriculumParam.CurriculumName}', '{curriculumParam.Description}')";
                _command.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool updateCurriculum(CurriculumModel curriculumParam)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"UPDATE curriculum SET ""CurriculumName""='{curriculumParam.CurriculumName}',""Description""='{curriculumParam.Description}' WHERE ""Id"" = '{curriculumParam.Id}';";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<CurriculumModel> GetCurriculumList()
        {
            try
            {
                List<CurriculumModel> classes = new List<CurriculumModel>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT Curriculum.""Id"", Curriculum.""CurriculumName"", Curriculum.""Description"" FROM Curriculum;";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    CurriculumModel curriculum = new CurriculumModel();
                    curriculum.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    curriculum.CurriculumName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("CurriculumName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("CurriculumName")).ToString();
                    curriculum.Description = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("Description")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("Description")).ToString();
                    classes.Add(curriculum);
                }
                data.Close();
                return classes;
            }
            catch (Exception ex)
            {
                return new List<CurriculumModel>();
            }
        }

        public bool deleteCurriculum(int Id)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"DELETE FROM curriculum WHERE ""Id"" = {Id};";
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
                _command.CommandText = $@"DELETE FROM curriculum;";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
