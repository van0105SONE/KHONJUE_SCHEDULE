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
    public class LevelController
    {
        private DatabaseContext _databaseContext;
        private NpgsqlCommand _command;
        public LevelController(DatabaseContext context) { 
          _databaseContext = context;
        }

        public bool editLevel(string levelName, int Id)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"UPDATE study_level SET ""LevelName""='{levelName}' WHERE id={Id}";
                _command.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                return false;
            }

        }

        public bool CreateLevel(LevelModel levelParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO study_level (""LevelCode"", ""LevelName"") VALUES ('KJ{DateTime.Now.Ticks}', '{levelParams.LevelName}')";
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
                _command.CommandText = $@"DELETE FROM study_level  WHERE ""Id"" = {Id};";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public List<LevelModel> getLevels()
        {
            try
            {
                List<LevelModel> levels = new List<LevelModel>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT study_level.""Id"", study_level.""LevelName"", study_level.""LevelCode"" FROM study_level";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    LevelModel level = new LevelModel();
                    level.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    level.LevelName = data.GetValue(data.GetOrdinal("LevelName")).ToString();
                    level.LevelCode = data.GetValue(data.GetOrdinal("LevelCode")).ToString();
                    levels.Add(level);
                }
                data.Close();
                return levels;
            }
            catch(Exception ex)
            {
                return new List<LevelModel>() { };
            }
        }
    }
}
