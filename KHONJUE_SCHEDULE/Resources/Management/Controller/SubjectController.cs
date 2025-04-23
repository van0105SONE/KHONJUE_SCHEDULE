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
        public bool AddSubjectAndTerm(int subjectId,int termId, int levelId)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO term_subjects (""SubjectId"", ""TermId"",""LevelId"" ) VALUES ({subjectId}, {termId}, {levelId})";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool createSubject(SubjectModel subjectParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO subject (""SubjectCode"", ""SubjectName"",""Description"" , ""CurriculumId"") VALUES ('SKJ{DateTime.Now.Ticks}', '{subjectParams.SubjectName}', '{subjectParams.Description}', {subjectParams.CurriculumId})";
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
                _command.CommandText = $@"UPDATE subject SET ""SubjectName""='{subjectParams.SubjectName}',""Description""='{subjectParams.Description}'  WHERE ""Id"" = '{subjectParams.Id}';";
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
                _command.CommandText = $@"SELECT subject.""Id"", subject.""SubjectCode"", subject.""SubjectName"", subject.""Description"", subject.""CurriculumId"",curriculum.""CurriculumName"" FROM public.subject LEFT JOIN  curriculum ON subject.""CurriculumId"" = curriculum.""Id"" ;";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    SubjectModel subject = new SubjectModel();
                    subject.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    subject.SubjectCode = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("SubjectCode")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("SubjectCode")).ToString();
                    subject.SubjectName = string.IsNullOrEmpty( data.GetValue(data.GetOrdinal("SubjectName")).ToString())? "N/A" : data.GetValue(data.GetOrdinal("SubjectName")).ToString();
                    subject.Description = string.IsNullOrEmpty( data.GetValue(data.GetOrdinal("Description")).ToString())? "N/A" : data.GetValue(data.GetOrdinal("Description")).ToString();
                    subject.CurriculumId =     int.Parse( data.GetValue(data.GetOrdinal("CurriculumId")).ToString());
                    subject.CurriculumName = data.GetValue(data.GetOrdinal("CurriculumName")).ToString();
                    subjects.Add(subject);
                }
                data.Close();
                return subjects;
            }
            catch (Exception ex)
            {
                return new List<SubjectModel>();
            }
        }

        public List<TermSubjectModel> GetTermSubjectList()
        {
            try
            {
                List<TermSubjectModel> subjects = new List<TermSubjectModel>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT term_subjects.""Id"", subject.""SubjectName"", terms.""TermName"", study_level.""LevelName"" FROM public.term_subjects LEFT JOIN  subject ON term_subjects.""SubjectId"" = subject.""Id"" LEFT JOIN  terms ON term_subjects.""TermId"" = terms.""Id""  LEFT JOIN  study_level ON term_subjects.""LevelId"" = study_level.""Id"";";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    TermSubjectModel subject = new TermSubjectModel();
                    subject.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    subject.SubjectName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("SubjectName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("SubjectName")).ToString();
                    subject.TermName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("TermName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("TermName")).ToString();
                    subject.LevelName = string.IsNullOrEmpty(data.GetValue(data.GetOrdinal("LevelName")).ToString()) ? "N/A" : data.GetValue(data.GetOrdinal("LevelName")).ToString();

                    subjects.Add(subject);
                }
                data.Close();
                return subjects;
            }
            catch (Exception ex)
            {
                return new List<TermSubjectModel>();
            }
        }


    }
}
