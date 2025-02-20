using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Setting.model;
using KHONJUE_SCHEDULE.Resources.Users.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Users.Controller
{
    public class UserController
    {
        private DatabaseContext _databaseContext;
        private NpgsqlCommand _command;
        
        public UserController(DatabaseContext dbContext ) { 
            _databaseContext = dbContext;
        }

         public   bool CreateUser(ApplicationUser param)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = $@"INSERT INTO Users (Username, Fname, Lname, Phone, Email, RoleId, RoleName, Birthdate, Position, Gender) VALUES ('{param.Username}', '{param.Fname}', '{param.Lname}', '{param.Phone}', '{param.Email}', '{param.RoleId}', '{param.RoleName}', '{param.Birthdate}', '{param.Position}', '{param.Gender}')";
                _command.ExecuteNonQuery();
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }


        public List<ApplicationUser> GetUsers()
        {
            try
            {
                List<ApplicationUser> users = new List<ApplicationUser>();
                _command = new NpgsqlCommand();
                _command.Connection = _databaseContext.dbConnection;
                _command.CommandText = "SELECT * FROM Users;";
                NpgsqlDataReader data = _command.ExecuteReader();
                while (data.Read())
                {
                    ApplicationUser user = new ApplicationUser();
                    user.Id = int.Parse( data.GetValue(data.GetOrdinal("id")).ToString(), 0);
                    user.Username = data.GetValue(data.GetOrdinal("Username")).ToString();
                    user.Fname = data.GetValue(data.GetOrdinal("Fname")).ToString();
                    user.Lname = data.GetValue(data.GetOrdinal("Lname")).ToString();
                    user.Phone = data.GetValue(data.GetOrdinal("Phone")).ToString();
                    user.Email = data.GetValue(data.GetOrdinal("Email")).ToString();
                    user.RoleId = data.GetValue(data.GetOrdinal("RoleId")).ToString();
                    user.RoleName = data.GetValue(data.GetOrdinal("RoleName")).ToString();
                    user.Birthdate =  DateTime.Parse(data.GetValue(data.GetOrdinal("Birthdate")).ToString());
                    user.Gender = data.GetValue(data.GetOrdinal("Gender")).ToString();
                    user.Position = data.GetValue(data.GetOrdinal("Position")).ToString();
                    users.Add(user);
                }
                data.Close();
                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
