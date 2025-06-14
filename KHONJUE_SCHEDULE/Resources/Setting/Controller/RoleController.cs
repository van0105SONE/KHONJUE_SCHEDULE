using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Setting.model;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KHONJUE_SCHEDULE.Resources.Setting.Controller
{
    public class RoleController
    {
        private DatabaseContext _dbContext { get; set; }
        private NpgsqlCommand _command { get; set; }
        public RoleController(DatabaseContext _context) {
            _dbContext = _context;


        }


        public bool allowdRoles(string roleNameParam, ApplicationModule moduleParam)
        {
            try
            {
                ApplicationModule module = new ApplicationModule();
                _command = new NpgsqlCommand();
                _command.Connection = _dbContext.dbConnection;
                _command.CommandText = $@"SELECT * FROM ApplicationModule WHERE ModuleName='${moduleParam.ModuleName}'";
                var dbReader =  _command.ExecuteReader();

                while (dbReader.Read())
                {
                    module.ModuleName = dbReader.GetValue(dbReader.GetOrdinal("modulename")).ToString();
                    module.AllowRoles = dbReader.GetValue(dbReader.GetOrdinal("allowmodules")).ToString();
                };
                dbReader.Close();
                if (!moduleParam.AllowRoles.ToLower().Contains(roleNameParam.ToLower())) {
                    moduleParam.AllowRoles += $@"{roleNameParam},";
                    _command.CommandText = @"
    UPDATE ApplicationModule 
    SET AllowRoles = @AllowRoles 
    WHERE ModuleName = @ModuleName;";

                    _command.Parameters.AddWithValue("@AllowRoles", NpgsqlDbType.Text, moduleParam.AllowRoles);
                    _command.Parameters.AddWithValue("@ModuleName", NpgsqlDbType.Text, moduleParam.ModuleName);

                    int result = _command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("Update successful.");
                    }
                    else
                    {
                        Console.WriteLine("No rows were updated. Verify ModuleName and data.");
                    }
                }

                
                return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public List<ApplicationModule> GetApplicationModules()
        {
            List<ApplicationModule> modules = new List<ApplicationModule>();
            _command = new NpgsqlCommand();
            _command.Connection = _dbContext.dbConnection;
            _command.CommandText = "SELECT * FROM ApplicationModule;";
            NpgsqlDataReader data = _command.ExecuteReader();
            while (data.Read())
            {
                ApplicationModule role = new ApplicationModule();
                role.Id = data.GetValue(data.GetOrdinal("id")).ToString();
                role.ModuleName = data.GetValue(data.GetOrdinal("modulename")).ToString();
                role.AllowRoles = data.GetValue(data.GetOrdinal("allowroles")).ToString();
                modules.Add(role);
            }
            data.Close();

            return modules;
        }

        public bool createApplicationModule()
        {
            try
            {
                List<string> MODULES = new List<string>()
                {
                    RoleControl1.MODULE_NAME,
                    UserControl1.MODULE_NAME
                };
                _command = new NpgsqlCommand();
                _command.Connection = _dbContext.dbConnection;
                foreach (string name in  MODULES)
                {
                    _command.CommandText = $@"SELECT * FROM ApplicationModule WHERE ModuleName='${name}'";
                    var isExist = _command.ExecuteScalar();
                
                    if (isExist == null)
                    {
                        _command.CommandText = $@"INSERT INTO ApplicationModule(Id, ModuleName, AllowRoles) VALUES('{Guid.NewGuid()}', '${name}', '');";
                        _command.ExecuteNonQuery();
                    }
                }

                return false;
            }catch (Exception ex)
            {
                throw ex; 
            }
        }
        
        public bool createRole(ApplicationRole param)
        {
            try
            {
                _command = new NpgsqlCommand();
                _command.Connection = _dbContext.dbConnection;
                _command.CommandText = $@"
INSERT INTO roles (""RoleName"")
VALUES 
    ('{param.RoleName}');
";
                _command.ExecuteNonQuery();
               
                return false;
            }catch (Exception ex){
                throw ex;
            }
        }


       public List<ApplicationRole> GetApplicationRoles()
        {
            try
            {
                _command = new NpgsqlCommand();
                List<ApplicationRole> roles = new List<ApplicationRole>();
                _command.Connection = _dbContext.dbConnection;
                _command.CommandText = "SELECT * FROM Roles;";
                 NpgsqlDataReader data =   _command.ExecuteReader();
                 while(data.Read())
                {
                    ApplicationRole role = new ApplicationRole();
                    role.RoleId = data.GetValue(data.GetOrdinal("roleid")).ToString();
                    role.RoleName = data.GetValue(data.GetOrdinal("rolename")).ToString();
                    roles.Add(role);
                 }
                data.Close();
                return roles;
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
