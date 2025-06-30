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
    public partial class CREATE_TEACHER_SUBJECT_FORM : Form
    {
        private Actions action { get; set; }
        private DatabaseContext _dbContext { get; set; }
        private SubjectController _subjectController { get; set; }
        private TeacherController _teacherController { get; set; }
        private TeacherAndSubjectController _teacherSubjectController { get; set; }
        private TeacherSubject teacherSubject { get; set; }
        public CREATE_TEACHER_SUBJECT_FORM()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _subjectController = new SubjectController(_dbContext);
            _teacherController = new TeacherController(_dbContext);
            _teacherSubjectController = new TeacherAndSubjectController(_dbContext);
            teacherSubject = new TeacherSubject();
            action = Actions.Create;
            loadSubject();
            loadTeacher();
        }

        public CREATE_TEACHER_SUBJECT_FORM(TeacherSubject teacherSubject)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _subjectController = new SubjectController(_dbContext);
            _teacherController = new TeacherController(_dbContext);
            _teacherSubjectController = new TeacherAndSubjectController(_dbContext);
            this.teacherSubject = teacherSubject;
            cmbTerm.SelectedValue = teacherSubject.TeacherName;
            action = Actions.Update;
            loadSubject();
            loadTeacher();
        }



        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadSubject()
        {
            List<SubjectModel> roles = _subjectController.GetSubjectList("");

            // Set the DisplayMember and ValueMember properties
            cmbSubject.DisplayMember = "SubjectName"; // Replace with the property you want to display
            cmbSubject.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbSubject.DataSource = roles;
        }
        private void loadTeacher()
        {
            List<TeacherModel> roles = _teacherController.getTeachers("");

            // Set the DisplayMember and ValueMember properties
            cmbTerm.DisplayMember = "TeacherName"; // Replace with the property you want to display
            cmbTerm.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbTerm.DataSource = roles;
        }






        private void closeBtn_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            if (action == Actions.Create)
            {
                isSuccess = _teacherSubjectController.addSubjectTeacher(int.Parse(cmbSubject.SelectedValue.ToString()), int.Parse(cmbTerm.SelectedValue.ToString()));
            }else
            {
                isSuccess = _teacherSubjectController.updateSubjectTeacher(teacherSubject.Id,int.Parse(cmbSubject.SelectedValue.ToString()), int.Parse(cmbTerm.SelectedValue.ToString()));
            }



            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
