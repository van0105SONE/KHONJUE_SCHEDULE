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
using KHONJUE_SCHEDULE.Utils.styles;

namespace KHONJUE_SCHEDULE.Resources.Report
{
    public partial class ReportManagement : UserControl
    {
        public ReportManagement()
        {
            InitializeComponent();
            REPORT_CONTAINER.Controls.Clear();
            LevelReport levelReport = new LevelReport();
            levelReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(levelReport);
            Style.SetActiveButton(btnManageSubject, panel2.Controls);
        }

        private void btnManageSubject_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnManageSubject_Click_1(object sender, EventArgs e)
        {
            REPORT_CONTAINER.Controls.Clear();
            LevelReport levelReport = new LevelReport();
            levelReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(levelReport);
            Style.SetActiveButton(btnManageSubject, panel2.Controls);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            REPORT_CONTAINER.Controls.Clear();
            TermReport teacherTeachReport = new TermReport();
            teacherTeachReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(teacherTeachReport);
            Style.SetActiveButton(button1, panel2.Controls);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            REPORT_CONTAINER.Controls.Clear();
            SubjectReport teacherTeachReport = new SubjectReport();
            teacherTeachReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(teacherTeachReport);
            Style.SetActiveButton(button2, panel2.Controls);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            REPORT_CONTAINER.Controls.Clear();
            RoomReport teacherTeachReport = new RoomReport();
            teacherTeachReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(teacherTeachReport);

            Style.SetActiveButton(button3, panel2.Controls);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            REPORT_CONTAINER.Controls.Clear();
            MajorReport teacherTeachReport = new MajorReport();
            teacherTeachReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(teacherTeachReport);
            Style.SetActiveButton(button4, panel2.Controls);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            REPORT_CONTAINER.Controls.Clear();
            ScheduleReport scheduleReport = new ScheduleReport();
            scheduleReport.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Controls.Add(scheduleReport);
            Style.SetActiveButton(button5, panel2.Controls);
        }
    }
}
