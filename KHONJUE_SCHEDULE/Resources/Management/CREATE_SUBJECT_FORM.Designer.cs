﻿namespace KHONJUE_SCHEDULE.Resources.Management
{
    partial class CREATE_SUBJECT_FORM
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
            deleteBtn = new Button();
            createBtn = new Button();
            panel7 = new Panel();
            cmbCrcl = new ComboBox();
            panel10 = new Panel();
            label3 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            panel5 = new Panel();
            txtDescription = new TextBox();
            panel6 = new Panel();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel8 = new Panel();
            txtSubject = new TextBox();
            panel9 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            titleLabel = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel10.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(createBtn);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(flowLayoutPanel3);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 491);
            panel1.TabIndex = 3;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            deleteBtn.BackColor = Color.Red;
            deleteBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(277, 425);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(201, 53);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "ອອກ";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // createBtn
            // 
            createBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            createBtn.BackColor = Color.SkyBlue;
            createBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.ForeColor = Color.White;
            createBtn.Location = new Point(500, 425);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(201, 53);
            createBtn.TabIndex = 10;
            createBtn.Text = "ບັນທຶກ";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click_1;
            // 
            // panel7
            // 
            panel7.Controls.Add(cmbCrcl);
            panel7.Controls.Add(panel10);
            panel7.Location = new Point(0, 290);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(709, 89);
            panel7.TabIndex = 9;
            // 
            // cmbCrcl
            // 
            cmbCrcl.Dock = DockStyle.Fill;
            cmbCrcl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCrcl.FormattingEnabled = true;
            cmbCrcl.Location = new Point(0, 43);
            cmbCrcl.Margin = new Padding(3, 4, 3, 4);
            cmbCrcl.Name = "cmbCrcl";
            cmbCrcl.Size = new Size(709, 33);
            cmbCrcl.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.Controls.Add(label3);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(709, 43);
            panel10.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.SizeAll;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 4);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 1;
            label3.Text = "ຫຼັກສູດ";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(panel5);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(0, 189);
            flowLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(713, 104);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtDescription);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(3, 4);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(706, 89);
            panel5.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(0, 43);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(706, 30);
            txtDescription.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(706, 43);
            panel6.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.SizeAll;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 1;
            label2.Text = "ຄຳອະທິບາຍ";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 89);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(713, 100);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtSubject);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(3, 4);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(706, 89);
            panel8.TabIndex = 4;
            // 
            // txtSubject
            // 
            txtSubject.Dock = DockStyle.Fill;
            txtSubject.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubject.Location = new Point(0, 43);
            txtSubject.Margin = new Padding(3, 4, 3, 4);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(706, 30);
            txtSubject.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(label5);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(706, 43);
            panel9.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.SizeAll;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 4);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 1;
            label5.Text = "ຊຶ່ວິຊາ";
            // 
            // panel2
            // 
            panel2.Controls.Add(titleLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 89);
            panel2.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(10, 25);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(103, 31);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "ເພີ່ມຜູ້ໃຊ້";
            // 
            // CREATE_SUBJECT_FORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 491);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CREATE_SUBJECT_FORM";
            Text = "CreateSub_jectForm";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel8;
        private TextBox txtSubject;
        private Panel panel9;
        private Label label5;
        private Panel panel2;
        private Label titleLabel;
        private FlowLayoutPanel flowLayoutPanel3;
        private Panel panel5;
        private TextBox txtDescription;
        private Panel panel6;
        private Label label2;
        private Panel panel7;
        private ComboBox cmbCrcl;
        private Panel panel10;
        private Label label3;
        private Button deleteBtn;
        private Button createBtn;
    }
}