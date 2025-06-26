namespace KHONJUE_SCHEDULE.Resources.Schedule
{
    partial class GenerateButton
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
            createBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // createBtn
            // 
            createBtn.Anchor = AnchorStyles.None;
            createBtn.BackColor = Color.Green;
            createBtn.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createBtn.ForeColor = Color.White;
            createBtn.Location = new Point(584, 220);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(201, 53);
            createBtn.TabIndex = 23;
            createBtn.Text = "ເລີ່ມຈັດຕາຕະລາງ";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(355, 220);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(201, 53);
            button1.TabIndex = 24;
            button1.Text = "ກັບຄືນ";
            button1.UseVisualStyleBackColor = false;
            // 
            // GenerateButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(createBtn);
            Name = "GenerateButton";
            Size = new Size(1118, 558);
            ResumeLayout(false);
        }

        #endregion

        private Button createBtn;
        private Button button1;
    }
}
