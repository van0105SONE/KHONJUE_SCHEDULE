namespace KHONJUE_SCHEDULE.Resources.Management
{
    partial class TermSubjectManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermSubjectManagement));
            panel1 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            button3 = new Button();
            levelDatagrid = new DataGridView();
            button1 = new Button();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)levelDatagrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1456, 71);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(989, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 67);
            panel3.TabIndex = 7;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.White;
            button2.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(261, 12);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(47, 44);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1316, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(136, 67);
            panel2.TabIndex = 6;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Green;
            button3.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(2644, 15);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(117, 0);
            button3.TabIndex = 2;
            button3.Text = "ເພີ່ມຂໍ້ມູນ";
            button3.UseVisualStyleBackColor = false;
            // 
            // levelDatagrid
            // 
            levelDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            levelDatagrid.Dock = DockStyle.Fill;
            levelDatagrid.Location = new Point(0, 71);
            levelDatagrid.Margin = new Padding(3, 4, 3, 4);
            levelDatagrid.Name = "levelDatagrid";
            levelDatagrid.RowHeadersWidth = 51;
            levelDatagrid.Size = new Size(1456, 674);
            levelDatagrid.TabIndex = 2;
            levelDatagrid.CellContentClick += levelDatagrid_CellContentClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Green;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(10, 9);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 5;
            button1.Text = "ເພີ່ມຂໍ້ມູນ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(34, 14);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 40);
            txtSearch.TabIndex = 9;
            // 
            // TermSubjectManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(levelDatagrid);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TermSubjectManagement";
            Size = new Size(1456, 745);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)levelDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private DataGridView levelDatagrid;
        private Panel panel3;
        private Button button2;
        private Panel panel2;
        private Button button1;
        private TextBox txtSearch;
    }
}
