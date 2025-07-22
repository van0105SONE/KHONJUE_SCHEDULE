using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KHONJUE_SCHEDULE.Resources.Management.Controller;
using KHONJUE_SCHEDULE.Resources.Schedule.controller;
using KHONJUE_SCHEDULE.Resources.Schedule.Model;
using KHONJUE_SCHEDULE.DatabaseContexts;
using KHONJUE_SCHEDULE.Resources.Management.Model;

namespace KHONJUE_SCHEDULE.Resources.Schedule
{
    public partial class TableSchedule : UserControl
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
        public TableSchedule()
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
            this.loadDataFilter();
            this.InitializeWeekGrid();

        }

        public TableSchedule(Schedule shedule)
        {
            InitializeComponent();
            schedulePage = shedule;
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _termController = new TermController(_dbContext);
            _levelController = new LevelController(_dbContext);
            _subjController = new SubjectController(_dbContext);
            _scheduleController = new ScheduleController(_dbContext);
            _timePeriodController = new TimePeriodController(_dbContext);
            _majorController = new MajorController(_dbContext);
            _classMajorController = new ClassMajorController(_dbContext);
            this.loadDataFilter();
            this.InitializeWeekGrid();

        }

        public void InitializeWeekGrid()
        {
            subjectDatagrid.Controls.Clear();

            List<string> days = new List<string> { "ວັນຈັນ", "ອັງຄານ", "ພູດ", "ພະຫັດ", "ສຸກ" };
            List<string> periods = _timePeriodController.getTimePeriod("").Select(item => item.startTime + " - " + item.endTime).ToList();

            int rows = periods.Count + 1; // +1 for header
            int cols = days.Count + 1;    // +1 for "Time" header column

            TableLayoutPanel weekGrid = new TableLayoutPanel
            {
                ColumnCount = cols,
                RowCount = rows,
                Dock = DockStyle.Fill,
                AutoSize = true,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            // Set column styles (first column is for period labels)
            weekGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113)); // Time period column
            for (int i = 1; i < cols; i++)
            {
                weekGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 113f / days.Count));
            }

            // Set row styles
            for (int i = 0; i < rows; i++)
            {
                weekGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 113f)); // or AutoSize if desired
            }

            // Add top-left corner cell (empty)
            weekGrid.Controls.Add(new Label
            {
                Text = "ເວລາ",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Noto Sans Lao", 10, FontStyle.Bold)
            }, 0, 0);

            // Add day headers
            for (int i = 0; i < days.Count; i++)
            {
                weekGrid.Controls.Add(new Label
                {
                    Text = days[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Noto Sans Lao", 10, FontStyle.Bold)
                }, i + 1, 0);
            }

            // Add period labels
            for (int i = 0; i < periods.Count; i++)
            {
                weekGrid.Controls.Add(new Label
                {
                    Text = periods[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Noto Sans Lao", 9, FontStyle.Regular)
                }, 0, i + 1);
            }

            if (cmbMajors.SelectedValue != null && cmbClass.SelectedValue != null && cmbTerms.SelectedValue != null && cmbLevel.SelectedValue != null)
            {
                // Load schedules and place cards
                List<ScheduleModel> schedules = _scheduleController.getScheduleAll(int.Parse(cmbLevel.SelectedValue.ToString()), int.Parse(cmbTerms.SelectedValue.ToString()), int.Parse(cmbMajors.SelectedValue.ToString()), int.Parse(cmbClass.SelectedValue.ToString()), null, null);

                foreach (var schedule in schedules)
                {
                    int col = getDayOfWeek(schedule.Day); // +1 for time label
                    int row = periods.IndexOf(schedule.period) + 1; // +1 for header row

                    if (row > 0 && col > 0) // make sure it's valid
                    {
                        Control card = CreateScheduleCard(
                            schedule.levelName,
                            schedule.termName,
                            schedule.RoomName,
                            schedule.majorName,
                            schedule.period,
                            schedule.subjectName,
                            schedule.TeacherName,
                            schedule.Type
                            );

                        weekGrid.Controls.Add(card, col, row);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid schedule: Day={schedule.Day}, Period={schedule.period}");
                    }
                }

                subjectDatagrid.Controls.Add(weekGrid);
            }
        }

        private void AddControlToDay(TableLayoutPanel grid, Control control, DayOfWeek day)
        {
            int columnIndex = (int)day;
            grid.Controls.Add(control, columnIndex, 1);
        }

        public int getDayOfWeek(string day)
        {
            switch (day)
            {
                case "Monday":
                    return 1;
                case "Tuesday":
                    return 2;
                case "Wednesday":
                    return 3;
                case "Thursday":
                    return 4;
                case "Friday":
                    return 5;
                case "Saturday":
                    return 6;
                case "Sunday":
                    return 7;
                default:
                    return 7;
            }
        }

        private Control CreateScheduleCard(string levelName, string termName, string title, string majorName, string period, string subject, string teacher, string roomType)
        {
            Panel card = new Panel
            {
                BackColor = Color.LightSteelBlue,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(8),
                Margin = new Padding(5),
                AutoSize = true
            };

            Label lblTitle = new Label
            {
                Text = "ຫ້ອງ: " + title,
                Font = new Font("Noto Sans Lao", 8, FontStyle.Bold),
                AutoSize = true
            };
            Label majorTitle = new Label
            {
                Text = "ສາຂາ: " + majorName,
                Font = new Font("Noto Sans Lao", 6, FontStyle.Regular),
                AutoSize = true
            };
            Label lblPeriod = new Label
            {
                Text = "ໂມງຮຽນ: " + period,
                Font = new Font("Noto Sans Lao", 6, FontStyle.Regular),
                AutoSize = true
            };

            Label lblSubject = new Label
            {
                Text = $"ຊື່ວິຊາ: {subject}",
                Font = new Font("Noto Sans Lao", 6, FontStyle.Italic),
                AutoSize = true
            };

            Label lblTeacher = new Label
            {
                Text = $"ຊື່ອາຈານ: {teacher}",
                Font = new Font("Noto Sans Lao", 6, FontStyle.Regular),
                AutoSize = true
            };

            Label lblRoomType = new Label
            {
                Text = $"ປະເພດຫ້ອງ: {roomType}",
                Font = new Font("Noto Sans Lao", 6, FontStyle.Regular),
                AutoSize = true
            };

            FlowLayoutPanel layout = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Dock = DockStyle.Fill,
                AutoSize = true,
                Height = 1000,
                WrapContents = false
            };

            layout.Controls.Add(lblTitle);
            layout.Controls.Add(majorTitle);
            layout.Controls.Add(lblPeriod);
            layout.Controls.Add(lblSubject);
            layout.Controls.Add(lblTeacher);
            layout.Controls.Add(lblRoomType);
            card.Controls.Add(layout);

            return card;
        }

        public void loadDataFilter()
        {
            List<MajorModel> majors = _majorController.getMajors("");
            List<TermModel> termModels = _termController.getTerms("");
            List<LevelModel> levels = _levelController.getLevels("");
            List<ClassMajor> classMajors = _classMajorController.GetStudentClasstList("");


            cmbClass.DisplayMember = "ClassName"; // Replace with the property you want to display
            cmbClass.ValueMember = "Id";
            cmbClass.DataSource = classMajors;

            cmbTerms.DisplayMember = "TermName"; // Replace with the property you want to display
            cmbTerms.ValueMember = "Id";
            cmbTerms.DataSource = termModels;

            cmbMajors.DisplayMember = "MajorName"; // Replace with the property you want to display
            cmbMajors.ValueMember = "Id";    // Replace with the property you want as the value
            cmbMajors.DataSource = majors;

            cmbLevel.DisplayMember = "LevelName"; // Replace with the property you want to display
            cmbLevel.ValueMember = "Id";    // Replace with the property you want as the value
            cmbLevel.DataSource = levels;
        }

        private void cmbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClass.SelectedValue != null && cmbTerms.SelectedValue != null && cmbLevel.SelectedValue != null && cmbMajors.SelectedValue != null)
            {
                InitializeWeekGrid();
            }

        }

        private void cmbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClass.SelectedValue != null && cmbTerms.SelectedValue != null && cmbLevel.SelectedValue != null && cmbMajors.SelectedValue != null)
            {
                InitializeWeekGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            schedulePage.visibleGeneratePage();


        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cmbTerms.SelectedValue != null && cmbLevel.SelectedValue != null && cmbMajors.SelectedValue != null)
            {
                InitializeWeekGrid();
                List<ClassMajor> classMajors = _classMajorController.GetRoomByMajor(int.Parse(cmbMajors.SelectedValue.ToString()), int.Parse(cmbLevel.SelectedValue.ToString()));

                cmbClass.DisplayMember = "ClassName"; // Replace with the property you want to display
                cmbClass.ValueMember = "Id";
                cmbClass.DataSource = classMajors;
            }
        }

        private void cmbMajors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMajors.SelectedValue != null  && cmbTerms.SelectedValue != null && cmbLevel.SelectedValue != null)
            {
                InitializeWeekGrid();
                List<ClassMajor> classMajors = _classMajorController.GetRoomByMajor(int.Parse(cmbMajors.SelectedValue.ToString()), int.Parse(cmbLevel.SelectedValue.ToString()));

                cmbClass.DisplayMember = "ClassName"; // Replace with the property you want to display
                cmbClass.ValueMember = "Id";
                cmbClass.DataSource = classMajors;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditTablePage editDialog = new EditTablePage(int.Parse(cmbLevel.SelectedValue.ToString()), int.Parse(cmbTerms.SelectedValue.ToString()), int.Parse(cmbMajors.SelectedValue.ToString()), int.Parse(cmbClass.SelectedValue.ToString()));
            editDialog.ShowDialog();
            if (cmbMajors.SelectedValue != null && cmbClass.SelectedValue != null && cmbTerms.SelectedValue != null && cmbLevel.SelectedValue != null)
            {
                InitializeWeekGrid();
            }
        }

        private void cmbTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMajors.SelectedValue != null && cmbClass.SelectedValue != null && cmbTerms.SelectedValue != null && cmbLevel.SelectedValue != null)
            {
                InitializeWeekGrid();
            }
        }
    }
}
