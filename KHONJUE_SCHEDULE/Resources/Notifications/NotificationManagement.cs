using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KHONJUE_SCHEDULE.Resources.Report;

namespace KHONJUE_SCHEDULE.Resources.Notifications
{
    public partial class NotificationManagement : UserControl
    {
        public NotificationManagement()
        {
            InitializeComponent();

            NOTI_CONTAINER.Controls.Clear();
            NotificationTrx scheduleReport = new NotificationTrx();
            scheduleReport.Dock = DockStyle.Fill;
            NOTI_CONTAINER.Controls.Add(scheduleReport);
        }

        private void btnManageSubject_Click(object sender, EventArgs e)
        {
            NOTI_CONTAINER.Controls.Clear();
            NotificationTrx scheduleReport = new NotificationTrx();
            scheduleReport.Dock = DockStyle.Fill;
            NOTI_CONTAINER.Controls.Add(scheduleReport);
        }
    }
}
