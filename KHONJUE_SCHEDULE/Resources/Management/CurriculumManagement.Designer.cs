﻿namespace KHONJUE_SCHEDULE.Resources.Management
{
    partial class CurriculumManagement
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
            button2 = new Button();
            button1 = new Button();
            levelDatagrid = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)levelDatagrid).BeginInit();
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
            panel1.Size = new Size(1456, 71);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button8);
            panel3.Controls.Add(txtSearch);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(740, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(409, 71);
            panel3.TabIndex = 4;
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
            button8.TabIndex = 29;
            button8.Text = "ຄົ້ນຫາ";
            button8.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(79, 17);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 40);
            txtSearch.TabIndex = 28;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1149, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(307, 71);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.DarkRed;
            button2.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(6, 11);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(166, 48);
            button2.TabIndex = 25;
            button2.Text = "ລ້າງຂໍ້ມູນທັງໝົດ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(178, 11);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 24;
            button1.Text = "ເພີ່ມຂໍ້ມູນ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // CurriculumManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(levelDatagrid);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CurriculumManagement";
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
        private DataGridView levelDatagrid;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private TextBox txtSearch;
        private Button button8;
    }
}
