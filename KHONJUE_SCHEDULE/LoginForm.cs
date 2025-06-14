using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Users.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHONJUE_SCHEDULE
{
    public partial class LoginForm : Form
    {
        private DatabaseContext dbContext = new DatabaseContext();
        private UserController _userController { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            dbContext.connect();
            _userController = new UserController(dbContext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           bool isVerify = _userController.VerifyUser(txtUsername.Text, txtPassword.Text);
            if (isVerify)
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
            }
        }
    }
}
