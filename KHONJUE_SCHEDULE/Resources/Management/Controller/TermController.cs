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
    public class TermController
    {
        private DatabaseContext _databaseContext;
        private NpgsqlCommand _command;
        public TermController(DatabaseContext context) { 
          _databaseContext = context;
        }

        public bool editTerm(string termName, int Id)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"UPDATE terms SET ""TermName""='{termName}' WHERE id={Id}";
                _command.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                return false;
            }

        }

        public bool CreateTerm(TermModel termParams)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO terms (""TermCode"", ""TermName"") VALUES ('TM{DateTime.Now.Ticks}', '{termParams.TermName}')";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public bool deleteTerm(int Id)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"DELETE FROM terms  WHERE ""Id"" = {Id};";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool deleteTermAll()
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"DELETE FROM terms;";
                _command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public List<TermModel> getTerms()
        {
            try
            {
                List<TermModel> terms = new List<TermModel>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"SELECT terms.""Id"", terms.""TermName"", terms.""TermCode"" FROM terms;";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    TermModel term = new TermModel();
                    term.Id = int.Parse(data.GetValue(data.GetOrdinal("Id")).ToString(), 0);
                    term.TermName = data.GetValue(data.GetOrdinal("TermName")).ToString();
                    term.TermCode = data.GetValue(data.GetOrdinal("TermCode")).ToString();
                    terms.Add(term);
                }
                data.Close();
                return terms;
            }
            catch(Exception ex)
            {
                return [];
            }
        }
    }
}
