namespace KHONJUE_SCHEDULE.Resources.Management
{
    partial class TimePeriodManagement
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
            button8 = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            button4 = new Button();
            button1 = new Button();
            timePeriodDatagrid = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timePeriodDatagrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1623, 71);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(button8);
            panel4.Controls.Add(txtSearch);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(944, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(369, 71);
            panel4.TabIndex = 8;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button8.BackColor = SystemColors.Desktop;
            button8.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(263, 11);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(97, 48);
            button8.TabIndex = 18;
            button8.Text = "ຄົ້ນຫາ";
            button8.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(36, 15);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 40);
            txtSearch.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1313, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 71);
            panel2.TabIndex = 3;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.DarkRed;
            button4.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(11, 11);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(166, 48);
            button4.TabIndex = 14;
            button4.Text = "ລ້າງຂໍ້ມູນທັງໝົດ";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(183, 11);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 4;
            button1.Text = "ເພີ່ມຂໍ້ມູນ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // timePeriodDatagrid
            // 
            timePeriodDatagrid.BorderStyle = BorderStyle.None;
            timePeriodDatagrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            timePeriodDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            timePeriodDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            timePeriodDatagrid.Dock = DockStyle.Fill;
            timePeriodDatagrid.Location = new Point(0, 71);
            timePeriodDatagrid.Margin = new Padding(3, 4, 3, 4);
            timePeriodDatagrid.Name = "timePeriodDatagrid";
            timePeriodDatagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            timePeriodDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            timePeriodDatagrid.RowHeadersWidth = 51;
            timePeriodDatagrid.ShowCellToolTips = false;
            timePeriodDatagrid.Size = new Size(1623, 749);
            timePeriodDatagrid.TabIndex = 2;
            timePeriodDatagrid.CellContentClick += timePeriodDatagrid_CellContentClick;
            // 
            // TimePeriodManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timePeriodDatagrid);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TimePeriodManagement";
            Size = new Size(1623, 820);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)timePeriodDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView timePeriodDatagrid;
        private Panel panel2;
        private Button button1;
        private Button button4;
        private Panel panel4;
        private TextBox txtSearch;
        private Button button8;
    }
}
