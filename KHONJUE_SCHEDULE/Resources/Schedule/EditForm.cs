using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Management.Model;
using KHONJUE_SCHEDULE.Resources.Schedule.controller;
using KHONJUE_SCHEDULE.Resources.Schedule.Model;
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

namespace KHONJUE_SCHEDULE.Resources.Schedule
{
    public partial class EditForm : Form
    {
        private Actions action { get; set; }
        private DatabaseContext _dbContext { get; set; }
        private ScheduleController _scheduleController { get; set; }
        private SubjectController _subjectController { get; set; }
        private TermController _termController { get; set; }
        private LevelController _levelController { get; set; }
        private MajorController _majorController { get; set; }
        private TeacherAndSubjectController _teacherController { get; set; }
        private TimePeriodController _periodController { get; set; }
        private ClassMajorController _classMajorController { get; set; }
        private CurriculumController _curriculumController { get; set; }
        private StudentClassController _studentClassController { get; set; }
        public ScheduleModel schedule { get; set; }
        public EditForm()
        {
            InitializeComponent();
            schedule = new ScheduleModel();
        }

        public EditForm(ScheduleModel schedulParams)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _scheduleController = new ScheduleController(_dbContext);
            _subjectController = new SubjectController(_dbContext);
            _termController = new TermController(_dbContext);
            _levelController = new LevelController(_dbContext);
            _majorController = new MajorController(_dbContext);
            _curriculumController = new CurriculumController(_dbContext);
            _teacherController = new TeacherAndSubjectController(_dbContext);
            _periodController = new TimePeriodController(_dbContext);
            _classMajorController = new ClassMajorController(_dbContext);
            _studentClassController = new StudentClassController(_dbContext);

            cmbDays.DataSource = new List<string>() {
            "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
            loadMajors();
            loadLevel();
            loadSubject();
            loadTerm();
            loadTeachers(schedulParams.subjectId);
            loadPeriods();
            loadClassMajors();
            loadRooms();

            cmbDays.SelectedItem = schedulParams.Day;
            cmbClass.SelectedValue = schedulParams.ClassMajorId;
            cmbLevel.SelectedValue = schedulParams.levelId;
            cmbMajor.SelectedValue = schedulParams.majorId;
            cmbTerm.SelectedValue = schedulParams.termId;
            cmbSubject.SelectedValue = schedulParams.subjectId;
            cmbPeriods.SelectedValue = schedulParams.periodId;
            cmbTeacher.SelectedValue = schedulParams.TeacherId;
            cmbTerm.SelectedValue = schedulParams.termId;
            cmbTeacher.SelectedValue = schedulParams.TeacherId;
            cmbRooms.SelectedValue = schedulParams.RoomId;
            action = Actions.Update;
            schedule = schedulParams;


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
        private void loadTerm()
        {
            List<TermModel> roles = _termController.getTerms("");

            // Set the DisplayMember and ValueMember properties
            cmbTerm.DisplayMember = "TermName"; // Replace with the property you want to display
            cmbTerm.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbTerm.DataSource = roles;
        }
        private void loadLevel()
        {
            List<LevelModel> roles = _levelController.getLevels("");

            // Set the DisplayMember and ValueMember properties
            cmbLevel.DisplayMember = "LevelName"; // Replace with the property you want to display
            cmbLevel.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbLevel.DataSource = roles;
        }



        private void createBtn_Click_2(object sender, EventArgs e)
        {


        }

        private void loadPeriods()
        {
            if (cmbTeacher.SelectedValue != null)
            {
                List<TimePeriodModel> periods = _periodController.getFreeTimePeriod(cmbDays.SelectedItem.ToString(), int.Parse(cmbTeacher.SelectedValue.ToString()));

                // Set the DisplayMember and ValueMember properties
                cmbPeriods.DisplayMember = "StartTime"; // Replace with the property you want to display
                cmbPeriods.ValueMember = "Id";    // Replace with the property you want as the value

                // Bind the roles list to the ComboBox
                cmbPeriods.DataSource = periods;
            }

        }


        private void loadMajors()
        {
            List<MajorModel> roles = _majorController.getMajors("");

            // Set the DisplayMember and ValueMember properties
            cmbMajor.DisplayMember = "MajorName"; // Replace with the property you want to display
            cmbMajor.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbMajor.DataSource = roles;
        }

        private void loadTeachers(int subjectId)
        {
            List<TeacherSubject> teachers = _teacherController.GetTeacherSubjectListBySubjectId(subjectId);

            // Set the DisplayMember and ValueMember properties
            cmbTeacher.DisplayMember = "TeacherName"; // Replace with the property you want to display
            cmbTeacher.ValueMember = "TeacherId";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbTeacher.DataSource = teachers;
        }

        private void loadClassMajors()
        {
            List<ClassMajor> classMajors = _classMajorController.GetStudentClasstList("");

            // Set the DisplayMember and ValueMember properties
            cmbClass.DisplayMember = "ClassName"; // Replace with the property you want to display
            cmbClass.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbClass.DataSource = classMajors;
        }


        private void loadRooms()
        {
            if (cmbPeriods.SelectedValue != null)
            {
                List<StudentClassModel> rooms = _studentClassController.GetAvailableRooms(cmbDays.SelectedItem.ToString(), int.Parse(cmbPeriods.SelectedValue.ToString()));

                // Set the DisplayMember and ValueMember properties
                cmbRooms.DisplayMember = "StudentClassName"; // Replace with the property you want to display
                cmbRooms.ValueMember = "Id";    // Replace with the property you want as the value

                // Bind the roles list to the ComboBox
                cmbRooms.DataSource = rooms;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            schedule.Day = cmbDays.SelectedItem.ToString();
            schedule.TeacherId = int.Parse(cmbTeacher.SelectedValue.ToString());
            schedule.periodId = int.Parse(cmbPeriods.SelectedValue.ToString());
            schedule.RoomId = int.Parse(cmbRooms.SelectedValue.ToString());
            _scheduleController.EditSchedule(schedule.Id, schedule);


            this.Close();
        }

        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPeriods_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadRooms();
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPeriods();
        }
    }
}
