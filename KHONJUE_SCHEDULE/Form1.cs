using KHONJUE_SCHEDULE.Resources.Management;
using KHONJUE_SCHEDULE.Resources.Setting;

namespace KHONJUE_SCHEDULE
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MAIN_CONTAINER.Controls.Clear();
            UserControl1 useContainer = new UserControl1();
            useContainer.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(useContainer);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            MAIN_CONTAINER.Controls.Clear();
            RoleControl1 settingPage = new RoleControl1();
            settingPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(settingPage);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MAIN_CONTAINER.Controls.Clear();
            InfoManagement inforPage = new InfoManagement();
            inforPage.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Controls.Add(inforPage);
        }
    }
}
