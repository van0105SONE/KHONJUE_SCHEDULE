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
    public partial class CREATE_CLASS : Form
    {

        private Actions action { get; set; }
        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
        private MajorController _majorController { get; set; }
        private ClassMajorController _classMajorController { get; set; }

        private ClassMajor _classMajor { get; set; }

        public CREATE_CLASS()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _majorController = new MajorController(_dbContext);
            _classMajorController = new ClassMajorController(_dbContext);
            _classMajor = new ClassMajor();
            action = Actions.Create;
            loadLevel();
            loadMajors();
        }

        public CREATE_CLASS(ClassMajor classMojor)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _majorController = new MajorController(_dbContext);
            _classMajorController = new ClassMajorController(_dbContext);
            loadLevel();
            loadMajors();
            cmbMajor.SelectedValue = classMojor.MajorId;
            cmbLevel.SelectedValue = classMojor.LevelId;
            txtLevelName.Text = classMojor.MajorName;
            _classMajor = classMojor;
            action = Actions.Update;

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            _classMajor = new ClassMajor()
            {
                Id = _classMajor.Id,
                LevelId = int.Parse(cmbLevel.SelectedValue.ToString()),
                MajorId = int.Parse(cmbMajor.SelectedValue.ToString()),
                ClassName = txtLevelName.Text.Trim()
            };

            if (action == Actions.Create)
            {
                _classMajorController.createStudentClass(_classMajor);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                _classMajorController.editStudentClass(_classMajor);
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void loadLevel()
        {
            List<LevelModel> roles = _levelController.getLevels("");

            // Set the DisplayMember and ValueMember properties
            cmbLevel.DisplayMember = "LevelName"; // Replace with the property you want to display
            cmbLevel.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbLevel.DataSource = roles;
        }


        private void createBtn_Click_2(object sender, EventArgs e)
        {


        }

        private void loadMajors()
        {
            List<MajorModel> roles = _majorController.getMajors("");

            // Set the DisplayMember and ValueMember properties
            cmbMajor.DisplayMember = "MajorName"; // Replace with the property you want to display
            cmbMajor.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbMajor.DataSource = roles;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
