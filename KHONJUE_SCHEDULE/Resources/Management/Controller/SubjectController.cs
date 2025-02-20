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
    public class SubjectController
    {
        private DatabaseContext _databaseContext;
        private NpgsqlCommand _command;
        public SubjectController(DatabaseContext context)
        {
            _databaseContext = context;
        }

        public bool createSubject(SubjectModel subjectParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO subject (""SubjectCode"", ""SubjectName"",""SubjectDescription"" ,""LevelId"") VALUES ('SKJ{DateTime.Now.Ticks}', '{subjectParams.SubjectName}', '{subjectParams.Description}',{subjectParams.LevelId})";
                _command.ExecuteNonQuery();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool deleteSubject(int subjectId)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"DELETE FROM subject WHERE ""Id"" = '{subjectId}'";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool editSubject(SubjectModel subjectParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"UPDATE subject SET ""SubjectName""='{subjectParams.SubjectName}',""SubjectDescription""='{subjectParams.Description}' ,""LevelId""={subjectParams.LevelId}  WHERE ""Id"" = '{subjectParams.Id}';";
                _command.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                return false;
            }

        }


        public List<SubjectModel> GetSubjectList()
        {
            try
            {
                List<SubjectModel> subjects = new List<SubjectModel>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT * FROM public.subject LEFT JOIN  study_level ON study_level.id = subject.""LevelId"";";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    SubjectModel subject = new SubjectModel();
                    subject.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    subject.SubjectCode = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("SubjectCode")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("SubjectCode")).ToString();
                    subject.SubjectName = string.IsNullOrEmpty( data.GetValue(data.GetOrdinal("SubjectName")).ToString())? "N/A" : data.GetValue(data.GetOrdinal("SubjectName")).ToString();
                    subject.Description = string.IsNullOrEmpty( data.GetValue(data.GetOrdinal("SubjectDescription")).ToString())? "N/A" : data.GetValue(data.GetOrdinal("SubjectDescription")).ToString();
                    subject.LevelId =     int.Parse( data.GetValue(data.GetOrdinal("LevelId")).ToString());
                    subject.LevelCode =   data.GetValue(data.GetOrdinal("LevelCode")).ToString();
                    subject.LevelName =   data.GetValue(data.GetOrdinal("LevelName")).ToString();
                    subjects.Add(subject);
                }
                data.Close();
                return subjects;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
