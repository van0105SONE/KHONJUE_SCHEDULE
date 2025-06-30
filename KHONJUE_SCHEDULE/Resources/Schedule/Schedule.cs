using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using KHONJUE_SCHEDULE.Resources.Schedule.controller;
using KHONJUE_SCHEDULE.Resources.Schedule.Model;
using KHONJUE_SCHEDULE.Utils.enums;
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

namespace KHONJUE_SCHEDULE.Resources.Schedule
{
    public partial class Schedule : UserControl
    {

        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
        private SubjectController _subjController { get; set; }
        private ScheduleController _scheduleController { get; set; }
        private TimePeriodController _timePeriodController { get; set; }
        public Schedule()
        {
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _subjController = new SubjectController(_dbContext);
            _scheduleController = new ScheduleController(_dbContext);
            _timePeriodController = new TimePeriodController(_dbContext);
            InitializeComponent();
            if (_scheduleController.checkHasSchedule())
            {
                this.visibleTablePage();
            }
            else
            {
                this.visibleGeneratePage();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void subjectDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        public void visibleGeneratePage()
        {

            subjectDatagrid.Controls.Clear();
            GenerateButton inforPage = new GenerateButton(this);
            inforPage.Dock = DockStyle.Fill;
            this.subjectDatagrid.Controls.Add(inforPage);
        }

        public void visibleTablePage()
        {
            subjectDatagrid.Controls.Clear();
            TableSchedule inforPage = new TableSchedule(this);
            inforPage.Dock = DockStyle.Fill;
            this.subjectDatagrid.Controls.Add(inforPage);
        }
    }
}
