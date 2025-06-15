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
    public partial class SubjectManagement : UserControl
    {

        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
        private SubjectController _subjController { get; set; }
        public SubjectManagement()
        {
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _subjController = new SubjectController(_dbContext);

            InitializeComponent();
            loadDataGrid(true);
            Style.styleDatagridView(subjectDatagrid);

        }

        public void loadDataGrid(bool isInit)
        {

            subjectDatagrid.Refresh();
            subjectDatagrid.Invalidate();
            if (!isInit)
            {
                subjectDatagrid.Columns.Remove("EditButton");
                subjectDatagrid.Columns.Remove("DeleteButton");
            }

            subjectDatagrid.DataSource = null;
            List<SubjectModel> subjects = _subjController.GetSubjectList();

            // Set data source and column headers
            subjectDatagrid.DataSource = subjects;
            subjectDatagrid.Columns["Id"].HeaderText = "ລຳດັບ";
            subjectDatagrid.Columns["Id"].Visible = false;
            subjectDatagrid.Columns["SubjectCode"].HeaderText = "ລະຫັດວິຊາຣຽນ";
            subjectDatagrid.Columns["SubjectName"].HeaderText = "ຊື່ວິຊາຮຽນ";
            subjectDatagrid.Columns["Description"].HeaderText = "ຄຳອະທິບາຍເພີ່ມເຕິ່ມ";
            subjectDatagrid.Columns["Lecture"].HeaderText = "ຫ້ອງລ່ວມ";
            subjectDatagrid.Columns["Lab"].HeaderText = "ຫ້ອງທົດລອງ";

            // Add two button columns to the DataGridView (you can add them as separate columns)
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "";  // Set header text for the button column
            editButtonColumn.Name = "EditButton";  // Set a name for the button column
            editButtonColumn.Text = "Edit";  // Set the text to be displayed on the button
            editButtonColumn.UseColumnTextForButtonValue = true;  // Use button text
            subjectDatagrid.Columns.Add(editButtonColumn);

            // Add another button column for a second button (e.g., "Delete")
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "";  // Set header text for the button column
            deleteButtonColumn.Name = "DeleteButton";  // Set a name for the button column
            deleteButtonColumn.Text = "Delete";  // Set the text to be displayed on the button
            deleteButtonColumn.UseColumnTextForButtonValue = true;  // Use button text
            subjectDatagrid.Columns.Add(deleteButtonColumn);



        }

        private void subjectDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row (not header) is clicked
            {
                var row = subjectDatagrid.Rows[e.RowIndex];
                var subjectCode = row.Cells["SubjectCode"].Value.ToString(); // Get subject code
                var subjectName = row.Cells["SubjectName"].Value.ToString(); // Get subject code
                var description = row.Cells["Description"].Value.ToString(); // Get subject code
                var Id = int.Parse(row.Cells["Id"].Value.ToString()); // Get subject code
                if (e.ColumnIndex == subjectDatagrid.Columns["EditButton"].Index)
                {
                    // Edit button clicked

                    var subjectArg = new SubjectModel()
                    {
                        Id = Id,
                        SubjectCode = subjectCode,
                        SubjectName = subjectName,
                        Description = description
                    };
                    CREATE_SUBJECT_FORM createForm = new CREATE_SUBJECT_FORM(subjectArg);



                    var result = createForm.ShowDialog();


                    if (result == DialogResult.OK)
                    {
                        loadDataGrid(false);
                    }

                }
                else if (e.ColumnIndex == subjectDatagrid.Columns["DeleteButton"].Index)
                {
                    // Delete button clicked
                    DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Subject Code: {subjectCode}?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        // Call your delete function here
                        _subjController.deleteSubject(Id);
                        loadDataGrid(false);
                    }
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CREATE_SUBJECT_FORM createForm = new CREATE_SUBJECT_FORM();
            var result = createForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                loadDataGrid(false);
            }
        }
    }
}
