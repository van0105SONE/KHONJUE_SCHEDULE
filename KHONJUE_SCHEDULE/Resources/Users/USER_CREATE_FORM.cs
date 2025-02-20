using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Setting;
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

namespace KHONJUE_SCHEDULE.Resource.Users
{
    public partial class USER_CREATE_FORM : Form
    {
        private DatabaseContext _dbContext { get; set; }
        private UserController _userController { get; set; }
        private RoleController _roleController { get; set; }
        public USER_CREATE_FORM()
        {
            InitializeComponent();
             _dbContext = new DatabaseContext();
            _dbContext.connect();
            _userController = new UserController(_dbContext);
            _roleController = new RoleController(_dbContext);
            loadUserRoles();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApplicationUser userData = new ApplicationUser();
            userData.Username = txtUserName.Text;
            userData.Email = txtEmail.Text;
            userData.Phone = txtPhone.Text;
            userData.Fname = txtFirstname.Text;
            userData.Lname = txtLastname.Text;
            userData.Birthdate = txtBirthdate.Value;
            userData.RoleId = cmbRole.SelectedValue.ToString();
            userData.Position = txtPosition.Text;
            userData.Gender = cmbGender.Text;
            userData.RoleName = cmbRole.Text;
            _userController.CreateUser(userData);
        }

        public void loadUserRoles()
        {
          List<ApplicationRole> roles =     _roleController.GetApplicationRoles();

            // Set the DisplayMember and ValueMember properties
            cmbRole.DisplayMember = "RoleName"; // Replace with the property you want to display
            cmbRole.ValueMember = "RoleId";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbRole.DataSource = roles;
        }

    }
}
