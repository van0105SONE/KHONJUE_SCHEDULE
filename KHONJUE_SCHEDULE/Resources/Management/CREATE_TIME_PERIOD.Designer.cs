namespace KHONJUE_SCHEDULE.Resources.Management
{
    partial class CREATE_TIME_PERIOD
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            titleLabel = new Label();
            panel8 = new Panel();
            startTimePicker = new DateTimePicker();
            panel9 = new Panel();
            label5 = new Label();
            panel1 = new Panel();
            endTimePicker = new DateTimePicker();
            panel3 = new Panel();
            label1 = new Label();
            deleteBtn = new Button();
            createBtn = new Button();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(titleLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(687, 89);
            panel2.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(10, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(209, 44);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "ເພີ່ມເວລາເຂົ້າ-ອອກ";
            // 
            // panel8
            // 
            panel8.Controls.Add(startTimePicker);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(0, 98);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(339, 89);
            panel8.TabIndex = 4;
            // 
            // startTimePicker
            // 
            startTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startTimePicker.Dock = DockStyle.Fill;
            startTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startTimePicker.Location = new Point(0, 42);
            startTimePicker.Margin = new Padding(3, 4, 3, 4);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new Size(339, 34);
            startTimePicker.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(label5);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(339, 42);
            panel9.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.SizeAll;
            label5.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 4);
            label5.Name = "label5";
            label5.Size = new Size(85, 33);
            label5.TabIndex = 1;
            label5.Text = "ເວລາເລີ່ມ";
            // 
            // panel1
            // 
            panel1.Controls.Add(endTimePicker);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(346, 98);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 89);
            panel1.TabIndex = 5;
            // 
            // endTimePicker
            // 
            endTimePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endTimePicker.CustomFormat = "hh:mm";
            endTimePicker.Dock = DockStyle.Fill;
            endTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endTimePicker.Location = new Point(0, 42);
            endTimePicker.Margin = new Padding(3, 4, 3, 4);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(339, 34);
            endTimePicker.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(339, 42);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeAll;
            label1.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(85, 33);
            label1.TabIndex = 1;
            label1.Text = "ເວລາເລີກ";
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(264, 232);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(201, 52);
            deleteBtn.TabIndex = 8;
            deleteBtn.Text = "ອອກ";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // createBtn
            // 
            createBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            createBtn.BackColor = Color.SkyBlue;
            createBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.ForeColor = Color.White;
            createBtn.Location = new Point(485, 232);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(201, 52);
            createBtn.TabIndex = 7;
            createBtn.Text = "ບັນທຶກ";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // CREATE_TIME_PERIOD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 302);
            Controls.Add(deleteBtn);
            Controls.Add(createBtn);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CREATE_TIME_PERIOD";
            Text = "CreateTimePeriod";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label titleLabel;
        private Panel panel8;
        private Panel panel9;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private DateTimePicker endTimePicker;
        private Panel panel3;
        private Label label1;
        private Button deleteBtn;
        private Button createBtn;
        private DateTimePicker startTimePicker;
    }
}