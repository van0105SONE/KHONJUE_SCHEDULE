namespace KHONJUE_SCHEDULE.Resources.Notifications
{
    partial class NotificationManagement
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
            btnManageSubject = new Button();
            NOTI_CONTAINER = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(btnManageSubject);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1566, 80);
            panel2.TabIndex = 7;
            // 
            // btnManageSubject
            // 
            btnManageSubject.BackColor = Color.Green;
            btnManageSubject.Dock = DockStyle.Left;
            btnManageSubject.FlatStyle = FlatStyle.Flat;
            btnManageSubject.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageSubject.ForeColor = SystemColors.ButtonHighlight;
            btnManageSubject.Location = new Point(0, 0);
            btnManageSubject.Margin = new Padding(3, 4, 3, 4);
            btnManageSubject.Name = "btnManageSubject";
            btnManageSubject.Size = new Size(210, 80);
            btnManageSubject.TabIndex = 2;
            btnManageSubject.Text = "ການແຈ້ງເຕືອນ";
            btnManageSubject.UseVisualStyleBackColor = false;
            btnManageSubject.Click += btnManageSubject_Click;
            // 
            // NOTI_CONTAINER
            // 
            NOTI_CONTAINER.Dock = DockStyle.Fill;
            NOTI_CONTAINER.Location = new Point(0, 80);
            NOTI_CONTAINER.Name = "NOTI_CONTAINER";
            NOTI_CONTAINER.Size = new Size(1566, 633);
            NOTI_CONTAINER.TabIndex = 8;
            // 
            // NotificationManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NOTI_CONTAINER);
            Controls.Add(panel2);
            Name = "NotificationManagement";
            Size = new Size(1566, 713);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnManageSubject;
        private Panel NOTI_CONTAINER;
    }
}
