using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using KHONJUE_SCHEDULE.Utils.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHONJUE_SCHEDULE.Resources.Management
{
    public partial class CREATE_STUDENT_CLASS : Form
    {
        private Actions action { get; set; }
        private LevelController _levelController { get; set; }
        private StudentClassController _studentClassController { get; set; }
        private StudentClassModel student { get; set; }
        public CREATE_STUDENT_CLASS()
        {

            var _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _studentClassController = new StudentClassController(_dbContext);
            InitializeComponent();
            titleLabel.Text = "ເພິ່ມຂໍ້ມູນ";
            loadLevel();
            student = new StudentClassModel();
            action = Actions.Create;
        }

        public CREATE_STUDENT_CLASS(StudentClassModel studentClassParam)
        {

            var _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _studentClassController = new StudentClassController(_dbContext);
            InitializeComponent();
            titleLabel.Text = "ເພິ່ມຂໍ້ມູນ";
            loadLevel();
            student = studentClassParam;
            txtDescription.Text = student.Description;
            txtNumberOfClass.Text = student.NumberOfClass.ToString();
            txtStudentClassName.Text = student.StudentClassName;
            action = Actions.Update;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void loadLevel()
        {
            List<LevelModel> roles = _levelController.getLevels();

            // Set the DisplayMember and ValueMember properties
            cmbLevel.DisplayMember = "LevelName"; // Replace with the property you want to display
            cmbLevel.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbLevel.DataSource = roles;
        }


        private void createBtn_Click_1(object sender, EventArgs e)
        {
            student.NumberOfClass = int.Parse(txtNumberOfClass.Text);
            student.Description = txtDescription.Text;
            student.StudentClassName = txtStudentClassName.Text;
            student.LevelId = int.Parse(cmbLevel.SelectedValue.ToString());

            bool isSuccess = false;
            if (action == Actions.Create)
            {
                isSuccess = _studentClassController.createStudentClass(student);
            }
            else
            {
                isSuccess = _studentClassController.editStudentClass(student);
            }
            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtNumberOfClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9), backspace, and one decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Ensure only one decimal point is allowed
            if (e.KeyChar == '.' && ((sender as TextBox).Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
