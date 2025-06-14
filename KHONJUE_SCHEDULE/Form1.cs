using KHONJUE_SCHEDULE.Resources.Management;
using KHONJUE_SCHEDULE.Resources.Notifications;
using KHONJUE_SCHEDULE.Resources.Report;
using KHONJUE_SCHEDULE.Resources.Schedule;
using KHONJUE_SCHEDULE.Resources.Setting;

namespace KHONJUE_SCHEDULE
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MAIN_CONTAINER.Controls.Clear();
            Schedule inforPage = new Schedule();
            inforPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(inforPage);
        }



        private void button6_Click(object sender, EventArgs e)
        {

            MAIN_CONTAINER.Controls.Clear();
            NotificationManagement useContainer = new NotificationManagement();
            useContainer.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(useContainer);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MAIN_CONTAINER.Controls.Clear();
            InfoManagement inforPage = new InfoManagement();
            inforPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(inforPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MAIN_CONTAINER.Controls.Clear();
            Schedule inforPage = new Schedule();
            inforPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(inforPage);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MAIN_CONTAINER.Controls.Clear();
            RoleControl1 settingPage = new RoleControl1();
            settingPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(settingPage);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MAIN_CONTAINER.Controls.Clear();
            ReportManagement settingPage = new ReportManagement();
            settingPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(settingPage);
        }
    }
}
