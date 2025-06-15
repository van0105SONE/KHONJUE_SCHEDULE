namespace KHONJUE_SCHEDULE.Resources.Management
{
    partial class TeacherManagement
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            panel2 = new Panel();
            subjectDatagrid = new DataGridView();
            button4 = new Button();
            button1 = new Button();
            txtSearch = new TextBox();
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
            panel4.Controls.Add(button1);
            panel4.Controls.Add(txtSearch);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(907, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 71);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1267, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 71);
            panel3.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.CornflowerBlue;
            button3.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(176, 12);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(117, 48);
            button3.TabIndex = 3;
            button3.Text = "ເພີ່ມຂໍ້ມູນ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            subjectDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            subjectDatagrid.RowHeadersWidth = 51;
            subjectDatagrid.ShowCellToolTips = false;
            subjectDatagrid.Size = new Size(1576, 692);
            subjectDatagrid.TabIndex = 0;
            subjectDatagrid.CellContentClick += subjectDatagrid_CellContentClick;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.DarkRed;
            button4.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(6, 12);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(166, 48);
            button4.TabIndex = 10;
            button4.Text = "ລ້າງຂໍ້ມູນທັງໝົດ";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = SystemColors.Desktop;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(257, 12);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(97, 48);
            button1.TabIndex = 14;
            button1.Text = "ຄົ້ນຫາ";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(30, 16);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 40);
            txtSearch.TabIndex = 13;
            // 
            // TeacherManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TeacherManagement";
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
        private Button button3;
        private Panel panel4;
        private Button button4;
        private Button button1;
        private TextBox txtSearch;
    }
}
