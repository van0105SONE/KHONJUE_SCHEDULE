namespace KHONJUE_SCHEDULE.Resources.Setting
{
    partial class RoleControl1
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
            panel2 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            txtSearch = new TextBox();
            button3 = new Button();
            panel1 = new Panel();
            panel6 = new Panel();
            moduleDatagridView = new DataGridView();
            panel5 = new Panel();
            roleGridview = new DataGridView();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)moduleDatagridView).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roleGridview).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1203, 60);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Dock = DockStyle.Left;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(102, 60);
            button1.TabIndex = 2;
            button1.Text = "ສິດທິຜູ້ໃຊ້";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(1203, 41);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(button3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(583, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(620, 41);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(409, 2);
            button2.Name = "button2";
            button2.Size = new Size(61, 36);
            button2.TabIndex = 3;
            button2.Text = "ຄົ້ນຫາ";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Noto Sans Lao", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(215, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 29);
            txtSearch.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(499, 1);
            button3.Name = "button3";
            button3.Size = new Size(102, 36);
            button3.TabIndex = 1;
            button3.Text = "ເພີ່ມຂໍ້ມູນ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(1203, 440);
            panel1.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Controls.Add(moduleDatagridView);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(585, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(618, 440);
            panel6.TabIndex = 1;
            // 
            // moduleDatagridView
            // 
            moduleDatagridView.BackgroundColor = SystemColors.ButtonHighlight;
            moduleDatagridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            moduleDatagridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moduleDatagridView.Dock = DockStyle.Fill;
            moduleDatagridView.Location = new Point(0, 0);
            moduleDatagridView.Name = "moduleDatagridView";
            moduleDatagridView.Size = new Size(618, 440);
            moduleDatagridView.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(roleGridview);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(585, 440);
            panel5.TabIndex = 0;
            // 
            // roleGridview
            // 
            roleGridview.BackgroundColor = SystemColors.ButtonHighlight;
            roleGridview.CellBorderStyle = DataGridViewCellBorderStyle.None;
            roleGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roleGridview.Dock = DockStyle.Fill;
            roleGridview.Location = new Point(0, 0);
            roleGridview.Name = "roleGridview";
            roleGridview.Size = new Size(585, 440);
            roleGridview.TabIndex = 0;
            roleGridview.CellClick += roleGridview_CellClick;
            // 
            // RoleControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "RoleControl1";
            Size = new Size(1203, 541);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)moduleDatagridView).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roleGridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private Panel panel4;
        private Panel panel3;
        private Button button2;
        private TextBox txtSearch;
        private Button button3;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private DataGridView moduleDatagridView;
        private DataGridView roleGridview;
    }
}
