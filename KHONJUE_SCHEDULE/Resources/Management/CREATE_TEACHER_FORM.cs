using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using KHONJUE_SCHEDULE.Resources.Setting.Controller;
using KHONJUE_SCHEDULE.Resources.Setting.model;
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
    public partial class CREATE_TEACHER_FORM : Form
    {
        private DatabaseContext _dbContext { get; set; }
        private TeacherController _teacherController { get; set; }
        private SubjectController _subjectController { get; set; }
        private TeacherModel teacher { get; set; }
        private Actions action { get; set; }

        public CREATE_TEACHER_FORM()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _teacherController = new TeacherController(_dbContext);
            _subjectController = new SubjectController(_dbContext);
            teacher = new TeacherModel()
            {

            };
            titleLabel.Text = "ເພິ່ມຂໍ້ມູນ";
            createBtn.Text = "ບັນທຶກ";
            action = Actions.Create;

        }

        public CREATE_TEACHER_FORM(TeacherModel teacherParam)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _teacherController = new TeacherController(_dbContext);
            _subjectController = new SubjectController(_dbContext);
            teacher = new TeacherModel()
            {
                Id = teacherParam.Id,
                TeacherName = teacherParam.TeacherName,
                Description = teacherParam.Description,
                QuotaPerWeek = teacherParam.QuotaPerWeek
            };

            txtName.Text = teacherParam.TeacherName;
            txtQuotaPerWeek.Text = teacherParam.QuotaPerWeek.ToString();
            textPhone.Text = teacherParam.Description;
            titleLabel.Text = "ແກ້ໄຂຂໍ້ມູນ";
            createBtn.Text = "ແກ້ໄຂ";
            action = Actions.Update;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuotaPerWeek.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                return;
            }

            teacher.TeacherName = txtName.Text;
            teacher.Description = txtQuotaPerWeek.Text;


            bool isSuccess = false;
            if (action == Actions.Create)
            {
                isSuccess = _teacherController.CreateTeacher(teacher);
            }
            else
            {
                //   isSuccess = _teacherController.e(subject);
            }

            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuotaPerWeek.Text) || string.IsNullOrEmpty(txtName.Text))
            {
                return;
            }

            teacher.TeacherName = txtName.Text;
            teacher.QuotaPerWeek = int.Parse(txtQuotaPerWeek.Text);
            teacher.Description = txtDescription.Text;
            teacher.Phone = textPhone.Text.Trim();
            bool isSuccess = false;
            if (action == Actions.Create)
            {
                isSuccess = _teacherController.CreateTeacher(teacher);
            }
            else
            {
                isSuccess = _teacherController.editTeacher(teacher);
            }

            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
