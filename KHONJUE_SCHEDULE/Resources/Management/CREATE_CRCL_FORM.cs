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
    public partial class CREATE_CRCL_FORM : Form
    {
        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
        private CurriculumController _subjController { get; set; }
        private CurriculumModel curriculum { get; set; }
        private Actions action { get; set; }

        public CREATE_CRCL_FORM()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _subjController = new CurriculumController(_dbContext);
            curriculum = new CurriculumModel()
            {

            };
            titleLabel.Text = "ເພິ່ມຂໍ້ມູນ";
            createBtn.Text = "ບັນທຶກ";
            action = Actions.Create;
        }

        public CREATE_CRCL_FORM(CurriculumModel curriculumParam)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _subjController = new CurriculumController(_dbContext);
            curriculum = new CurriculumModel()
            {
                Id = curriculumParam.Id,
                CurriculumName = curriculumParam.CurriculumName,
                Description = curriculumParam.Description,
            };

            txtCRCL.Text = curriculumParam.CurriculumName;
            txtDescription.Text = curriculumParam.Description;
            titleLabel.Text = "ແກ້ໄຂຂໍ້ມູນ";
            createBtn.Text = "ແກ້ໄຂ";

            action = Actions.Update;
        }



        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

            curriculum.CurriculumName = txtCRCL.Text;
            curriculum.Description = txtDescription.Text;



            bool isSuccess = false;
            if (action == Actions.Create)
            {
                isSuccess = _subjController.createCurriculum(curriculum);
            }
            else
            {
                isSuccess = _subjController.updateCurriculum(curriculum);
            }

            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
