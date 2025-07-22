namespace KHONJUE_SCHEDULE.Resources.Management
{
    partial class CREATE_MAJOR_FORM
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
            panel1 = new Panel();
            titleLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel8 = new Panel();
            txtMajorName = new TextBox();
            panel9 = new Panel();
            label5 = new Label();
            closeBtn = new Button();
            createBtn = new Button();
            panel4 = new Panel();
            cmbCrl = new ComboBox();
            panel5 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(titleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 52);
            panel1.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(5, 4);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(167, 44);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "ເພິ່ມຂໍ້ມູນສາຂາ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 52);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(448, 100);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtMajorName);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(3, 4);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(442, 89);
            panel8.TabIndex = 4;
            // 
            // txtMajorName
            // 
            txtMajorName.Dock = DockStyle.Fill;
            txtMajorName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMajorName.Location = new Point(0, 42);
            txtMajorName.Margin = new Padding(3, 4, 3, 4);
            txtMajorName.Name = "txtMajorName";
            txtMajorName.Size = new Size(442, 30);
            txtMajorName.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(label5);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(442, 42);
            panel9.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.SizeAll;
            label5.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 4);
            label5.Name = "label5";
            label5.Size = new Size(66, 33);
            label5.TabIndex = 1;
            label5.Text = "ຊື່ສາຂາ";
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            closeBtn.BackColor = Color.DarkRed;
            closeBtn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(16, 415);
            closeBtn.Margin = new Padding(3, 4, 3, 4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(201, 52);
            closeBtn.TabIndex = 15;
            closeBtn.Text = "ອອກ";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click_1;
            // 
            // createBtn
            // 
            createBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            createBtn.BackColor = Color.CornflowerBlue;
            createBtn.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.ForeColor = Color.White;
            createBtn.Location = new Point(235, 415);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(201, 52);
            createBtn.TabIndex = 14;
            createBtn.Text = "ບັນທຶກ";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(cmbCrl);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 153);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(448, 89);
            panel4.TabIndex = 16;
            // 
            // cmbCrl
            // 
            cmbCrl.Dock = DockStyle.Fill;
            cmbCrl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCrl.FormattingEnabled = true;
            cmbCrl.Location = new Point(0, 42);
            cmbCrl.Margin = new Padding(3, 4, 3, 4);
            cmbCrl.Name = "cmbCrl";
            cmbCrl.Size = new Size(448, 33);
            cmbCrl.TabIndex = 3;
            cmbCrl.SelectedIndexChanged += cmbCrl_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(448, 42);
            panel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.SizeAll;
            label2.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(69, 33);
            label2.TabIndex = 1;
            label2.Text = "ຫຼັກສູດ";
            // 
            // CREATE_MAJOR_FORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 481);
            Controls.Add(panel4);
            Controls.Add(closeBtn);
            Controls.Add(createBtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CREATE_MAJOR_FORM";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label titleLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel8;
        private Panel panel9;
        private Label label5;
        private TextBox txtMajorName;
        private Button closeBtn;
        private Button createBtn;
        private Panel panel4;
        private ComboBox cmbCrl;
        private Panel panel5;
        private Label label2;
    }
}