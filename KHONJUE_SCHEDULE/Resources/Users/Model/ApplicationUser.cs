using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace KHONJUE_SCHEDULE.Resources.Users.Model
{
    public class ApplicationUser
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string  Gender { get; set; }
        public string Position { get; set; }
        
        public string RoleId { get; set; }
        public string RoleName { get; set; }

        public DateTime Birthdate { get; set; }

    }
}
