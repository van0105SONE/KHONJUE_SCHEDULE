using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using KHONJUE_SCHEDULE.Resources.Users.Controller;
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
    public partial class LevelManagement : UserControl
    {
        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
        public LevelManagement()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);

            loadLevelData(true);
            Style.styleDatagridView(levelDatagrid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CREATE_LEVEL_FORM createForm = new CREATE_LEVEL_FORM();
           var result =  createForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                loadLevelData(false);
            }

        }

        private void loadLevelData(bool isInit)
        {

            levelDatagrid.Refresh();
            levelDatagrid.Invalidate();
            if (!isInit)
            {
                levelDatagrid.Columns.Remove("EditButton");
                levelDatagrid.Columns.Remove("DeleteButton");
            }

            levelDatagrid.DataSource = _levelController.getLevels();
            levelDatagrid.Columns["Id"].HeaderText = "ລຳດັບ";
            levelDatagrid.Columns["Id"].Visible = false;
            levelDatagrid.Columns["LevelCode"].HeaderText = "ລະຫັດຊັ້ນຮຽນ";
            levelDatagrid.Columns["LevelName"].HeaderText = "ຊຶ້ຊັ້ນຮຽນ";

            // Add two button columns to the DataGridView (you can add them as separate columns)
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "";  // Set header text for the button column
            editButtonColumn.Name = "EditButton";  // Set a name for the button column
            editButtonColumn.Text = "Edit";  // Set the text to be displayed on the button
            editButtonColumn.UseColumnTextForButtonValue = true;  // Use button text
            levelDatagrid.Columns.Add(editButtonColumn);

            // Add another button column for a second button (e.g., "Delete")
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "";  // Set header text for the button column
            deleteButtonColumn.Name = "DeleteButton";  // Set a name for the button column
            deleteButtonColumn.Text = "Delete";  // Set the text to be displayed on the button
            deleteButtonColumn.UseColumnTextForButtonValue = true;  // Use button text
            levelDatagrid.Columns.Add(deleteButtonColumn);


        }

        private void levelDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row (not header) is clicked
            {
                var row = levelDatagrid.Rows[e.RowIndex];
                var levelCode = row.Cells["LevelCode"].Value.ToString(); // Get subject code
                var levelName = row.Cells["LevelName"].Value.ToString(); // Get subject code
                var Id = int.Parse(row.Cells["Id"].Value.ToString()); // Get subject code
                if (e.ColumnIndex == levelDatagrid.Columns["EditButton"].Index)
                {
                    // Edit button clicked

                    var subjectArg = new LevelModel()
                    {
                        Id = Id,
                        LevelCode    = levelCode,
                        LevelName  = levelName
                    };
                    CREATE_LEVEL_FORM createForm = new CREATE_LEVEL_FORM(subjectArg);



                    var result = createForm.ShowDialog();


                    if (result == DialogResult.OK)
                    {
                        loadLevelData(false);
                    }

                }
                else if (e.ColumnIndex == levelDatagrid.Columns["DeleteButton"].Index)
                {
                    // Delete button clicked
                    DialogResult confirm = MessageBox.Show($"Are you sure you want to delete this {levelName}?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        // Call your delete function here
                        _levelController.deleteLevel(Id);
                        loadLevelData(false);
                    }
                }
            }
        }
    }
}
