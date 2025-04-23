using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using KHONJUE_SCHEDULE.Resources.Users.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Management.Controller
{
    public class MajorController
    {
        private DatabaseContext _databaseContext;
        private NpgsqlCommand _command;
        public MajorController(DatabaseContext context) { 
          _databaseContext = context;
        }

        public bool editLevel(MajorModel majorParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"UPDATE majors SET ""MajorName""='{majorParams.MajorName},  ""LimitPerClass""='{majorParams.LimitPerClass},""CurriculumId""='{majorParams.CurriculumId}' WHERE id={majorParams.Id}";
                _command.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                return false;
            }

        }

        public bool CreateLevel(MajorModel majorParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO majors (""MajorCode"", ""MajorName"", ""LimitPerClass"" , ""CurriculumId"") VALUES ('KJ{DateTime.Now.Ticks}', '{majorParams.MajorName}', {majorParams.LimitPerClass}, {majorParams.CurriculumId})";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public bool deleteLevel(int Id)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"DELETE FROM majors  WHERE ""id"" = {Id};";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public List<MajorModel> getLevels()
        {
            try
            {
                List<MajorModel> levels = new List<MajorModel>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT majors.""id"", majors.""MajorCode"", majors.""MajorName"",  majors.""LimitPerClass"" ,majors.""CurriculumId"",curriculum.""CurriculumName""  FROM majors LEFT JOIN curriculum ON majors.""CurriculumId"" = curriculum.""Id""";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    MajorModel major = new MajorModel();
                    major.Id = int.Parse(data.GetValue(data.GetOrdinal("id")).ToString(), 0);
                    major.MajorCode = data.GetValue(data.GetOrdinal("MajorCode")).ToString();
                    major.MajorName = data.GetValue(data.GetOrdinal("MajorName")).ToString();
                    major.LimitPerClass = int.Parse(data.GetValue(data.GetOrdinal("LimitPerClass")).ToString());
                    major.CurriculumId = int.Parse(data.GetValue(data.GetOrdinal("CurriculumId")).ToString());
                    major.CurriculumName = data.GetValue(data.GetOrdinal("CurriculumName")).ToString();
                    levels.Add(major);
                }
                data.Close();
                return levels;
            }
            catch(Exception ex)
            {
                return [];
            }
        }
    }
}
