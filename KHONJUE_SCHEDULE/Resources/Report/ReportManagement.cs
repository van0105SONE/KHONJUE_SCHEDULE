using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KHONJUE_SCHEDULE.Resources.Management;

namespace KHONJUE_SCHEDULE.Resources.Report
{
    public partial class ReportManagement : UserControl
    {
        public ReportManagement()
        {
            InitializeComponent();
            REPORT_CONTAINER.Controls.Clear();
            ScheduleReport scheduleReport = new ScheduleReport();
            scheduleReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(scheduleReport);
        }

        private void btnManageSubject_Click(object sender, EventArgs e)
        {
            REPORT_CONTAINER.Controls.Clear();
            ScheduleReport scheduleReport = new ScheduleReport();
            scheduleReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(scheduleReport);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            REPORT_CONTAINER.Controls.Clear();
            TeacherScheduleReport teacherTeachReport = new TeacherScheduleReport();
            teacherTeachReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(teacherTeachReport);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            REPORT_CONTAINER.Controls.Clear();
            TeacherTeachReport teacherTeachReport = new TeacherTeachReport();
            teacherTeachReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(teacherTeachReport);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            REPORT_CONTAINER.Controls.Clear();
            RoomScheduleReport teacherTeachReport = new RoomScheduleReport();
            teacherTeachReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(teacherTeachReport);
        }
    }
}
