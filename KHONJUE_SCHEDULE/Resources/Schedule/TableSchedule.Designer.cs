namespace KHONJUE_SCHEDULE.Resources.Schedule
{
    partial class TableSchedule
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            panel6 = new Panel();
            label4 = new Label();
            cmbMajor = new ComboBox();
            panel5 = new Panel();
            label3 = new Label();
            cmbTerm = new ComboBox();
            subjectDatagrid = new FlowLayoutPanel();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1532, 55);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Controls.Add(cmbMajor);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(728, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(402, 55);
            panel6.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(275, 16);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 1;
            label4.Text = "ເລືອກສາຂາ";
            // 
            // cmbMajor
            // 
            cmbMajor.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMajor.FormattingEnabled = true;
            cmbMajor.Location = new Point(12, 11);
            cmbMajor.Margin = new Padding(3, 4, 3, 4);
            cmbMajor.Name = "cmbMajor";
            cmbMajor.Size = new Size(251, 36);
            cmbMajor.TabIndex = 5;
            cmbMajor.SelectedIndexChanged += cmbMajor_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(cmbTerm);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1130, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 55);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(275, 16);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 1;
            label3.Text = "ເລືອກພາກຽນ";
            // 
            // cmbTerm
            // 
            cmbTerm.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTerm.FormattingEnabled = true;
            cmbTerm.Location = new Point(12, 11);
            cmbTerm.Margin = new Padding(3, 4, 3, 4);
            cmbTerm.Name = "cmbTerm";
            cmbTerm.Size = new Size(251, 36);
            cmbTerm.TabIndex = 5;
            cmbTerm.SelectedIndexChanged += cmbTerm_SelectedIndexChanged;
            // 
            // subjectDatagrid
            // 
            subjectDatagrid.Dock = DockStyle.Fill;
            subjectDatagrid.Location = new Point(0, 55);
            subjectDatagrid.Name = "subjectDatagrid";
            subjectDatagrid.Size = new Size(1532, 517);
            subjectDatagrid.TabIndex = 3;
            // 
            // TableSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(subjectDatagrid);
            Controls.Add(panel3);
            Name = "TableSchedule";
            Size = new Size(1532, 572);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel6;
        private Label label4;
        private ComboBox cmbMajor;
        private Panel panel5;
        private Label label3;
        private ComboBox cmbTerm;
        private FlowLayoutPanel subjectDatagrid;
    }
}
