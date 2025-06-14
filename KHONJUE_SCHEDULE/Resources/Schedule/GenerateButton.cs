using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KHONJUE_SCHEDULE.Resources.Schedule.controller;
using KHONJUE_SCHEDULE.DatabaseContexts;

namespace KHONJUE_SCHEDULE.Resources.Schedule
{
    public partial class GenerateButton : UserControl
    {
        private Schedule schedulePage { get; set; }
        public bool IsDisplayTable { get; set; } = false;
        private ScheduleController scheduleController { get; set; }
        public GenerateButton(Schedule shedule)
        {
            InitializeComponent();
            schedulePage = shedule;
            DatabaseContext contexts = new DatabaseContext();
            contexts.connect();
            scheduleController = new ScheduleController(contexts);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            IsDisplayTable = true;
            scheduleController.GenerateSchedule();
            schedulePage.visibleTablePage();

        }
    }
}
