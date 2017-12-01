namespace Project_3_and_4
{
    partial class Teacher_Create_Assignment
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
            this.Create_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Title_label = new System.Windows.Forms.Label();
            this.Assignment_type_label = new System.Windows.Forms.Label();
            this.Description_label = new System.Windows.Forms.Label();
            this.Question_file_name_label = new System.Windows.Forms.Label();
            this.Choose_assignment_quest = new System.Windows.Forms.RadioButton();
            this.Choose_assignment_hw = new System.Windows.Forms.RadioButton();
            this.choose_assignment_project = new System.Windows.Forms.RadioButton();
            this.choose_assignment_quiz = new System.Windows.Forms.RadioButton();
            this.choose_assignment_test = new System.Windows.Forms.RadioButton();
            this.Skills_add_skill_text = new System.Windows.Forms.TextBox();
            this.add_skill_button = new System.Windows.Forms.Button();
            this.Description_TextBox = new System.Windows.Forms.RichTextBox();
            this.Import_Question_Bank = new System.Windows.Forms.Button();
            this.Assignment_Title_TextBox = new System.Windows.Forms.TextBox();
            this.remove_skill_button = new System.Windows.Forms.Button();
            this.openQuestionFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Error_Label = new System.Windows.Forms.Label();
            this.Information_Button = new System.Windows.Forms.Button();
            this.Information_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(847, 350);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(75, 23);
            this.Create_Button.TabIndex = 0;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Assignment";
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Location = new System.Drawing.Point(3, 37);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(30, 13);
            this.Title_label.TabIndex = 2;
            this.Title_label.Text = "Title:";
            // 
            // Assignment_type_label
            // 
            this.Assignment_type_label.AutoSize = true;
            this.Assignment_type_label.Location = new System.Drawing.Point(3, 70);
            this.Assignment_type_label.Name = "Assignment_type_label";
            this.Assignment_type_label.Size = new System.Drawing.Size(46, 13);
            this.Assignment_type_label.TabIndex = 3;
            this.Assignment_type_label.Text = "Choose:";
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Location = new System.Drawing.Point(3, 110);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(60, 13);
            this.Description_label.TabIndex = 5;
            this.Description_label.Text = "Description";
            // 
            // Question_file_name_label
            // 
            this.Question_file_name_label.AutoSize = true;
            this.Question_file_name_label.Location = new System.Drawing.Point(215, 181);
            this.Question_file_name_label.Name = "Question_file_name_label";
            this.Question_file_name_label.Size = new System.Drawing.Size(62, 13);
            this.Question_file_name_label.TabIndex = 6;
            this.Question_file_name_label.Text = "fileName.txt";
            // 
            // Choose_assignment_quest
            // 
            this.Choose_assignment_quest.AutoSize = true;
            this.Choose_assignment_quest.Location = new System.Drawing.Point(65, 68);
            this.Choose_assignment_quest.Name = "Choose_assignment_quest";
            this.Choose_assignment_quest.Size = new System.Drawing.Size(53, 17);
            this.Choose_assignment_quest.TabIndex = 7;
            this.Choose_assignment_quest.TabStop = true;
            this.Choose_assignment_quest.Text = "Quest";
            this.Choose_assignment_quest.UseVisualStyleBackColor = true;
            // 
            // Choose_assignment_hw
            // 
            this.Choose_assignment_hw.AutoSize = true;
            this.Choose_assignment_hw.Location = new System.Drawing.Point(124, 68);
            this.Choose_assignment_hw.Name = "Choose_assignment_hw";
            this.Choose_assignment_hw.Size = new System.Drawing.Size(76, 17);
            this.Choose_assignment_hw.TabIndex = 8;
            this.Choose_assignment_hw.TabStop = true;
            this.Choose_assignment_hw.Text = "Homework";
            this.Choose_assignment_hw.UseVisualStyleBackColor = true;
            // 
            // choose_assignment_project
            // 
            this.choose_assignment_project.AutoSize = true;
            this.choose_assignment_project.Location = new System.Drawing.Point(206, 68);
            this.choose_assignment_project.Name = "choose_assignment_project";
            this.choose_assignment_project.Size = new System.Drawing.Size(58, 17);
            this.choose_assignment_project.TabIndex = 9;
            this.choose_assignment_project.TabStop = true;
            this.choose_assignment_project.Text = "Project";
            this.choose_assignment_project.UseVisualStyleBackColor = true;
            // 
            // choose_assignment_quiz
            // 
            this.choose_assignment_quiz.AutoSize = true;
            this.choose_assignment_quiz.Location = new System.Drawing.Point(270, 68);
            this.choose_assignment_quiz.Name = "choose_assignment_quiz";
            this.choose_assignment_quiz.Size = new System.Drawing.Size(46, 17);
            this.choose_assignment_quiz.TabIndex = 10;
            this.choose_assignment_quiz.TabStop = true;
            this.choose_assignment_quiz.Text = "Quiz";
            this.choose_assignment_quiz.UseVisualStyleBackColor = true;
            // 
            // choose_assignment_test
            // 
            this.choose_assignment_test.AutoSize = true;
            this.choose_assignment_test.Location = new System.Drawing.Point(322, 68);
            this.choose_assignment_test.Name = "choose_assignment_test";
            this.choose_assignment_test.Size = new System.Drawing.Size(46, 17);
            this.choose_assignment_test.TabIndex = 11;
            this.choose_assignment_test.TabStop = true;
            this.choose_assignment_test.Text = "Test";
            this.choose_assignment_test.UseVisualStyleBackColor = true;
            // 
            // Skills_add_skill_text
            // 
            this.Skills_add_skill_text.Location = new System.Drawing.Point(636, 110);
            this.Skills_add_skill_text.Name = "Skills_add_skill_text";
            this.Skills_add_skill_text.Size = new System.Drawing.Size(162, 20);
            this.Skills_add_skill_text.TabIndex = 13;
            // 
            // add_skill_button
            // 
            this.add_skill_button.Location = new System.Drawing.Point(636, 140);
            this.add_skill_button.Name = "add_skill_button";
            this.add_skill_button.Size = new System.Drawing.Size(75, 23);
            this.add_skill_button.TabIndex = 14;
            this.add_skill_button.Text = "Add skill";
            this.add_skill_button.UseVisualStyleBackColor = true;
            this.add_skill_button.Click += new System.EventHandler(this.add_skill_button_Click);
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Description_TextBox.Location = new System.Drawing.Point(65, 110);
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.Size = new System.Drawing.Size(471, 53);
            this.Description_TextBox.TabIndex = 15;
            this.Description_TextBox.Text = "";
            // 
            // Import_Question_Bank
            // 
            this.Import_Question_Bank.Location = new System.Drawing.Point(65, 181);
            this.Import_Question_Bank.Name = "Import_Question_Bank";
            this.Import_Question_Bank.Size = new System.Drawing.Size(133, 23);
            this.Import_Question_Bank.TabIndex = 16;
            this.Import_Question_Bank.Text = "Choose Question File";
            this.Import_Question_Bank.UseVisualStyleBackColor = true;
            this.Import_Question_Bank.Click += new System.EventHandler(this.Import_Question_Bank_Click);
            // 
            // Assignment_Title_TextBox
            // 
            this.Assignment_Title_TextBox.Location = new System.Drawing.Point(65, 34);
            this.Assignment_Title_TextBox.Name = "Assignment_Title_TextBox";
            this.Assignment_Title_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Assignment_Title_TextBox.TabIndex = 17;
            // 
            // remove_skill_button
            // 
            this.remove_skill_button.Location = new System.Drawing.Point(723, 140);
            this.remove_skill_button.Name = "remove_skill_button";
            this.remove_skill_button.Size = new System.Drawing.Size(75, 23);
            this.remove_skill_button.TabIndex = 18;
            this.remove_skill_button.Text = "Remove skill";
            this.remove_skill_button.UseVisualStyleBackColor = true;
            this.remove_skill_button.Click += new System.EventHandler(this.remove_skill_button_Click);
            // 
            // openQuestionFileDialog
            // 
            this.openQuestionFileDialog.FileName = "openQuestionFileDialog";
            this.openQuestionFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openQuestionFileDialog_FileOk);
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.Location = new System.Drawing.Point(243, 10);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(0, 13);
            this.Error_Label.TabIndex = 19;
            // 
            // Information_Button
            // 
            this.Information_Button.Location = new System.Drawing.Point(509, 181);
            this.Information_Button.Name = "Information_Button";
            this.Information_Button.Size = new System.Drawing.Size(24, 24);
            this.Information_Button.TabIndex = 20;
            this.Information_Button.Text = "?";
            this.Information_Button.UseVisualStyleBackColor = true;
            this.Information_Button.Click += new System.EventHandler(this.Information_Button_Click);
            // 
            // Information_Label
            // 
            this.Information_Label.AutoSize = true;
            this.Information_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information_Label.Location = new System.Drawing.Point(382, 324);
            this.Information_Label.Name = "Information_Label";
            this.Information_Label.Size = new System.Drawing.Size(0, 13);
            this.Information_Label.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(65, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 169);
            this.panel1.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // Teacher_Create_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Information_Label);
            this.Controls.Add(this.Information_Button);
            this.Controls.Add(this.Error_Label);
            this.Controls.Add(this.remove_skill_button);
            this.Controls.Add(this.Assignment_Title_TextBox);
            this.Controls.Add(this.Import_Question_Bank);
            this.Controls.Add(this.Description_TextBox);
            this.Controls.Add(this.add_skill_button);
            this.Controls.Add(this.Skills_add_skill_text);
            this.Controls.Add(this.choose_assignment_test);
            this.Controls.Add(this.choose_assignment_quiz);
            this.Controls.Add(this.choose_assignment_project);
            this.Controls.Add(this.Choose_assignment_hw);
            this.Controls.Add(this.Choose_assignment_quest);
            this.Controls.Add(this.Question_file_name_label);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Assignment_type_label);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create_Button);
            this.Name = "Teacher_Create_Assignment";
            this.Size = new System.Drawing.Size(934, 380);
            this.Load += new System.EventHandler(this.Teacher_Create_Assignment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label Assignment_type_label;
        private System.Windows.Forms.Label Description_label;
        private System.Windows.Forms.Label Question_file_name_label;
        private System.Windows.Forms.RadioButton Choose_assignment_quest;
        private System.Windows.Forms.RadioButton Choose_assignment_hw;
        private System.Windows.Forms.RadioButton choose_assignment_project;
        private System.Windows.Forms.RadioButton choose_assignment_quiz;
        private System.Windows.Forms.RadioButton choose_assignment_test;
        private System.Windows.Forms.TextBox Skills_add_skill_text;
        private System.Windows.Forms.Button add_skill_button;
        private System.Windows.Forms.RichTextBox Description_TextBox;
        private System.Windows.Forms.Button Import_Question_Bank;
        private System.Windows.Forms.TextBox Assignment_Title_TextBox;
        private System.Windows.Forms.Button remove_skill_button;
        private System.Windows.Forms.OpenFileDialog openQuestionFileDialog;
        private System.Windows.Forms.Label Error_Label;
        private System.Windows.Forms.Button Information_Button;
        private System.Windows.Forms.Label Information_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
