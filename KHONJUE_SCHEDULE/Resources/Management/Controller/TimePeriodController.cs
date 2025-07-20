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
    public class TimePeriodController
    {
        private DatabaseContext _databaseContext;
        private NpgsqlCommand _command;
        public TimePeriodController(DatabaseContext context)
        {
            _databaseContext = context;
        }

        public bool createTimePeriod(TimePeriodModel timeParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO time_period (""PeriodCode"", ""StartTime"",""EndTime"") VALUES ('TP{DateTime.Now.Ticks}', '{timeParams.startTime}', '{timeParams.endTime}')";
                _command.ExecuteNonQuery();
                return true;
            }catch(Exception ex) {
                return false;
            }
        }

        public bool updateTimePeriod(TimePeriodModel timeParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"UPDATE time_period SET ""StartTime""= '{timeParams.startTime}',""EndTime""='{timeParams.endTime}' WHERE ""Id"" = {timeParams.Id};";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool updateTimePeriod(int Id)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"DELETE FROM time_period WHERE ""Id"" = {Id};";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<TimePeriodModel> getTimePeriod(string keyword)
        {
            try
            {
                string condition = "";
                if (!string.IsNullOrEmpty(keyword))
                {
                    condition += $@"WHERE LOWER(""PeriodCode"") LIKE LOWER('%{keyword}%');";
                }
                List<TimePeriodModel>  timePeiods = new List<TimePeriodModel>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT * FROM public.time_period;";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    TimePeriodModel subject = new TimePeriodModel();
                    subject.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    subject.periodCode = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("PeriodCode")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("PeriodCode")).ToString();
                    subject.startTime = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("StartTime")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("StartTime")).ToString();
                    subject.endTime = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("EndTime")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("EndTime")).ToString();

                    timePeiods.Add(subject);
                }
                data.Close();
                return timePeiods;
            }
            catch (Exception ex)
            {
                return new List<TimePeriodModel>();
            }
        }

        public List<TimePeriodModel> getFreeTimePeriod(string day, int teacherId)
        {
            try
            {
 

                List<TimePeriodModel> timePeiods = new List<TimePeriodModel>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"
    SELECT * 
    FROM public.time_period tp
    WHERE NOT EXISTS (
        SELECT 1 
        FROM schedule s 
        WHERE s.""TimePeriodId"" = tp.""Id"" AND s.""Day"" = '{day}' AND s.""TeacherId"" = {teacherId}
    );";

                NpgsqlDataReader data = _command.ExecuteReader();

                while (data.Read())
                {
                    TimePeriodModel subject = new TimePeriodModel();
                    subject.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    subject.periodCode = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("PeriodCode")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("PeriodCode")).ToString();
                    subject.startTime = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("StartTime")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("StartTime")).ToString();
                    subject.endTime = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("EndTime")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("EndTime")).ToString();
                    timePeiods.Add(subject);
                }

                data.Close();
                return timePeiods;

            }
            catch (Exception ex)
            {
                return new List<TimePeriodModel>();
            }
        }
    }
}
