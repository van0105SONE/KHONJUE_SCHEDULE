﻿using KHONJUE_SCHEDULE.DatabaseContexts;
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
    public partial class ClassMajorManagement : UserControl
    {
        private DatabaseContext _dbContext { get; set; }
        private ClassMajorController _classMajorController { get; set; }
        public ClassMajorManagement()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _classMajorController = new ClassMajorController(_dbContext);

            loadData(true);
            Style.styleDatagridView(levelDatagrid);
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void loadData(bool isInit)
        {

            levelDatagrid.Refresh();
            levelDatagrid.Invalidate();
            if (!isInit)
            {
                levelDatagrid.Columns.Remove("EditButton");
                levelDatagrid.Columns.Remove("DeleteButton");
            }

            levelDatagrid.DataSource = _classMajorController.GetStudentClasstList("");
            levelDatagrid.Columns["Id"].HeaderText = "ລຳດັບ";
            levelDatagrid.Columns["Id"].Visible = false;
            levelDatagrid.Columns["LevelId"].Visible = false;
            levelDatagrid.Columns["MajorId"].Visible = false;
            levelDatagrid.Columns["ClassName"].HeaderText = "ຊື່ຫ້ອງໃນສາຂາ";
            levelDatagrid.Columns["MajorName"].HeaderText = "ສາຂາ";
            levelDatagrid.Columns["LevelName"].HeaderText = "ປີ";


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
                var ClassName = row.Cells["ClassName"].Value.ToString(); // Get subject code
                var Id = int.Parse(row.Cells["Id"].Value.ToString()); // Get subject codefds
                var levelId = int.Parse(row.Cells["LevelId"].Value.ToString());
                var majorId = int.Parse(row.Cells["MajorId"].Value.ToString());

                if (e.ColumnIndex == levelDatagrid.Columns["EditButton"].Index)
                {
                    // Edit button clicked

                    var termArg = new ClassMajor()
                    {
                        Id = Id,
                        MajorName = ClassName,
                        MajorId = majorId,
                        LevelId = levelId,

                    };
                    CREATE_CLASS createForm = new CREATE_CLASS(termArg);



                    var result = createForm.ShowDialog();


                    if (result == DialogResult.OK)
                    {
                        loadData(false);
                    }

                }
                else if (e.ColumnIndex == levelDatagrid.Columns["DeleteButton"].Index)
                {
                    // Delete button clicked
                    DialogResult confirm = MessageBox.Show($"Are you sure you want to delete this {ClassName}?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    _classMajorController.deleteStudent(Id);
                    if (confirm == DialogResult.Yes)
                    {
                        // Call your delete function here
                        loadData(false);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           CREATE_CLASS createForm = new CREATE_CLASS();
            var result = createForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                loadData(false);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("ທ່ານໝັ້ນໃຈແລ້ວບໍ ຈະລືບຂໍ້ມູນທັງໝົດ. ກົດຍືນຍັນເພືອ່ລຶບ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            _classMajorController.deleteAll();
            loadData(false);
        }
    }
}
