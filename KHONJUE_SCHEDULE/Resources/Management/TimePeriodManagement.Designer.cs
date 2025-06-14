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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimePeriodManagement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            button3 = new Button();
            timePeriodDatagrid = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timePeriodDatagrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1623, 71);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(txtSearch);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1178, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(308, 71);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.White;
            button2.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(244, 13);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(47, 44);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(17, 15);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 40);
            txtSearch.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1486, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(137, 71);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Green;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(10, 11);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 4;
            button1.Text = "ເພີ່ມຂໍ້ມູນ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Green;
            button3.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(2815, 15);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(117, 0);
            button3.TabIndex = 2;
            button3.Text = "ເພີ່ມຂໍ້ມູນ";
            button3.UseVisualStyleBackColor = false;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)timePeriodDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private DataGridView timePeriodDatagrid;
        private Panel panel3;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private TextBox txtSearch;
    }
}
