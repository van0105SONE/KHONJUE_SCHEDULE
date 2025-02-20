namespace KHONJUE_SCHEDULE.Resource.Setting
{
    partial class ROLE_FORM
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
            label19 = new Label();
            panel1 = new Panel();
            panel8 = new Panel();
            txtRoleName = new TextBox();
            panel9 = new Panel();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel20 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel20.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label19);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(632, 67);
            panel2.TabIndex = 0;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Noto Sans Lao", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(9, 19);
            label19.Name = "label19";
            label19.Size = new Size(91, 35);
            label19.TabIndex = 2;
            label19.Text = "ເພີ່ມສິດທິ";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(632, 261);
            panel1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtRoleName);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(49, 88);
            panel8.Name = "panel8";
            panel8.Size = new Size(506, 67);
            panel8.TabIndex = 5;
            // 
            // txtRoleName
            // 
            txtRoleName.Dock = DockStyle.Fill;
            txtRoleName.Font = new Font("Noto Sans Lao", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoleName.Location = new Point(0, 32);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(506, 34);
            txtRoleName.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(label5);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(506, 32);
            panel9.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.SizeAll;
            label5.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(54, 26);
            label5.TabIndex = 1;
            label5.Text = "ຊື້ສິດທິ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.SkyBlue;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(453, 15);
            button1.Name = "button1";
            button1.Size = new Size(176, 40);
            button1.TabIndex = 1;
            button1.Text = "ບັນທຶກ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Red;
            button2.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(271, 15);
            button2.Name = "button2";
            button2.Size = new Size(176, 40);
            button2.TabIndex = 2;
            button2.Text = "ອອກ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel20
            // 
            panel20.Controls.Add(button2);
            panel20.Controls.Add(button1);
            panel20.Dock = DockStyle.Bottom;
            panel20.Location = new Point(0, 194);
            panel20.Name = "panel20";
            panel20.Size = new Size(632, 67);
            panel20.TabIndex = 2;
            // 
            // ROLE_FORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 261);
            Controls.Add(panel20);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ROLE_FORM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "USER_CREATE_FORM";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel20.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label19;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Panel panel20;
        private Panel panel8;
        private TextBox txtRoleName;
        private Panel panel9;
        private Label label5;
    }
}