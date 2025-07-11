﻿using KHONJUE_SCHEDULE.DatabaseContexts;
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
    public partial class TeacherSubjectManagement : UserControl
    {

        private DatabaseContext _dbContext { get; set; }
        private LevelController _levelController { get; set; }
        private TeacherAndSubjectController _teacherSubjectController { get; set; }
        public TeacherSubjectManagement()
        {
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _levelController = new LevelController(_dbContext);
            _teacherSubjectController = new TeacherAndSubjectController(_dbContext);

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
            List<TeacherSubject> subjects = _teacherSubjectController.GetTeacherSubjectList(txtSearch.Text.Trim());

            // Set data source and column headers
            subjectDatagrid.DataSource = subjects;
            subjectDatagrid.Columns["Id"].HeaderText = "ລຳດັບ";
            subjectDatagrid.Columns["Id"].Visible = false;
            subjectDatagrid.Columns["TeacherId"].Visible = false;
            subjectDatagrid.Columns["SubjectId"].Visible = false;
            subjectDatagrid.Columns["TeacherName"].HeaderText = "ຊື່ອາຈານ";
            subjectDatagrid.Columns["SubjectName"].HeaderText = "ວິຊາທີ່ອາຈານສອນ";


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
                var Id = int.Parse(row.Cells["Id"].Value.ToString()); // Get subject code
                var subjectId = int.Parse(row.Cells["SubjectId"].Value.ToString()); // Get subject code
                var teacherId = int.Parse(row.Cells["TeacherId"].Value.ToString()); // Get subject code
                if (e.ColumnIndex == subjectDatagrid.Columns["EditButton"].Index)
                {
                    TeacherSubject arg = new TeacherSubject()
                    {
                        Id = Id,
                        TeacherId = teacherId,
                        SubjectId = subjectId
                    };

                    CREATE_TEACHER_SUBJECT_FORM form = new CREATE_TEACHER_SUBJECT_FORM(arg);
                    form.ShowDialog();
                    // Edit button clicked
                    loadDataGrid(false);
                }
                else if (e.ColumnIndex == subjectDatagrid.Columns["DeleteButton"].Index)
                {
                    // Delete button clicked
                    DialogResult confirm = MessageBox.Show($"Are you sure you want to delete Subject Cod?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        // Call your delete function here
                        _teacherSubjectController.deleteSubjectTeacher(Id);
                        loadDataGrid(false);
                    }
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CREATE_TEACHER_SUBJECT_FORM createForm = new CREATE_TEACHER_SUBJECT_FORM();
            var result = createForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                loadDataGrid(false);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("ທ່ານໝັ້ນໃຈແລ້ວບໍ ຈະລືບຂໍ້ມູນທັງໝົດ. ກົດຍືນຍັນເພືອ່ລຶບ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            _teacherSubjectController.deleteAll();
            loadDataGrid(false);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadDataGrid(false);
        }
    }
}
