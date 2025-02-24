using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using KHONJUE_SCHEDULE.Utils.enums;
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
    public partial class CREATE_TIME_PERIOD : Form
    {
        private Actions action { get; set; }
        private TimePeriodController _timeController { get; set; }
        private TimePeriodModel timePeriod { get; set; }
        public CREATE_TIME_PERIOD()
        {
            DatabaseContext context = new DatabaseContext();
            context.connect();
            _timeController = new TimePeriodController(context);
            InitializeComponent();
            startTimePicker.Format = DateTimePickerFormat.Time;
            endTimePicker.Format = DateTimePickerFormat.Time;
            action = Actions.Create;
            timePeriod = new TimePeriodModel();
        }

        public CREATE_TIME_PERIOD(TimePeriodModel timeParams)
        {
            DatabaseContext context = new DatabaseContext();
            context.connect();
            _timeController = new TimePeriodController(context);
            InitializeComponent();
            startTimePicker.Format = DateTimePickerFormat.Time;
            endTimePicker.Format = DateTimePickerFormat.Time;
            action = Actions.Update;
            timePeriod = timeParams;
            startTimePicker.Value = DateTime.ParseExact(timeParams.startTime, "hh:mm tt", null);
            endTimePicker.Value = DateTime.ParseExact(timeParams.endTime, "hh:mm tt", null);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
 
                timePeriod.startTime = startTimePicker.Value.ToString("hh:mm tt");
                timePeriod.endTime = endTimePicker.Value.ToString("hh:mm tt");
                bool isSuccess = false;
                if (action == Actions.Create)
                {
                    isSuccess = _timeController.createTimePeriod(timePeriod);
                }
                else
                {
                    isSuccess = _timeController.updateTimePeriod(timePeriod);
                }

                if(isSuccess)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
