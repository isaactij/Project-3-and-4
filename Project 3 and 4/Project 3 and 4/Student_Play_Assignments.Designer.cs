namespace Project_3_and_4
{
    partial class Student_Play_Assignments
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
            this.Page_Title_label = new System.Windows.Forms.Label();
            this.Description_Text_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Answer_button4 = new System.Windows.Forms.Button();
            this.Answer_button3 = new System.Windows.Forms.Button();
            this.Answer_button2 = new System.Windows.Forms.Button();
            this.Answer_button1 = new System.Windows.Forms.Button();
            this.Question_Text_label = new System.Windows.Forms.Label();
            this.Assignment_Title_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Page_Title_label
            // 
            this.Page_Title_label.AutoSize = true;
            this.Page_Title_label.Location = new System.Drawing.Point(0, 0);
            this.Page_Title_label.Name = "Page_Title_label";
            this.Page_Title_label.Size = new System.Drawing.Size(101, 13);
            this.Page_Title_label.TabIndex = 0;
            this.Page_Title_label.Text = "Student Assignment";
            // 
            // Description_Text_label
            // 
            this.Description_Text_label.AutoSize = true;
            this.Description_Text_label.Location = new System.Drawing.Point(-3, 57);
            this.Description_Text_label.Name = "Description_Text_label";
            this.Description_Text_label.Size = new System.Drawing.Size(60, 13);
            this.Description_Text_label.TabIndex = 1;
            this.Description_Text_label.Text = "Description";
            this.Description_Text_label.Click += new System.EventHandler(this.Description_Text_label_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Answer_button4);
            this.panel1.Controls.Add(this.Answer_button3);
            this.panel1.Controls.Add(this.Answer_button2);
            this.panel1.Controls.Add(this.Answer_button1);
            this.panel1.Controls.Add(this.Question_Text_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 297);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Answer_button4
            // 
            this.Answer_button4.Location = new System.Drawing.Point(598, 250);
            this.Answer_button4.Name = "Answer_button4";
            this.Answer_button4.Size = new System.Drawing.Size(335, 23);
            this.Answer_button4.TabIndex = 4;
            this.Answer_button4.Text = "Answer Four";
            this.Answer_button4.UseVisualStyleBackColor = true;
            this.Answer_button4.Click += new System.EventHandler(this.Answer_button4_Click);
            // 
            // Answer_button3
            // 
            this.Answer_button3.Location = new System.Drawing.Point(598, 175);
            this.Answer_button3.Name = "Answer_button3";
            this.Answer_button3.Size = new System.Drawing.Size(335, 23);
            this.Answer_button3.TabIndex = 3;
            this.Answer_button3.Text = "Answer Three";
            this.Answer_button3.UseVisualStyleBackColor = true;
            this.Answer_button3.Click += new System.EventHandler(this.Answer_button3_Click);
            // 
            // Answer_button2
            // 
            this.Answer_button2.Location = new System.Drawing.Point(598, 100);
            this.Answer_button2.Name = "Answer_button2";
            this.Answer_button2.Size = new System.Drawing.Size(336, 23);
            this.Answer_button2.TabIndex = 2;
            this.Answer_button2.Text = "Answer Two";
            this.Answer_button2.UseVisualStyleBackColor = true;
            this.Answer_button2.Click += new System.EventHandler(this.Answer_button2_Click);
            // 
            // Answer_button1
            // 
            this.Answer_button1.Location = new System.Drawing.Point(598, 25);
            this.Answer_button1.Name = "Answer_button1";
            this.Answer_button1.Size = new System.Drawing.Size(336, 25);
            this.Answer_button1.TabIndex = 1;
            this.Answer_button1.Text = "Answer One";
            this.Answer_button1.UseVisualStyleBackColor = true;
            this.Answer_button1.Click += new System.EventHandler(this.Answer_button1_Click);
            // 
            // Question_Text_label
            // 
            this.Question_Text_label.AutoSize = true;
            this.Question_Text_label.Location = new System.Drawing.Point(0, 0);
            this.Question_Text_label.Name = "Question_Text_label";
            this.Question_Text_label.Size = new System.Drawing.Size(49, 13);
            this.Question_Text_label.TabIndex = 0;
            this.Question_Text_label.Text = "Question";
            this.Question_Text_label.Click += new System.EventHandler(this.Question_Text_label_Click);
            // 
            // Assignment_Title_label
            // 
            this.Assignment_Title_label.AutoSize = true;
            this.Assignment_Title_label.Location = new System.Drawing.Point(0, 33);
            this.Assignment_Title_label.Name = "Assignment_Title_label";
            this.Assignment_Title_label.Size = new System.Drawing.Size(84, 13);
            this.Assignment_Title_label.TabIndex = 3;
            this.Assignment_Title_label.Text = "Assignment Title";
            // 
            // Student_Play_Assignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Assignment_Title_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Description_Text_label);
            this.Controls.Add(this.Page_Title_label);
            this.Name = "Student_Play_Assignments";
            this.Size = new System.Drawing.Size(934, 380);
            this.Load += new System.EventHandler(this.Student_Play_Assignments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Page_Title_label;
        private System.Windows.Forms.Label Description_Text_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Answer_button4;
        private System.Windows.Forms.Button Answer_button3;
        private System.Windows.Forms.Button Answer_button2;
        private System.Windows.Forms.Button Answer_button1;
        private System.Windows.Forms.Label Question_Text_label;
        private System.Windows.Forms.Label Assignment_Title_label;
    }
}
