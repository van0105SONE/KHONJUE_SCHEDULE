using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KHONJUE_SCHEDULE.Resources.Notifications.Controller;
using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Utils.styles;

namespace KHONJUE_SCHEDULE.Resources.Notifications
{
    public partial class NotificationTrx : UserControl
    {

        private NotificationController _notificationController { get; set; }
        public NotificationTrx()
        {
            InitializeComponent();
            DatabaseContext context = new DatabaseContext();
            context.connect();
            _notificationController = new NotificationController(context);
            LoadData(false);
            Style.styleDatagridView(dataGridView1);
        }

        private void toggle_opened_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void toggle_opened_CheckedChanged_1(object sender, EventArgs e)
        {
            if (toggle_opened.Checked)
            {
                toggle_opened.BackColor = Color.Blue;
                toggle_opened.ForeColor = Color.White;

                // Uncheck the other checkbox if it was checked
                if (checkBox1.Checked)
                    checkBox1.Checked = false;

                checkBox1.BackColor = Color.White;
                checkBox1.ForeColor = Color.Black;
            }
            else
            {
                toggle_opened.BackColor = Color.White;
                toggle_opened.ForeColor = Color.Black;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.Red;
                checkBox1.ForeColor = Color.White;

                // Uncheck the other checkbox if it was checked
                if (toggle_opened.Checked)
                    toggle_opened.Checked = false;

                toggle_opened.BackColor = Color.White;
                toggle_opened.ForeColor = Color.Black;
            }
            else
            {
                checkBox1.BackColor = Color.White;
                checkBox1.ForeColor = Color.Black;
            }
        }

        private void LoadData(bool isInit)
        {
            dataGridView1.Refresh();
            dataGridView1.Invalidate();

            dataGridView1.DataSource = _notificationController.GetAllMessages();
        }
    }
}
