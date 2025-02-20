namespace KHONJUE_SCHEDULE.Resources.Management
{
    partial class CREATE_LEVEL_FORM
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
            txtLevelName = new TextBox();
            panel9 = new Panel();
            label5 = new Label();
            createBtn = new Button();
            closeBtn = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(titleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 40);
            panel1.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Noto Sans Lao", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(4, 3);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(112, 35);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "ເພິ່ມຊັ້ນຮຽນ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(392, 75);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtLevelName);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(387, 67);
            panel8.TabIndex = 4;
            // 
            // txtLevelName
            // 
            txtLevelName.Dock = DockStyle.Fill;
            txtLevelName.Font = new Font("Noto Sans Lao", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLevelName.Location = new Point(0, 32);
            txtLevelName.Name = "txtLevelName";
            txtLevelName.Size = new Size(387, 34);
            txtLevelName.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(label5);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(387, 32);
            panel9.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.SizeAll;
            label5.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(71, 26);
            label5.TabIndex = 1;
            label5.Text = "ຊື່ຊັ້ນຣຽນ";
            // 
            // createBtn
            // 
            createBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            createBtn.BackColor = Color.SkyBlue;
            createBtn.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.ForeColor = Color.White;
            createBtn.Location = new Point(204, 145);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(176, 40);
            createBtn.TabIndex = 4;
            createBtn.Text = "ບັນທຶກ";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += button1_Click;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            closeBtn.BackColor = Color.Red;
            closeBtn.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(12, 145);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(176, 40);
            closeBtn.TabIndex = 5;
            closeBtn.Text = "ອອກ";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += button2_Click;
            // 
            // CREATE_LEVEL_FORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 197);
            Controls.Add(closeBtn);
            Controls.Add(createBtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "CREATE_LEVEL_FORM";
            Text = "CREATE_LEVEL_FORM";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label titleLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel8;
        private Panel panel9;
        private Label label5;
        private TextBox txtLevelName;
        private Button createBtn;
        private Button closeBtn;
    }
}