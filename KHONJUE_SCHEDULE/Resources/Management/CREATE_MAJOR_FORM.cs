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
    public partial class CREATE_MAJOR_FORM : Form
    {
        private Actions action { get; set; }
        private DatabaseContext _dbContext { get; set; }
        private MajorController _majorController { get; set; }
        private CurriculumController _curriculumController { get; set; }
        private LevelModel level { get; set; }
        public CREATE_MAJOR_FORM()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _majorController = new MajorController(_dbContext);
            _curriculumController = new CurriculumController(_dbContext);
            level = new LevelModel();
            action = Actions.Create;
            loadCurriculum();
        }

        public CREATE_MAJOR_FORM(LevelModel levelParam)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _majorController = new MajorController(_dbContext);
            level = levelParam;
            txtMajorName.Text = levelParam.LevelName;
            action = Actions.Update;
            loadCurriculum();
        }


        public void loadCurriculum()
        {
            var curriculums = _curriculumController.GetCurriculumList();


            // Set the DisplayMember and ValueMember properties
            cmbCrl.DisplayMember = "CurriculumName"; // Replace with the property you want to display
            cmbCrl.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbCrl.DataSource = curriculums;
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        private void createBtn_Click_1(object sender, EventArgs e)
        {
            bool isSuccess = false;
            if (action == Actions.Create)
            {
                MajorModel major = new MajorModel()
                {
                    MajorName = txtMajorName.Text,
                    LimitPerClass = int.Parse(txtLimitPerClass.Text),
                    CurriculumId = int.Parse(cmbCrl.SelectedValue.ToString()),
                };
                isSuccess = _majorController.CreateMajor(major);
            }
            else
            {
                MajorModel major = new MajorModel()
                {
                    MajorName = txtMajorName.Text,
                    LimitPerClass = int.Parse(txtLimitPerClass.Text),
                    CurriculumId = int.Parse(cmbCrl.SelectedValue.ToString()),
                };
                isSuccess = _majorController.editMajor(major);
            }

            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cmbCrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLimitPerClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLimitPerClass_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtLimitPerClass_KeyPress(object sender, KeyPressEventArgs e)
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
