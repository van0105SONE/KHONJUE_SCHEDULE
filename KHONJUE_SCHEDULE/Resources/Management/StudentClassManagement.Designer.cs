namespace KHONJUE_SCHEDULE.Resources.Management
{
    partial class StudentClassManagement
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
            panel3 = new Panel();
            button8 = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            button4 = new Button();
            button2 = new Button();
            studentClassDatagrid = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentClassDatagrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1673, 71);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button8);
            panel3.Controls.Add(txtSearch);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(954, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(409, 71);
            panel3.TabIndex = 7;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button8.BackColor = SystemColors.Desktop;
            button8.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(306, 11);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(97, 48);
            button8.TabIndex = 11;
            button8.Text = "ຄົ້ນຫາ";
            button8.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(79, 15);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 40);
            txtSearch.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1363, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 71);
            panel2.TabIndex = 4;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.DarkRed;
            button4.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(6, 11);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(166, 48);
            button4.TabIndex = 8;
            button4.Text = "ລ້າງຂໍ້ມູນທັງໝົດ";
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.CornflowerBlue;
            button2.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(178, 11);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(117, 48);
            button2.TabIndex = 5;
            button2.Text = "ເພີ່ມຂໍ້ມູນ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // studentClassDatagrid
            // 
            studentClassDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentClassDatagrid.Dock = DockStyle.Fill;
            studentClassDatagrid.Location = new Point(0, 71);
            studentClassDatagrid.Margin = new Padding(3, 4, 3, 4);
            studentClassDatagrid.Name = "studentClassDatagrid";
            studentClassDatagrid.RowHeadersWidth = 51;
            studentClassDatagrid.Size = new Size(1673, 700);
            studentClassDatagrid.TabIndex = 3;
            studentClassDatagrid.CellContentClick += studentClassDatagrid_CellContentClick;
            // 
            // StudentClassManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(studentClassDatagrid);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentClassManagement";
            Size = new Size(1673, 771);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentClassDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView studentClassDatagrid;
        private Panel panel2;
        private Button button2;
        private Button button4;
        private Panel panel3;
        private TextBox txtSearch;
        private Button button8;
    }
}
