﻿using KHONJUE_SCHEDULE.DatabaseContexts;
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
    public partial class CREATE_TERM_SUBJECT_FORM : Form
    {
        private Actions action { get; set; }
        private DatabaseContext _dbContext { get; set; }
        private SubjectController _subjectController { get; set; }
        private TermController _termController { get; set; }
        private LevelController _levelController { get; set; }
        private MajorController _majorController { get; set; }
        private TermSubjectModel termSubject { get; set; }
        private CurriculumController _curriculumController { get; set; }
        public CREATE_TERM_SUBJECT_FORM()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _subjectController = new SubjectController(_dbContext);
            _termController = new TermController(_dbContext);
            _levelController = new LevelController(_dbContext);
            _majorController = new MajorController(_dbContext);
            _curriculumController = new CurriculumController(_dbContext);
            termSubject = new TermSubjectModel();
            action = Actions.Create;
            loadSubject();
            loadTerm();
            loadLevel();
            loadMajors();
            loadCurriculum();
        }

        public CREATE_TERM_SUBJECT_FORM(TermSubjectModel termSubjectParam)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _subjectController = new SubjectController(_dbContext);
            _termController = new TermController(_dbContext);
            _levelController = new LevelController(_dbContext);
            _majorController = new MajorController(_dbContext);
            _curriculumController = new CurriculumController(_dbContext);
            loadSubject();
            loadTerm();
            loadLevel();
            loadMajors();
            loadCurriculum();
            termSubject = termSubjectParam;
            cmbLevel.SelectedValue = termSubjectParam.LevelId;
            cmbCurriculum.SelectedValue = termSubjectParam.CurriculumId;
            cmbMajor.SelectedValue = termSubjectParam.MajorId;
            cmbSubject.SelectedValue = termSubjectParam.SubjectId;
            cmbTerm.SelectedValue = termSubjectParam.TermId;
            action = Actions.Update;

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
            if (cmbLevel.SelectedValue != null && cmbTerm.SelectedValue != null && cmbMajor.SelectedValue != null && cmbCurriculum.SelectedValue != null)
            {
                List<SubjectModel> roles = _subjectController.GetSubjectListNotExistInTerm(int.Parse(cmbLevel.SelectedValue.ToString()), int.Parse(cmbTerm.SelectedValue.ToString()), int.Parse(cmbMajor.SelectedValue.ToString()),  int.Parse(cmbCurriculum.SelectedValue.ToString()));

                // Set the DisplayMember and ValueMember properties
                cmbSubject.DisplayMember = "SubjectName"; // Replace with the property you want to display
                cmbSubject.ValueMember = "Id";    // Replace with the property you want as the value

                // Bind the roles list to the ComboBox
                cmbSubject.DataSource = roles;
            }

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

        private void loadCurriculum()
        {
            if (cmbMajor.SelectedValue != null)
            {
                List<CurriculumModel> roles = _curriculumController.getCurriculumByMajor(int.Parse(cmbMajor.SelectedValue.ToString()));
                // Set the DisplayMember and ValueMember properties
                cmbCurriculum.DisplayMember = "CurriculumName"; // Replace with the property you want to display
                cmbCurriculum.ValueMember = "Id";    // Replace with the property you want as the value
                                                     // Bind the roles list to the ComboBox
                cmbCurriculum.DataSource = roles;
            }
        }

        private void createBtn_Click_2(object sender, EventArgs e)
        {


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

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            bool isExist = _subjectController.isSubjectExistInTermAngMajor(int.Parse(cmbSubject.SelectedValue.ToString()), int.Parse(cmbTerm.SelectedValue.ToString()), int.Parse(cmbMajor.SelectedValue.ToString()), int.Parse(cmbLevel.SelectedValue.ToString()));
            if (!isExist)
            {
                isSuccess = _subjectController.AddSubjectAndTerm(int.Parse(cmbSubject.SelectedValue.ToString()), int.Parse(cmbMajor.SelectedValue.ToString()), int.Parse(cmbTerm.SelectedValue.ToString()), int.Parse(cmbLevel.SelectedValue.ToString()), int.Parse(cmbCurriculum.SelectedValue.ToString()));
                if (isSuccess)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"ວິຊານີ້ໃນພາກຮຽນແລ້ວ ກາລຸເລືອກວິຊາໃຫມ່ແລ້ວລອງອີກຄັ້ງ?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void closeBtn_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadCurriculum();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSubject_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbSubject_Enter(object sender, EventArgs e)
        {

        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSubject();
        }

        private void cmbMajor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbMajor.SelectedValue != null)
            {
                List<CurriculumModel> roles = _curriculumController.getCurriculumByMajor(int.Parse(cmbMajor.SelectedValue.ToString()));
                // Set the DisplayMember and ValueMember properties
                cmbCurriculum.DisplayMember = "CurriculumName"; // Replace with the property you want to display
                cmbCurriculum.ValueMember = "Id";    // Replace with the property you want as the value
                                                     // Bind the roles list to the ComboBox
                cmbCurriculum.DataSource = roles;
            }
        }

        private void cmbCurriculum_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSubject();
        }

        private void cmbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSubject();
        }
    }
}
