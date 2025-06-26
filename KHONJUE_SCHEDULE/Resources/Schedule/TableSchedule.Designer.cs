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
            cmbTerms = new ComboBox();
            panel5 = new Panel();
            subjectDatagrid = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            cmbMajors = new ComboBox();
            button3 = new Button();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
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
            panel6.Controls.Add(cmbTerms);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(879, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(402, 55);
            panel6.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(275, 16);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 1;
            label4.Text = "ເລືອກພາກຮຽນ";
            // 
            // cmbTerms
            // 
            cmbTerms.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTerms.FormattingEnabled = true;
            cmbTerms.Location = new Point(12, 11);
            cmbTerms.Margin = new Padding(3, 4, 3, 4);
            cmbTerms.Name = "cmbTerms";
            cmbTerms.Size = new Size(251, 28);
            cmbTerms.TabIndex = 5;
            cmbTerms.SelectedIndexChanged += cmbMajor_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(button3);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1281, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(251, 55);
            panel5.TabIndex = 1;
            // 
            // subjectDatagrid
            // 
            subjectDatagrid.Dock = DockStyle.Fill;
            subjectDatagrid.Location = new Point(0, 55);
            subjectDatagrid.Name = "subjectDatagrid";
            subjectDatagrid.Size = new Size(1532, 517);
            subjectDatagrid.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbMajors);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(477, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 55);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(275, 16);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "ເລືອກສາຂາ";
            // 
            // cmbMajors
            // 
            cmbMajors.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMajors.FormattingEnabled = true;
            cmbMajors.Location = new Point(12, 11);
            cmbMajors.Margin = new Padding(3, 4, 3, 4);
            cmbMajors.Name = "cmbMajors";
            cmbMajors.Size = new Size(251, 28);
            cmbMajors.TabIndex = 5;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.DarkGreen;
            button3.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(36, 3);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(179, 48);
            button3.TabIndex = 8;
            button3.Text = "ສ້າຕາຕະລາງໃຫມ່";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel6;
        private Label label4;
        private ComboBox cmbTerms;
        private Panel panel5;
        private FlowLayoutPanel subjectDatagrid;
        private Panel panel1;
        private Label label1;
        private ComboBox cmbMajors;
        private Button button3;
    }
}
