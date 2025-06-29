namespace KHONJUE_SCHEDULE.Resources.Management
{
    partial class TeacherSubjectManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            txtSearch = new TextBox();
            button8 = new Button();
            panel3 = new Panel();
            button4 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            subjectDatagrid = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)subjectDatagrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1576, 71);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(button8);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(911, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 71);
            panel4.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(30, 14);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 40);
            txtSearch.TabIndex = 22;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button8.BackColor = SystemColors.Desktop;
            button8.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(257, 10);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(97, 48);
            button8.TabIndex = 21;
            button8.Text = "ຄົ້ນຫາ";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1271, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 71);
            panel3.TabIndex = 0;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.DarkRed;
            button4.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(6, 10);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(166, 48);
            button4.TabIndex = 18;
            button4.Text = "ລ້າງຂໍ້ມູນທັງໝົດ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(178, 10);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 17;
            button1.Text = "ເພີ່ມຂໍ້ມູນ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(subjectDatagrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 71);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1576, 692);
            panel2.TabIndex = 1;
            // 
            // subjectDatagrid
            // 
            subjectDatagrid.BorderStyle = BorderStyle.None;
            subjectDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            subjectDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            subjectDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subjectDatagrid.Dock = DockStyle.Fill;
            subjectDatagrid.Location = new Point(0, 0);
            subjectDatagrid.Margin = new Padding(3, 4, 3, 4);
            subjectDatagrid.Name = "subjectDatagrid";
            subjectDatagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            subjectDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            subjectDatagrid.RowHeadersWidth = 51;
            subjectDatagrid.ShowCellToolTips = false;
            subjectDatagrid.Size = new Size(1576, 692);
            subjectDatagrid.TabIndex = 0;
            subjectDatagrid.CellContentClick += subjectDatagrid_CellContentClick;
            // 
            // TeacherSubjectManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TeacherSubjectManagement";
            Size = new Size(1576, 763);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)subjectDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView subjectDatagrid;
        private Panel panel3;
        private Panel panel4;
        private Button button4;
        private Button button1;
        private Button button8;
        private TextBox txtSearch;
    }
}
