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
        private TermSubjectModel termSubject { get; set; }
        public CREATE_TERM_SUBJECT_FORM()
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _subjectController = new SubjectController(_dbContext);
            _termController = new TermController(_dbContext);
            _levelController = new LevelController(_dbContext);
            termSubject = new TermSubjectModel();
            action = Actions.Create;
            loadSubject();
            loadTerm();
            loadLevel();
        }

        public CREATE_TERM_SUBJECT_FORM(TermSubjectModel termSubjectParam)
        {
            InitializeComponent();
            _dbContext = new DatabaseContext();
            _dbContext.connect();
            _termController = new TermController(_dbContext);
            termSubject = termSubjectParam;
            cmbLevel.SelectedValue = termSubjectParam.TermName;
            action = Actions.Update;
            loadSubject();
            loadTerm();
            loadLevel();
        }



        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void createBtn_Click(object sender, EventArgs e)
        {

        }

        private void createBtn_Click_1(object sender, EventArgs e)
        {
            bool isSuccess = false;

            isSuccess = _subjectController.AddSubjectAndTerm(int.Parse(cmbSubject.SelectedValue.ToString()), int.Parse(cmbTerm.SelectedValue.ToString()), int.Parse(cmbLevel.SelectedValue.ToString()));


            if (isSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void loadSubject()
        {
            List<SubjectModel> roles = _subjectController.GetSubjectList();

            // Set the DisplayMember and ValueMember properties
            cmbSubject.DisplayMember = "SubjectName"; // Replace with the property you want to display
            cmbSubject.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbSubject.DataSource = roles;
        }
        private void loadTerm()
        {
            List<TermModel> roles = _termController.getTerms();

            // Set the DisplayMember and ValueMember properties
            cmbTerm.DisplayMember = "TermName"; // Replace with the property you want to display
            cmbTerm.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbTerm.DataSource = roles;
        }
        private void loadLevel()
        {
            List<LevelModel> roles = _levelController.getLevels();

            // Set the DisplayMember and ValueMember properties
            cmbLevel.DisplayMember = "LevelName"; // Replace with the property you want to display
            cmbLevel.ValueMember = "Id";    // Replace with the property you want as the value

            // Bind the roles list to the ComboBox
            cmbLevel.DataSource = roles;
        }
    }
}
