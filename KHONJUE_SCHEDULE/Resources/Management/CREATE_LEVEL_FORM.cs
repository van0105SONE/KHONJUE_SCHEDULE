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
    public partial class CREATE_LEVEL_FORM : Form
    {
        private Actions action { get; set; }
        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
        private LevelModel level { get; set; }
        public CREATE_LEVEL_FORM()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            level = new LevelModel();
            action = Actions.Create;
        }

        public CREATE_LEVEL_FORM(LevelModel levelParam)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            level = levelParam;
            txtLevelName.Text = levelParam.LevelName;
            action = Actions.Update;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            if (action == Actions.Create)
            {
              isSuccess =   _levelController.CreateLevel(txtLevelName.Text);
            }
            else
            {
              isSuccess =  _levelController.editLevel(txtLevelName.Text, level.Id);
            }

            if (isSuccess)
            {
              this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
