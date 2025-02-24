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
            button1 = new Button();
            button3 = new Button();
            timePeriodDatagrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timePeriodDatagrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1420, 53);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Green;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1286, 8);
            button1.Name = "button1";
            button1.Size = new Size(102, 36);
            button1.TabIndex = 3;
            button1.Text = "ເພີ່ມຂໍ້ມູນ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Green;
            button3.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(2463, 11);
            button3.Name = "button3";
            button3.Size = new Size(102, 0);
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
            timePeriodDatagrid.Location = new Point(0, 53);
            timePeriodDatagrid.Name = "timePeriodDatagrid";
            timePeriodDatagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            timePeriodDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            timePeriodDatagrid.ShowCellToolTips = false;
            timePeriodDatagrid.Size = new Size(1420, 562);
            timePeriodDatagrid.TabIndex = 2;
            timePeriodDatagrid.CellContentClick += timePeriodDatagrid_CellContentClick;
            // 
            // TimePeriodManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timePeriodDatagrid);
            Controls.Add(panel1);
            Name = "TimePeriodManagement";
            Size = new Size(1420, 615);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)timePeriodDatagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button1;
        private DataGridView timePeriodDatagrid;
    }
}
