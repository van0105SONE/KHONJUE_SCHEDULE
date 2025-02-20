namespace KHONJUE_SCHEDULE.Resources.Management
{
    partial class InfoManagement
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
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            button4 = new Button();
            btnManageSubject = new Button();
            InfoContainer = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnManageSubject);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1377, 60);
            panel2.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Dock = DockStyle.Left;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(655, 0);
            button2.Name = "button2";
            button2.Size = new Size(159, 60);
            button2.TabIndex = 6;
            button2.Text = "ຂໍ້ມູນຊັ້ນຣຽນ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Dock = DockStyle.Left;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(496, 0);
            button1.Name = "button1";
            button1.Size = new Size(159, 60);
            button1.TabIndex = 5;
            button1.Text = "ຂໍ້ມູນວິຊາຮຽນ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SkyBlue;
            button5.Dock = DockStyle.Left;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(337, 0);
            button5.Name = "button5";
            button5.Size = new Size(159, 60);
            button5.TabIndex = 4;
            button5.Text = "ຂໍ້ມຸນຫ້ອງນັກຮຽນ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SkyBlue;
            button4.Dock = DockStyle.Left;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(144, 0);
            button4.Name = "button4";
            button4.Size = new Size(193, 60);
            button4.TabIndex = 3;
            button4.Text = "ຈັດການຂໍ້ມູນຊົ່ວໂມງຮຽນ";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnManageSubject
            // 
            btnManageSubject.BackColor = Color.SkyBlue;
            btnManageSubject.Dock = DockStyle.Left;
            btnManageSubject.FlatStyle = FlatStyle.Flat;
            btnManageSubject.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageSubject.ForeColor = SystemColors.ButtonHighlight;
            btnManageSubject.Location = new Point(0, 0);
            btnManageSubject.Name = "btnManageSubject";
            btnManageSubject.Size = new Size(144, 60);
            btnManageSubject.TabIndex = 2;
            btnManageSubject.Text = "ຈັດການຂໍ້ມູນວິຊາ";
            btnManageSubject.UseVisualStyleBackColor = false;
            btnManageSubject.Click += btnManageSubject_Click;
            // 
            // InfoContainer
            // 
            InfoContainer.Dock = DockStyle.Fill;
            InfoContainer.Location = new Point(0, 60);
            InfoContainer.Name = "InfoContainer";
            InfoContainer.Size = new Size(1377, 535);
            InfoContainer.TabIndex = 6;
            // 
            // InfoManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(InfoContainer);
            Controls.Add(panel2);
            Name = "InfoManagement";
            Size = new Size(1377, 595);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button btnManageSubject;
        private Panel InfoContainer;
        private Button button2;
    }
}
