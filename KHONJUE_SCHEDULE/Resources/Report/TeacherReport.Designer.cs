namespace KHONJUE_SCHEDULE.Resources.Report
{
    partial class TeacherReport
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
            panel1 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            REPORT_CONTAINER = new Panel();
            label4 = new Label();
            txtSearch = new TextBox();
            panel6 = new Panel();
            cmbDays = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1552, 62);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(977, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 62);
            panel2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.SteelBlue;
            button3.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(22, 4);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(179, 48);
            button3.TabIndex = 7;
            button3.Text = "ສ້າງລາຍງານ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Firebrick;
            button2.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(207, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(179, 48);
            button2.TabIndex = 6;
            button2.Text = "Export Pdf";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Green;
            button1.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(393, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(179, 48);
            button1.TabIndex = 5;
            button1.Text = "Export Excel";
            button1.UseVisualStyleBackColor = false;
            // 
            // REPORT_CONTAINER
            // 
            REPORT_CONTAINER.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Location = new Point(0, 62);
            REPORT_CONTAINER.Name = "REPORT_CONTAINER";
            REPORT_CONTAINER.Size = new Size(1552, 594);
            REPORT_CONTAINER.TabIndex = 1;
            REPORT_CONTAINER.Paint += REPORT_CONTAINER_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(368, 16);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 1;
            label4.Text = "ລະຫັດອາຈານ";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(20, 10);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(342, 40);
            txtSearch.TabIndex = 28;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtSearch);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(498, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(479, 62);
            panel6.TabIndex = 3;
            // 
            // cmbDays
            // 
            cmbDays.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbDays.FormattingEnabled = true;
            cmbDays.Location = new Point(12, 11);
            cmbDays.Margin = new Padding(3, 4, 3, 4);
            cmbDays.Name = "cmbDays";
            cmbDays.Size = new Size(251, 36);
            cmbDays.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(275, 16);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 1;
            label1.Text = "ເລືອກມື້";
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cmbDays);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(140, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(358, 62);
            panel3.TabIndex = 5;
            // 
            // TeacherReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(REPORT_CONTAINER);
            Controls.Add(panel1);
            Name = "TeacherReport";
            Size = new Size(1552, 656);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Panel REPORT_CONTAINER;
        private Button button3;
        private Panel panel6;
        private TextBox txtSearch;
        private Label label4;
        private Panel panel3;
        private Label label1;
        private ComboBox cmbDays;
    }
}
