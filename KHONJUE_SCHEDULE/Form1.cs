using KHONJUE_SCHEDULE.Resources.Management;
using KHONJUE_SCHEDULE.Resources.Notifications;
using KHONJUE_SCHEDULE.Resources.Report;
using KHONJUE_SCHEDULE.Resources.Schedule;
using KHONJUE_SCHEDULE.Resources.Search;
using KHONJUE_SCHEDULE.Resources.Setting;
using KHONJUE_SCHEDULE.Utils.styles;

namespace KHONJUE_SCHEDULE
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            MAIN_CONTAINER.Controls.Clear();
            InfoManagement inforPage = new InfoManagement();
            inforPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(inforPage);

            Style.SetActiveButton(button6, SIDEBAR_MENU.Controls);
        }



        private void button6_Click(object sender, EventArgs e)
        {

            MAIN_CONTAINER.Controls.Clear();
            NotificationManagement useContainer = new NotificationManagement();
            useContainer.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(useContainer);

            Style.SetActiveButton(button6, SIDEBAR_MENU.Controls);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MAIN_CONTAINER.Controls.Clear();
            Schedule inforPage = new Schedule();
            inforPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(inforPage);

            Style.SetActiveButton(button2, SIDEBAR_MENU.Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MAIN_CONTAINER.Controls.Clear();
            InfoManagement inforPage = new InfoManagement();
            inforPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(inforPage);

            Style.SetActiveButton(button1, SIDEBAR_MENU.Controls);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            MAIN_CONTAINER.Controls.Clear();
            ReportManagement settingPage = new ReportManagement();
            settingPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(settingPage);

            Style.SetActiveButton(button3, SIDEBAR_MENU.Controls);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MAIN_CONTAINER.Controls.Clear();
            SearchPage settingPage = new SearchPage();
            settingPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(settingPage);
            Style.SetActiveButton(button4, SIDEBAR_MENU.Controls);
        }
    }
}
