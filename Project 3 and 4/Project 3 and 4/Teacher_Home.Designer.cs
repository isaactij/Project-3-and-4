namespace Project_3_and_4
{
    partial class Teacher_Home
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
            this.Students_listBox1 = new System.Windows.Forms.ListBox();
            this.Panel_label = new System.Windows.Forms.Label();
            this.Level_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Level_label = new System.Windows.Forms.Label();
            this.Level_Text = new System.Windows.Forms.Label();
            this.Progress_Bar_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Column_Two_label = new System.Windows.Forms.Label();
            this.Column_One_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column_One_listBox = new System.Windows.Forms.ListBox();
            this.Column_Two_listBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Students_listBox1
            // 
            this.Students_listBox1.FormattingEnabled = true;
            this.Students_listBox1.Location = new System.Drawing.Point(0, 38);
            this.Students_listBox1.Name = "Students_listBox1";
            this.Students_listBox1.Size = new System.Drawing.Size(239, 342);
            this.Students_listBox1.TabIndex = 0;
            this.Students_listBox1.SelectedIndexChanged += new System.EventHandler(this.Students_listBox1_SelectedIndexChanged);
            // 
            // Panel_label
            // 
            this.Panel_label.AutoSize = true;
            this.Panel_label.Location = new System.Drawing.Point(-3, 0);
            this.Panel_label.Name = "Panel_label";
            this.Panel_label.Size = new System.Drawing.Size(106, 13);
            this.Panel_label.TabIndex = 1;
            this.Panel_label.Text = "Teacher Home Page";
            // 
            // Level_ProgressBar
            // 
            this.Level_ProgressBar.Location = new System.Drawing.Point(146, 53);
            this.Level_ProgressBar.Name = "Level_ProgressBar";
            this.Level_ProgressBar.Size = new System.Drawing.Size(100, 23);
            this.Level_ProgressBar.TabIndex = 0;
            // 
            // Level_label
            // 
            this.Level_label.AutoSize = true;
            this.Level_label.Location = new System.Drawing.Point(14, 24);
            this.Level_label.Name = "Level_label";
            this.Level_label.Size = new System.Drawing.Size(76, 13);
            this.Level_label.TabIndex = 1;
            this.Level_label.Text = "Student Level:";
            // 
            // Level_Text
            // 
            this.Level_Text.AutoSize = true;
            this.Level_Text.Location = new System.Drawing.Point(143, 24);
            this.Level_Text.Name = "Level_Text";
            this.Level_Text.Size = new System.Drawing.Size(33, 13);
            this.Level_Text.TabIndex = 2;
            this.Level_Text.Text = "Level";
            // 
            // Progress_Bar_label
            // 
            this.Progress_Bar_label.AutoSize = true;
            this.Progress_Bar_label.Location = new System.Drawing.Point(14, 63);
            this.Progress_Bar_label.Name = "Progress_Bar_label";
            this.Progress_Bar_label.Size = new System.Drawing.Size(113, 13);
            this.Progress_Bar_label.TabIndex = 3;
            this.Progress_Bar_label.Text = "Amount To Next Level";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Column_One_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Column_Two_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Column_One_listBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Column_Two_listBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 117);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.55556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 224);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Column_Two_label
            // 
            this.Column_Two_label.AutoSize = true;
            this.Column_Two_label.Location = new System.Drawing.Point(328, 0);
            this.Column_Two_label.Name = "Column_Two_label";
            this.Column_Two_label.Size = new System.Drawing.Size(36, 13);
            this.Column_Two_label.TabIndex = 1;
            this.Column_Two_label.Text = "Grade";
            // 
            // Column_One_label
            // 
            this.Column_One_label.AutoSize = true;
            this.Column_One_label.Location = new System.Drawing.Point(3, 0);
            this.Column_One_label.Name = "Column_One_label";
            this.Column_One_label.Size = new System.Drawing.Size(92, 13);
            this.Column_One_label.TabIndex = 0;
            this.Column_One_label.Text = "Assignment Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.Progress_Bar_label);
            this.panel1.Controls.Add(this.Level_Text);
            this.panel1.Controls.Add(this.Level_label);
            this.panel1.Controls.Add(this.Level_ProgressBar);
            this.panel1.Location = new System.Drawing.Point(283, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 341);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Column_One_listBox
            // 
            this.Column_One_listBox.FormattingEnabled = true;
            this.Column_One_listBox.Location = new System.Drawing.Point(3, 30);
            this.Column_One_listBox.Name = "Column_One_listBox";
            this.Column_One_listBox.Size = new System.Drawing.Size(319, 186);
            this.Column_One_listBox.TabIndex = 2;
            // 
            // Column_Two_listBox
            // 
            this.Column_Two_listBox.FormattingEnabled = true;
            this.Column_Two_listBox.Location = new System.Drawing.Point(328, 30);
            this.Column_Two_listBox.Name = "Column_Two_listBox";
            this.Column_Two_listBox.Size = new System.Drawing.Size(319, 186);
            this.Column_Two_listBox.TabIndex = 3;
            // 
            // Teacher_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel_label);
            this.Controls.Add(this.Students_listBox1);
            this.Name = "Teacher_Home";
            this.Size = new System.Drawing.Size(934, 380);
            this.Load += new System.EventHandler(this.Teacher_Home_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Students_listBox1;
        private System.Windows.Forms.Label Panel_label;
        private System.Windows.Forms.ProgressBar Level_ProgressBar;
        private System.Windows.Forms.Label Level_label;
        private System.Windows.Forms.Label Level_Text;
        private System.Windows.Forms.Label Progress_Bar_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Column_One_label;
        private System.Windows.Forms.Label Column_Two_label;
        private System.Windows.Forms.ListBox Column_One_listBox;
        private System.Windows.Forms.ListBox Column_Two_listBox;
        private System.Windows.Forms.Panel panel1;
    }
}
