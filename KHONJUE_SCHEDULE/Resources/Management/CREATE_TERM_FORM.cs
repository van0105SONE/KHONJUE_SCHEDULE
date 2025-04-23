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
    public partial class CREATE_TERM_FORM : Form
    {
        private Actions action { get; set; }
        private DatabaseContext _dbContext { get; set; }
        private TermController _termController { get; set; }
        private CurriculumController _curriculumController { get; set; }
        private TermModel level { get; set; }
        public CREATE_TERM_FORM()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _termController = new TermController(_dbContext);
            _curriculumController = new CurriculumController(_dbContext);
            level = new TermModel();
            action = Actions.Create;
        }

        public CREATE_TERM_FORM(TermModel termParam)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _termController = new TermController(_dbContext);
            level = termParam;
            txtTermName.Text = termParam.TermName;
            action = Actions.Update;
        }



        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void createBtn_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            if (action == Actions.Create)
            {
                TermModel termArg = new TermModel()
                {
                    TermName = txtTermName.Text
                };
                isSuccess = _termController.CreateTerm(termArg);
            }
            else
            {
                isSuccess = _termController.editTerm(txtTermName.Text, level.Id);
            }

            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
