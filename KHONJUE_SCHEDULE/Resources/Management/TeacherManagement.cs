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
    public partial class TeacherManagement : UserControl
    {

        private DatabaseContext _dbContext { get; set; }
        private TeacherController _teacherController { get; set; }
        private SubjectController _subjController { get; set; }
        public TeacherManagement()
        {
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _teacherController = new TeacherController(_dbContext);
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
            List<TeacherModel> subjects = _teacherController.getTeachers();

            // Set data source and column headers
            subjectDatagrid.DataSource = subjects;
            subjectDatagrid.Columns["Id"].HeaderText = "ລຳດັບ";
            subjectDatagrid.Columns["Id"].Visible = false;
            subjectDatagrid.Columns["TeacherCode"].HeaderText = "ລະຫັດອາຈານ";
            subjectDatagrid.Columns["TeacherName"].HeaderText = "ຊື່ອາຈານ";
            subjectDatagrid.Columns["Description"].HeaderText = "ຄຳອະທິບາຍ";
            subjectDatagrid.Columns["QuotaPerWeek"].HeaderText = "ຈຳນວນການສອນຕໍ່ອາທິດ";

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
                var id = int.Parse(row.Cells["Id"].Value.ToString()); // Get subject code
                var Code = row.Cells["TeacherCode"].Value.ToString(); // Get subject code
                var Name = row.Cells["TeacherName"].Value.ToString(); // Get subject code
                var description = row.Cells["Description"].Value.ToString(); // Get subject code
                var QuotaPerWeek = int.Parse(row.Cells["QuotaPerWeek"].Value.ToString()); // Get subject code
                if (e.ColumnIndex == subjectDatagrid.Columns["EditButton"].Index)
                {
                    // Edit button clicked

                    var teacherArg = new TeacherModel()
                    {
                        Id = id,
                        TeacherCode = Code,
                        TeacherName = Name,
                        Description = description,
                        QuotaPerWeek = QuotaPerWeek
                    };
                    CREATE_TEACHER_FORM createForm = new CREATE_TEACHER_FORM(teacherArg);



                    var result = createForm.ShowDialog();


                    if (result == DialogResult.OK)
                    {
                        loadDataGrid(false);
                    }

                }
                else if (e.ColumnIndex == subjectDatagrid.Columns["DeleteButton"].Index)
                {
                    // Delete button clicked
                    DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Subject Code: {Code}?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        // Call your delete function here
                        _teacherController.deleteTeacher(id);
                        loadDataGrid(false);
                    }
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CREATE_TEACHER_FORM createForm = new CREATE_TEACHER_FORM();
            var result = createForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                loadDataGrid(false);
            }
        }
    }
}
