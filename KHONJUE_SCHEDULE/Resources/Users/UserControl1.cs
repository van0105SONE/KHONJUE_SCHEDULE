using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resource.Users;
using KHONJUE_SCHEDULE.Resources.Users.Controller;
using KHONJUE_SCHEDULE.Utils.styles;
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
    public partial class UserControl1 : UserControl
    {
        public static String MODULE_NAME = "USERPAGE";
        private DatabaseContext dbContext = new DatabaseContext();
        private UserController _userController { get; set; }
        public UserControl1()
        {
            InitializeComponent();

            dbContext.connect();
            _userController = new UserController(dbContext);
            loadUserData();
            Style.styleDatagridView(dataGridView1);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            USER_CREATE_FORM form = new USER_CREATE_FORM();
            form.ShowDialog();
        }

        public void loadUserData()
        {

            dataGridView1.DataSource = _userController.GetUsers();
            dataGridView1.Columns["Id"].HeaderText = "ລຳດັບ";
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Username"].HeaderText = "ຊື່ຜູ້ໃຊ້";
            dataGridView1.Columns["Fname"].HeaderText = "ຊື່ແທ້";
            dataGridView1.Columns["Lname"].HeaderText = "ນາມສະກຸນ";
            dataGridView1.Columns["Gender"].HeaderText = "ເພດ";
            dataGridView1.Columns["Position"].HeaderText = "ຕຳແແຫນ່ງວຽກ";
            dataGridView1.Columns["Phone"].HeaderText = "ເບິໂທ";
            dataGridView1.Columns["Email"].HeaderText = "ທີ່ຢູ່ອີເມວ";
            dataGridView1.Columns["RoleName"].HeaderText = "ຫນ້າທີ່";
            dataGridView1.Columns["Birthdate"].HeaderText = "ວັນເດຶອນປີເກີດ";
    }
    }
}
