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
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KHONJUE_SCHEDULE.Resources.Management
{
    public partial class CREATE_SUBJECT_FORM : Form
    {
        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
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
            subject = new SubjectModel()
            {

            };
            titleLabel.Text = "ເພິ່ມຂໍ້ມູນ";
            createBtn.Text = "ບັນທຶກ";
            loadUserRoles();
            action = Actions.Create;
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
                LevelId = int.Parse(subjectParam.LevelId.ToString())
            };

            txtSubject.Text = subjectParam.SubjectName;
            txtDescription.Text = subjectParam.Description;
            cmbLevel.SelectedValue = subjectParam.LevelId;
            titleLabel.Text = "ແກ້ໄຂຂໍ້ມູນ";
            createBtn.Text = "ແກ້ໄຂ";
            loadUserRoles();
            action = Actions.Update;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtSubject.Text) || cmbLevel.SelectedValue == null)
            {
                return;
            }

            subject.SubjectName = txtSubject.Text;
            subject.Description = txtDescription.Text;
            subject.LevelId = int.Parse(cmbLevel.SelectedValue.ToString());


            bool isSuccess = false;
            if (action == Actions.Create)
            {
              isSuccess =  _subjController.createSubject(subject);
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

        public void loadUserRoles()
        {
            List<LevelModel> roles = _levelController.getLevels();

            // Set the DisplayMember and ValueMember properties
            cmbLevel.DisplayMember = "LevelName"; // Replace with the property you want to display
            cmbLevel.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbLevel.DataSource = roles;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
