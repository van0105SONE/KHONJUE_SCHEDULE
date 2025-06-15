namespace KHONJUE_SCHEDULE.Resources.Search
{
    partial class SearchContainer
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
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            cmbMajor2 = new ComboBox();
            cmbYear = new ComboBox();
            cmbTerm = new ComboBox();
            label1 = new Label();
            cmbTypeName = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1571, 556);
            dataGridView1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.Green;
            button3.Font = new Font("Noto Sans Lao", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(4011, 15);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(117, 17);
            button3.TabIndex = 2;
            button3.Text = "ເພີ່ມຂໍ້ມູນ";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Noto Sans Lao", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1436, 34);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(109, 38);
            button1.TabIndex = 13;
            button1.Text = "ຄົ້ນຫາ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbTypeName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(cmbMajor2);
            panel1.Controls.Add(cmbYear);
            panel1.Controls.Add(cmbTerm);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1571, 88);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Noto Sans Lao", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1138, 7);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 18;
            label5.Text = "ພິມຄົ້ນຫາ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans Lao", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(622, 7);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 17;
            label4.Text = "ພາກຮຽນ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans Lao", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(365, 7);
            label3.Name = "label3";
            label3.Size = new Size(21, 25);
            label3.TabIndex = 16;
            label3.Text = "ປີ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans Lao", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 7);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 15;
            label2.Text = "ສາຂາ";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Noto Sans Lao", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1138, 34);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(278, 37);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbMajor2
            // 
            cmbMajor2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbMajor2.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMajor2.FormattingEnabled = true;
            cmbMajor2.Location = new Point(108, 34);
            cmbMajor2.Margin = new Padding(3, 4, 3, 4);
            cmbMajor2.Name = "cmbMajor2";
            cmbMajor2.Size = new Size(251, 36);
            cmbMajor2.TabIndex = 10;
            // 
            // cmbYear
            // 
            cmbYear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbYear.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(365, 34);
            cmbYear.Margin = new Padding(3, 4, 3, 4);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(251, 36);
            cmbYear.TabIndex = 9;
            // 
            // cmbTerm
            // 
            cmbTerm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbTerm.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTerm.FormattingEnabled = true;
            cmbTerm.Location = new Point(622, 34);
            cmbTerm.Margin = new Padding(3, 4, 3, 4);
            cmbTerm.Name = "cmbTerm";
            cmbTerm.Size = new Size(251, 36);
            cmbTerm.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans Lao", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(881, 7);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 20;
            label1.Text = " ຄົນຫາຈາກຊື່";
            // 
            // cmbTypeName
            // 
            cmbTypeName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbTypeName.Font = new Font("Noto Sans Lao", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbTypeName.FormattingEnabled = true;
            cmbTypeName.Location = new Point(881, 34);
            cmbTypeName.Margin = new Padding(3, 4, 3, 4);
            cmbTypeName.Name = "cmbTypeName";
            cmbTypeName.Size = new Size(251, 36);
            cmbTypeName.TabIndex = 19;
            // 
            // SearchContainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "SearchContainer";
            Size = new Size(1571, 644);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button1;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSearch;
        private ComboBox cmbMajor2;
        private ComboBox cmbYear;
        private ComboBox cmbTerm;
        private Label label1;
        private ComboBox cmbTypeName;
    }
}
