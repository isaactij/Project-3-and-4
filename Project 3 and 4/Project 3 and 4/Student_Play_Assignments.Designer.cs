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
            this.Question_Text_label = new System.Windows.Forms.Label();
            this.Assignment_Title_label = new System.Windows.Forms.Label();
            this.question_Number_Label = new System.Windows.Forms.Label();
            this.Answer_button1 = new System.Windows.Forms.RadioButton();
            this.Answer_button2 = new System.Windows.Forms.RadioButton();
            this.Answer_button3 = new System.Windows.Forms.RadioButton();
            this.Answer_button4 = new System.Windows.Forms.RadioButton();
            this.Next_Button = new System.Windows.Forms.Button();
            this.Previous_Button = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.Previous_Button);
            this.panel1.Controls.Add(this.Next_Button);
            this.panel1.Controls.Add(this.Answer_button4);
            this.panel1.Controls.Add(this.Answer_button3);
            this.panel1.Controls.Add(this.Answer_button2);
            this.panel1.Controls.Add(this.Answer_button1);
            this.panel1.Controls.Add(this.question_Number_Label);
            this.panel1.Controls.Add(this.Question_Text_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 297);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // question_Number_Label
            // 
            this.question_Number_Label.AutoSize = true;
            this.question_Number_Label.Location = new System.Drawing.Point(877, 0);
            this.question_Number_Label.Name = "question_Number_Label";
            this.question_Number_Label.Size = new System.Drawing.Size(54, 13);
            this.question_Number_Label.TabIndex = 5;
            this.question_Number_Label.Text = "question#";
            // 
            // Answer_button1
            // 
            this.Answer_button1.AutoSize = true;
            this.Answer_button1.Location = new System.Drawing.Point(55, 126);
            this.Answer_button1.Name = "Answer_button1";
            this.Answer_button1.Size = new System.Drawing.Size(99, 17);
            this.Answer_button1.TabIndex = 6;
            this.Answer_button1.TabStop = true;
            this.Answer_button1.Text = "Answer button1";
            this.Answer_button1.UseVisualStyleBackColor = true;
            // 
            // Answer_button2
            // 
            this.Answer_button2.AutoSize = true;
            this.Answer_button2.Location = new System.Drawing.Point(55, 170);
            this.Answer_button2.Name = "Answer_button2";
            this.Answer_button2.Size = new System.Drawing.Size(99, 17);
            this.Answer_button2.TabIndex = 7;
            this.Answer_button2.TabStop = true;
            this.Answer_button2.Text = "Answer button2";
            this.Answer_button2.UseVisualStyleBackColor = true;
            // 
            // Answer_button3
            // 
            this.Answer_button3.AutoSize = true;
            this.Answer_button3.Location = new System.Drawing.Point(55, 210);
            this.Answer_button3.Name = "Answer_button3";
            this.Answer_button3.Size = new System.Drawing.Size(99, 17);
            this.Answer_button3.TabIndex = 8;
            this.Answer_button3.TabStop = true;
            this.Answer_button3.Text = "Answer button3";
            this.Answer_button3.UseVisualStyleBackColor = true;
            // 
            // Answer_button4
            // 
            this.Answer_button4.AutoSize = true;
            this.Answer_button4.Location = new System.Drawing.Point(55, 249);
            this.Answer_button4.Name = "Answer_button4";
            this.Answer_button4.Size = new System.Drawing.Size(99, 17);
            this.Answer_button4.TabIndex = 9;
            this.Answer_button4.TabStop = true;
            this.Answer_button4.Text = "Answer button4";
            this.Answer_button4.UseVisualStyleBackColor = true;
            // 
            // Next_Button
            // 
            this.Next_Button.Location = new System.Drawing.Point(856, 271);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(75, 23);
            this.Next_Button.TabIndex = 10;
            this.Next_Button.Text = "Next";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // Previous_Button
            // 
            this.Previous_Button.Location = new System.Drawing.Point(0, 271);
            this.Previous_Button.Name = "Previous_Button";
            this.Previous_Button.Size = new System.Drawing.Size(75, 23);
            this.Previous_Button.TabIndex = 11;
            this.Previous_Button.Text = "Previous";
            this.Previous_Button.UseVisualStyleBackColor = true;
            this.Previous_Button.Click += new System.EventHandler(this.Previous_Button_Click);
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
        private System.Windows.Forms.Label Question_Text_label;
        private System.Windows.Forms.Label Assignment_Title_label;
        private System.Windows.Forms.Label question_Number_Label;
        private System.Windows.Forms.RadioButton Answer_button4;
        private System.Windows.Forms.RadioButton Answer_button3;
        private System.Windows.Forms.RadioButton Answer_button2;
        private System.Windows.Forms.RadioButton Answer_button1;
        private System.Windows.Forms.Button Previous_Button;
        private System.Windows.Forms.Button Next_Button;
    }
}
