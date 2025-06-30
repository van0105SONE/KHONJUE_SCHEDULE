namespace KHONJUE_SCHEDULE
{
    partial class LoginForm
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
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_05_03_at_13_52_37;
            pictureBox1.Location = new Point(150, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Noto Sans Lao", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(84, 281);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(268, 40);
            txtUsername.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 244);
            label3.Name = "label3";
            label3.Size = new Size(60, 33);
            label3.TabIndex = 5;
            label3.Text = "ຊື່ຜູ້ໃຊ້";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 325);
            label1.Name = "label1";
            label1.Size = new Size(96, 33);
            label1.TabIndex = 7;
            label1.Text = "ລະຫັດຜ່ານ";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Noto Sans Lao", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(84, 362);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(268, 40);
            txtPassword.TabIndex = 6;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Green;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(203, 437);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(149, 53);
            button1.TabIndex = 8;
            button1.Text = "ເຂົ້າສູ່ລະບົບ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 163);
            label2.Name = "label2";
            label2.Size = new Size(202, 44);
            label2.TabIndex = 9;
            label2.Text = "ລະບົບຈັດຕາຕະລາງ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans Lao", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(213, 163);
            label4.Name = "label4";
            label4.Size = new Size(196, 44);
            label4.TabIndex = 10;
            label4.Text = "ສະຖາບັນ ຂົງຈື ມຊ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(433, 503);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private Label label3;
        private Label label1;
        private TextBox txtPassword;
        private Button button1;
        private Label label2;
        private Label label4;
    }
}