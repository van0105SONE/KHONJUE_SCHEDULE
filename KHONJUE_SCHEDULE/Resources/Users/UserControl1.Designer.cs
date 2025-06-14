namespace KHONJUE_SCHEDULE
{
    partial class UserControl1
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
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            txtSearch = new TextBox();
            button3 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1315, 747);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 135);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1315, 612);
            panel5.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1315, 612);
            dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 80);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1315, 55);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(606, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(709, 55);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(336, 3);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(70, 48);
            button2.TabIndex = 3;
            button2.Text = "ຄົ້ນຫາ";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(114, 9);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 35);
            txtSearch.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(570, 1);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(117, 48);
            button3.TabIndex = 1;
            button3.Text = "ເພີ່ມຂໍ້ມູນ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(431, 1);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 48);
            button1.TabIndex = 0;
            button1.Text = "Excel";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1315, 80);
            panel2.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControl1";
            Size = new Size(1315, 747);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel4;
        private Panel panel3;
        private Button button2;
        private TextBox txtSearch;
        private Button button3;
        private Button button1;
        private Panel panel5;
        private DataGridView dataGridView1;
    }
}
