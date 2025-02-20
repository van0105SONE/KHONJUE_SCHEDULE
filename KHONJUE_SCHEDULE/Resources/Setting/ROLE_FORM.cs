using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Setting.Controller;
using KHONJUE_SCHEDULE.Resources.Setting.model;
using KHONJUE_SCHEDULE.Resources.Users.Controller;
using KHONJUE_SCHEDULE.Resources.Users.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHONJUE_SCHEDULE.Resource.Setting
{
    public partial class ROLE_FORM : Form
    {
        private DatabaseContext _dbContexdt { get; set; }
        private RoleController _roleController { get; set; }
        public ROLE_FORM()
        {
            InitializeComponent();
            _dbContexdt = new DatabaseContext();
            _dbContexdt.connect();
            _roleController = new RoleController(_dbContexdt);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationRole role = new ApplicationRole();
            role.RoleId = Guid.NewGuid().ToString();
            role.RoleName = txtRoleName.Text;

            this._roleController.createRole(role);
                
        }
    }
}
