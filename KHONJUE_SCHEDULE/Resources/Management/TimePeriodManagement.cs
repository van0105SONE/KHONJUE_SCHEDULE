using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using KHONJUE_SCHEDULE.Utils.enums;
using KHONJUE_SCHEDULE.Utils.styles;
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
    public partial class TimePeriodManagement : UserControl
    {
        private Actions action { get; set; }
        private TimePeriodController _timeController { get; set; }
        private TimePeriodModel timePeriod { get; set; }
        public TimePeriodManagement()
        {
            DatabaseContext context = new DatabaseContext();
            context.connect();
            _timeController = new TimePeriodController(context);
            InitializeComponent();
            Style.styleDatagridView(timePeriodDatagrid);
            loadTimePeriods(true);
        }


        public void loadTimePeriods(bool isInit)
        {
            try
            {

                timePeriodDatagrid.Refresh();
                timePeriodDatagrid.Invalidate();
                if (!isInit)
                {
                    timePeriodDatagrid.Columns.Remove("EditButton");
                    timePeriodDatagrid.Columns.Remove("DeleteButton");
                }

                timePeriodDatagrid.DataSource = _timeController.getTimePeriod();
                timePeriodDatagrid.Columns["Id"].HeaderText = "ລຳດັບ";
                timePeriodDatagrid.Columns["Id"].Visible = false;
                timePeriodDatagrid.Columns["periodCode"].HeaderText = "ລະຫັດຊົ່ວໂມງຮຽນ";
                timePeriodDatagrid.Columns["startTime"].HeaderText = "ຊົ່ວໂມງເຂົ້າຮຽນ";
                timePeriodDatagrid.Columns["endTime"].HeaderText = "ຊົ່ວໂມງເລີກ";

                // Add two button columns to the DataGridView (you can add them as separate columns)
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.HeaderText = "";  // Set header text for the button column
                editButtonColumn.Name = "EditButton";  // Set a name for the button column
                editButtonColumn.Text = "Edit";  // Set the text to be displayed on the button
                editButtonColumn.UseColumnTextForButtonValue = true;  // Use button text
                timePeriodDatagrid.Columns.Add(editButtonColumn);

                // Add another button column for a second button (e.g., "Delete")
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.HeaderText = "";  // Set header text for the button column
                deleteButtonColumn.Name = "DeleteButton";  // Set a name for the button column
                deleteButtonColumn.Text = "Delete";  // Set the text to be displayed on the button
                deleteButtonColumn.UseColumnTextForButtonValue = true;  // Use button text
                timePeriodDatagrid.Columns.Add(deleteButtonColumn);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void timePeriodDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = timePeriodDatagrid.Rows[e.RowIndex];
            var id = int.Parse(row.Cells["Id"].Value.ToString()); // Get subject code
            var periodCode = row.Cells["periodCode"].Value.ToString(); // Get subject code
            var startTime = row.Cells["startTime"].Value.ToString(); // Get subject code
            var endTime = row.Cells["endTime"].Value.ToString(); // Get subject code

            if (e.ColumnIndex == timePeriodDatagrid.Columns["EditButton"].Index)
            {
                // Edit button clicked

                var timePeriodArg = new TimePeriodModel()
                {
                    Id = id,
                    periodCode = periodCode,
                    startTime = startTime,
                    endTime = endTime
                };
                CREATE_TIME_PERIOD createForm = new CREATE_TIME_PERIOD(timePeriodArg);



                var result = createForm.ShowDialog();


                if (result == DialogResult.OK)
                {
                    loadTimePeriods(false);
                }

            }
            else if (e.ColumnIndex == timePeriodDatagrid.Columns["DeleteButton"].Index)
            {
                // Delete button clicked
                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Subject Code: {periodCode}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _timeController.updateTimePeriod(id);
                    // Call your delete function here
                    loadTimePeriods(false);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CREATE_TIME_PERIOD createDialog = new CREATE_TIME_PERIOD();
            var result = createDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                loadTimePeriods(false);
            }
        }
    }
}
