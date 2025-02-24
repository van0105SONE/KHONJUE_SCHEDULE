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
    public partial class InfoManagement : UserControl
    {
        public InfoManagement()
        {
            InitializeComponent();
        }

        private void btnManageSubject_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            LevelManagement levelManagement = new LevelManagement();
            levelManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(levelManagement);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            SubjectManagement subjectManagement = new SubjectManagement();
            subjectManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(subjectManagement);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            StudentClassManagement studentClassManagement = new StudentClassManagement();
            studentClassManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(studentClassManagement);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            TimePeriodManagement timePerdioManagement = new TimePeriodManagement();
            timePerdioManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(timePerdioManagement);
        }
    }
}
