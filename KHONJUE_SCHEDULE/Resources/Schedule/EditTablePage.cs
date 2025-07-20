using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using KHONJUE_SCHEDULE.Resources.Schedule.controller;
using KHONJUE_SCHEDULE.Resources.Schedule.Model;
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

namespace KHONJUE_SCHEDULE.Resources.Schedule
{
    public partial class EditTablePage : Form
    {
        private Schedule schedulePage { get; set; }
        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
        private SubjectController _subjController { get; set; }
        private ScheduleController _scheduleController { get; set; }
        private TimePeriodController _timePeriodController { get; set; }
        private MajorController _majorController { get; set; }
        private TermController _termController { get; set; }
        private ClassMajorController _classMajorController { get; set; }
        public EditTablePage(int  levelId, int termId, int majorId, int classMajorId)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _termController = new TermController(_dbContext);
            _levelController = new LevelController(_dbContext);
            _subjController = new SubjectController(_dbContext);
            _scheduleController = new ScheduleController(_dbContext);
            _timePeriodController = new TimePeriodController(_dbContext);
            _majorController = new MajorController(_dbContext);
            _classMajorController = new ClassMajorController(_dbContext);
            loadData(levelId, termId, majorId, classMajorId);
            Style.styleDatagridView(dataGridView1);
        }


        private void loadData(int levelId, int termId,int majorId ,int classMajorId)
        {
            try
            {
                List<ScheduleModel> schedules = _scheduleController.getScheduleAll(levelId, termId,majorId ,classMajorId, null, null);

                dataGridView1.DataSource = schedules;
                dataGridView1.Columns["Id"].HeaderText = "ລະຫັດ";
                dataGridView1.Columns["TeacherId"].Visible = false;
                dataGridView1.Columns["TermSubjectId"].Visible = false;
                dataGridView1.Columns["periodId"].Visible = false;
                dataGridView1.Columns["RoomId"].Visible = false;
                dataGridView1.Columns["ClassMajorId"].Visible = false;
                dataGridView1.Columns["subjectId"].Visible = false;
                dataGridView1.Columns["majorId"].Visible = false;
                dataGridView1.Columns["termId"].Visible = false;
                dataGridView1.Columns["levelId"].Visible = false;
                dataGridView1.Columns["Day"].HeaderText = "ມຶ້";
                dataGridView1.Columns["ClassName"].HeaderText = "ຫ້ອງ";
                dataGridView1.Columns["MajorName"].HeaderText = "ສາຂາ";
                dataGridView1.Columns["TeacherName"].HeaderText = "ອາຈານ";
                dataGridView1.Columns["subjectName"].HeaderText = "ວິຊາ";
                dataGridView1.Columns["termName"].HeaderText = "ພາກຮຽນ";
                dataGridView1.Columns["levelName"].HeaderText = "ປີຮຽນ";
                dataGridView1.Columns["period"].HeaderText = "ຊົ່ວໂມງ";
                dataGridView1.Columns["Type"].HeaderText = "ປະເພດ";
                dataGridView1.Columns["RoomName"].HeaderText = "ຫ້ອງຮຽນ";
                // Add two button columns to the DataGridView (you can add them as separate columns)
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
                editButtonColumn.HeaderText = "";  // Set header text for the button column
                editButtonColumn.Name = "EditButton";  // Set a name for the button column
                editButtonColumn.Text = "Edit";  // Set the text to be displayed on the button
                editButtonColumn.UseColumnTextForButtonValue = true;  // Use button text
                dataGridView1.Columns.Add(editButtonColumn);

                // Add another button column for a second button (e.g., "Delete")
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.HeaderText = "";  // Set header text for the button column
                deleteButtonColumn.Name = "DeleteButton";  // Set a name for the button column
                deleteButtonColumn.Text = "Delete";  // Set the text to be displayed on the button
                deleteButtonColumn.UseColumnTextForButtonValue = true;  // Use button text
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row (not header) is clicked
            {

                var row = dataGridView1.Rows[e.RowIndex];
                var id = int.Parse(row.Cells["Id"].Value.ToString()); // Get subject code
                var day = row.Cells["Day"].Value.ToString();
                var classMajorId = int.Parse(row.Cells["ClassMajorId"].Value.ToString());
                var subjectId = int.Parse(row.Cells["subjectId"].Value.ToString());
                var levelId = int.Parse(row.Cells["levelId"].Value.ToString());
                var termId = int.Parse(row.Cells["termId"].Value.ToString());
                var teacherId = int.Parse(row.Cells["teacherId"].Value.ToString());
                var majorId = int.Parse(row.Cells["majorId"].Value.ToString());
                var periodid = int.Parse(row.Cells["periodid"].Value.ToString());
                var roomId = int.Parse(row.Cells["RoomId"].Value.ToString());

                if (e.ColumnIndex == dataGridView1.Columns["EditButton"].Index)
                {
                    // Edit button clicked
                    var scheduleParams = new ScheduleModel()
                    {
                        Id = id,
                        Day = day,
                        termId = termId,
                        subjectId = subjectId,
                        levelId = levelId,
                        majorId = majorId,
                        TeacherId = teacherId,
                        ClassMajorId = classMajorId,
                        periodId = periodid,
                        RoomId = roomId

                    };
                    EditForm createForm = new EditForm(scheduleParams);
                    var result = createForm.ShowDialog();


                    if (result == DialogResult.OK)
                    {

                    }

                }
                else if (e.ColumnIndex == dataGridView1.Columns["DeleteButton"].Index)
                {
                    // Delete button clicked
                    DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Subject Code: ?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        // Call your delete function here
                    }
                }
            }
        }
    }
}
