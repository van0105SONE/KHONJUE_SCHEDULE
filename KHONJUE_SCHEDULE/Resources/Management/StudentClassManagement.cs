using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Management.Model;
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
    public partial class StudentClassManagement : UserControl
    {
        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
        private StudentClassController _studentClassController { get; set; }
        public StudentClassManagement()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _studentClassController = new StudentClassController(_dbContext);
            _studentClassController = new StudentClassController(_dbContext);

            Style.styleDatagridView(studentClassDatagrid);
            loadStudentClassData(true);
        }


        private void loadStudentClassData(bool isInit)
        {

            studentClassDatagrid.Refresh();
            studentClassDatagrid.Invalidate();
            if (!isInit)
            {
                studentClassDatagrid.Columns.Remove("EditButton");
                studentClassDatagrid.Columns.Remove("DeleteButton");
            }

            studentClassDatagrid.DataSource = _studentClassController.GetStudentClasstList();
            studentClassDatagrid.Columns["Id"].HeaderText = "ລຳດັບ";
            studentClassDatagrid.Columns["Code"].HeaderText = "ລະຫັດຫ້ອງນັກຮຽນ";
            studentClassDatagrid.Columns["NumberOfClass"].HeaderText = "ຈຳນວນຫ້ອງ";
            studentClassDatagrid.Columns["StudentClassName"].HeaderText = "ຊື່ຫ້ອງນັກຮຽນ";
            studentClassDatagrid.Columns["Description"].HeaderText = "ຄຳອະທິບາຍ";
            studentClassDatagrid.Columns["RoomType"].HeaderText = "ປະເພດຫ້ອງ";

            // Add two button columns to the DataGridView (you can add them as separate columns)
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "";  // Set header text for the button column
            editButtonColumn.Name = "EditButton";  // Set a name for the button column
            editButtonColumn.Text = "Edit";  // Set the text to be displayed on the button
            editButtonColumn.UseColumnTextForButtonValue = true;  // Use button text
            studentClassDatagrid.Columns.Add(editButtonColumn);

            // Add another button column for a second button (e.g., "Delete")
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "";  // Set header text for the button column
            deleteButtonColumn.Name = "DeleteButton";  // Set a name for the button column
            deleteButtonColumn.Text = "Delete";  // Set the text to be displayed on the button
            deleteButtonColumn.UseColumnTextForButtonValue = true;  // Use button text
            studentClassDatagrid.Columns.Add(deleteButtonColumn);


        }

        private void studentClassDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row (not header) is clicked
            {
                var row = studentClassDatagrid.Rows[e.RowIndex];
                var code = row.Cells["Code"].Value.ToString(); // Get subject code
                var studentClassName = row.Cells["StudentClassName"].Value.ToString(); // Get subject code
                var description = row.Cells["Description"].Value.ToString(); // Get subject code
                var NumberOfClass = int.Parse(row.Cells["NumberOfClass"].Value.ToString()); // Get subject code
                var levelId = int.Parse(row.Cells["LevelId"].Value.ToString()); // Get subject code
                var levelCode = row.Cells["LevelCode"].Value.ToString(); // Get subject code
                var levelName = row.Cells["LevelName"].Value.ToString(); // Get subject code
                var Id = int.Parse(row.Cells["Id"].Value.ToString()); // Get subject code
                if (e.ColumnIndex == studentClassDatagrid.Columns["EditButton"].Index)
                {
                    // Edit button clicked

                    var studentClass = new StudentClassModel()
                    {
                        Id = Id,
                        Code = code,
                        StudentClassName = studentClassName,
                        Description = description,
                        NumberOfClass = NumberOfClass,
                    };
                    CREATE_STUDENT_CLASS createForm = new CREATE_STUDENT_CLASS(studentClass);



                    var result = createForm.ShowDialog();


                    if (result == DialogResult.OK)
                    {
                        loadStudentClassData(false);
                    }

                }
                else if (e.ColumnIndex == studentClassDatagrid.Columns["DeleteButton"].Index)
                {
                    // Delete button clicked
                    DialogResult confirm = MessageBox.Show($"Are you sure you want to delete this {levelName}?",
                     "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        _studentClassController.deleteStudent(Id);
                        loadStudentClassData(false);
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CREATE_STUDENT_CLASS createDialog = new CREATE_STUDENT_CLASS();
            var result = createDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                loadStudentClassData(false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ທ່ານໝັ້ນໃຈແລ້ວບໍ ຈະລືບຂໍ້ມູນທັງໝົດ. ກົດຍືນຍັນເພືອ່ລຶບ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            _studentClassController.deleteAll();
            loadStudentClassData(false);
        }
    }
}
