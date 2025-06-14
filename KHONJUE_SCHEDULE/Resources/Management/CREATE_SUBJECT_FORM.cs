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
    public partial class CREATE_SUBJECT_FORM : Form
    {
        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
        private CurriculumController _curriculumController { get; set; }
        private SubjectController _subjController { get; set; }
        private SubjectModel subject { get; set; }
        private Actions action { get; set; }

        public CREATE_SUBJECT_FORM()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _subjController = new SubjectController(_dbContext);
            _curriculumController = new CurriculumController(_dbContext);
            subject = new SubjectModel()
            {

            };
            titleLabel.Text = "ເພິ່ມຂໍ້ມູນ";
            createBtn.Text = "ບັນທຶກ";
            action = Actions.Create;
            loadCurriculum();
        }

        public CREATE_SUBJECT_FORM(SubjectModel subjectParam)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _subjController = new SubjectController(_dbContext);
            subject = new SubjectModel()
            {
                Id = subjectParam.Id,
                SubjectCode = subjectParam.SubjectName,
                Description = subjectParam.Description,
                CurriculumId = int.Parse(subjectParam.CurriculumId.ToString())
            };

            txtSubject.Text = subjectParam.SubjectName;
            txtDescription.Text = subjectParam.Description;
            cmbCrcl.SelectedValue = subjectParam.CurriculumId;
            titleLabel.Text = "ແກ້ໄຂຂໍ້ມູນ";
            createBtn.Text = "ແກ້ໄຂ";
            action = Actions.Update;
            loadCurriculum();
        }




        public void loadCurriculum()
        {
            var curriculums = _curriculumController.GetCurriculumList();


            // Set the DisplayMember and ValueMember properties
            cmbCrcl.DisplayMember = "CurriculumName"; // Replace with the property you want to display
            cmbCrcl.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbCrcl.DataSource = curriculums;
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
            if (string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtSubject.Text) || cmbCrcl.SelectedValue == null)
            {
                return;
            }

            subject.SubjectName = txtSubject.Text;
            subject.Description = txtDescription.Text;
            subject.CurriculumId = int.Parse(cmbCrcl.SelectedValue.ToString());

            bool isSuccess = false;
            if (action == Actions.Create)
            {
                isSuccess = _subjController.createSubject(subject);
            }
            else
            {
                isSuccess = _subjController.editSubject(subject);
            }

            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtSubject.Text) || cmbCrcl.SelectedValue == null)
            {
                return;
            }

            subject.SubjectName = txtSubject.Text;
            subject.Description = txtDescription.Text;
            subject.Lecture = int.Parse(txtLecture.Text);
            subject.Lab = int.Parse(txtLab.Text);
            subject.CurriculumId = int.Parse(cmbCrcl.SelectedValue.ToString());


            bool isSuccess = false;
            if (action == Actions.Create)
            {
                isSuccess = _subjController.createSubject(subject);
            }
            else
            {
                isSuccess = _subjController.editSubject(subject);
            }

            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtLecture_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLab_KeyPress(object sender, KeyPressEventArgs e)
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
