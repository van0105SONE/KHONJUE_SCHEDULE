﻿namespace KHONJUE_SCHEDULE.Resources.Report
{
    partial class ReportManagement
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
            REPORT_CONTAINER = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnManageSubject);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1555, 80);
            panel2.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Dock = DockStyle.Left;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(797, 0);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(213, 80);
            button2.TabIndex = 6;
            button2.Text = "ລາຍງານວິຊາ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Dock = DockStyle.Left;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(587, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(210, 80);
            button1.TabIndex = 5;
            button1.Text = "ລາຍງານອາຈານ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.Dock = DockStyle.Left;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(401, 0);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(186, 80);
            button5.TabIndex = 4;
            button5.Text = "ລາຍງານຫ້ອງຮຽນ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.Dock = DockStyle.Left;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Noto Sans Lao", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(210, 0);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(191, 80);
            button4.TabIndex = 3;
            button4.Text = "ລາຍງານອາຈານສອນ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            btnManageSubject.Text = "ລາຍງານຕາຕະລາງຮຽນ";
            btnManageSubject.UseVisualStyleBackColor = false;
            btnManageSubject.Click += btnManageSubject_Click;
            // 
            // REPORT_CONTAINER
            // 
            REPORT_CONTAINER.Dock = DockStyle.Fill;
            REPORT_CONTAINER.Location = new Point(0, 80);
            REPORT_CONTAINER.Name = "REPORT_CONTAINER";
            REPORT_CONTAINER.Size = new Size(1555, 607);
            REPORT_CONTAINER.TabIndex = 7;
            // 
            // ReportManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(REPORT_CONTAINER);
            Controls.Add(panel2);
            Name = "ReportManagement";
            Size = new Size(1555, 687);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button btnManageSubject;
        private Panel REPORT_CONTAINER;
    }
}
