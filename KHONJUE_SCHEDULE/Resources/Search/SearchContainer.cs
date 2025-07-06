using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KHONJUE_SCHEDULE.Resources.Schedule.controller;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Utils.styles;
using KHONJUE_SCHEDULE.Resources.Management.Controller;

namespace KHONJUE_SCHEDULE.Resources.Search
{
    public partial class SearchContainer : UserControl
    {
        List<String> searchTypes = new List<String>() { "ຊື່ວິຊາ","ຊື່ອາຈານ", "ມື້" };
        private ScheduleController _scheduleController { get; set; }
        private MajorController _majorController { get; set; }
        private LevelController _levelController { get; set; }
        private TermController _termController { get; set; }
        public SearchContainer()
        {
            InitializeComponent();
            DatabaseContext context = new DatabaseContext();
            context.connect();
            _scheduleController = new ScheduleController(context);
            _levelController = new LevelController(context);
            _majorController = new MajorController(context);
            _termController = new TermController(context);
            Style.styleDatagridView(dataGridView1);
            loadDataFilter();
        }

        private void loadData()
        {
            dataGridView1.DataSource = _scheduleController.getScheduleAll(int.Parse(cmbYear.SelectedValue.ToString()),int.Parse(cmbTerm.SelectedValue.ToString()), int.Parse(cmbMajor2.SelectedValue.ToString()), -1 ,txtSearch.Text.Trim(), cmbTypeName.SelectedItem.ToString());
            dataGridView1.Columns["Id"].HeaderText = "ລຳດັບ";
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["TeacherId"].Visible = false;
            dataGridView1.Columns["TermSubjectId"].Visible = false;
            dataGridView1.Columns["periodId"].Visible = false;
            dataGridView1.Columns["RoomId"].Visible = false;
            dataGridView1.Columns["Day"].HeaderText = "ມື້";
            dataGridView1.Columns["TeacherName"].HeaderText = "ຊື່ອາຈານ";
            dataGridView1.Columns["subjectName"].HeaderText = "ວິຊາ";
            dataGridView1.Columns["majorName"].HeaderText = "ສາຂາ";
            dataGridView1.Columns["period"].HeaderText = "ໂມງເຂົ້າ - ໂມງອອກ";
            dataGridView1.Columns["RoomName"].HeaderText = "ຫ້ອງ";
        }
        
        private void loadDataFilter()
        {
            cmbMajor2.DataSource = _majorController.getMajors("");
            cmbMajor2.DisplayMember = "MajorName"; // Replace with the property you want to display
            cmbMajor2.ValueMember = "Id";    // Replace with the property you want as the value

            cmbTerm.DataSource = _termController.getTerms("");
            cmbTerm.DisplayMember = "TermName"; // Replace with the property you want to display+
            cmbTerm.ValueMember = "Id";

            cmbYear.DataSource = _levelController.getLevels("");
            cmbYear.ValueMember = "Id";
            cmbYear.DisplayMember = "LevelName";

            cmbTypeName.DataSource = searchTypes;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
