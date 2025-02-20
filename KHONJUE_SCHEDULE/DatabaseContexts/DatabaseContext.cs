using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.DatabaseContexts
{
    public class DatabaseContext
    {
        private String connectionString = "User ID=postgres;Password=123456789;Host=localhost;Port=5432;Database=KHONGJUE;";
       public NpgsqlConnection dbConnection { get; set; }
        public DatabaseContext() { 
        }

        public NpgsqlConnection connect()
        {

            try
            {
                dbConnection = new NpgsqlConnection(connectionString);
                if (dbConnection.State == ConnectionState.Open)
                {
                    return dbConnection;
                }
                dbConnection.Open();

                return dbConnection;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        

        public NpgsqlConnection closeConnection()
        {
            try
            {
                if (dbConnection.State == ConnectionState.Open)
                {
                    return dbConnection;
                }
                dbConnection.Close();

                return dbConnection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
