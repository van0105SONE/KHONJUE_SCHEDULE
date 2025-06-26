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
    public partial class InfoManagement : UserControl
    {
        public InfoManagement()
        {
            InitializeComponent();
            InfoContainer.Controls.Clear();
            TermSubjectManagement levelManagement = new TermSubjectManagement();
            levelManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(levelManagement);
            Style.SetActiveButton(btnManageSubject, panel2.Controls);
        }

        private void btnManageSubject_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            TermSubjectManagement levelManagement = new TermSubjectManagement();
            levelManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(levelManagement);

            Style.SetActiveButton(btnManageSubject, panel2.Controls);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            InfoContainer.Controls.Clear();
            TermManagement curriculumManagement = new TermManagement();
            curriculumManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(curriculumManagement);
            Style.SetActiveButton(button2, panel2.Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            SubjectManagement subjectManagement = new SubjectManagement();
            subjectManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(subjectManagement);
            Style.SetActiveButton(button1, panel2.Controls);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            TeacherManagement curriculumManagement = new TeacherManagement();
            curriculumManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(curriculumManagement);
            Style.SetActiveButton(button5, panel2.Controls);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            TeacherSubjectManagement curriculumManagement = new TeacherSubjectManagement();
            curriculumManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(curriculumManagement);
            Style.SetActiveButton(button4, panel2.Controls);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // it work
            InfoContainer.Controls.Clear();
            LevelManagement levelManagement = new LevelManagement();
            levelManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(levelManagement);
            Style.SetActiveButton(button3, panel2.Controls);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            StudentClassManagement studentClassManagement = new StudentClassManagement();
            studentClassManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(studentClassManagement);
            Style.SetActiveButton(button6, panel2.Controls);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            MajorManagement curriculumManagement = new MajorManagement();
            curriculumManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(curriculumManagement);
            Style.SetActiveButton(button7, panel2.Controls);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            TimePeriodManagement timePerdioManagement = new TimePeriodManagement();
            timePerdioManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(timePerdioManagement);
            Style.SetActiveButton(button8, panel2.Controls);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InfoContainer.Controls.Clear();
            CurriculumManagement curriculumManagement = new CurriculumManagement();
            curriculumManagement.Dock = DockStyle.Fill;
            InfoContainer.Controls.Add(curriculumManagement);
            Style.SetActiveButton(button9, panel2.Controls);


        }
    }
}
