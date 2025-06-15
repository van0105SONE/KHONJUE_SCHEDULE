namespace KHONJUE_SCHEDULE.Resources.Search
{
    partial class SearchPage
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
            panel1 = new Panel();
            label1 = new Label();
            MAIN_CONTAINER = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1578, 71);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans Lao", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 0;
            label1.Text = "ຄົ້ນຫາຂໍ້ມູນ";
            // 
            // MAIN_CONTAINER
            // 
            MAIN_CONTAINER.Dock = DockStyle.Fill;
            MAIN_CONTAINER.Location = new Point(0, 71);
            MAIN_CONTAINER.Name = "MAIN_CONTAINER";
            MAIN_CONTAINER.Size = new Size(1578, 597);
            MAIN_CONTAINER.TabIndex = 2;
            // 
            // SearchPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MAIN_CONTAINER);
            Controls.Add(panel1);
            Name = "SearchPage";
            Size = new Size(1578, 668);
            Load += SearchPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel MAIN_CONTAINER;
    }
}
