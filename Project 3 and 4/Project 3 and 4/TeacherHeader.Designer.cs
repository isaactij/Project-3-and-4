namespace Project_3_and_4
{
    partial class TeacherHeader
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
            this.Username = new System.Windows.Forms.TextBox();
            this.Logout = new System.Windows.Forms.Button();
            this.Skills = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Assignments = new System.Windows.Forms.Button();
            this.Student_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(1399, 17);
            this.Username.Margin = new System.Windows.Forms.Padding(6);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(446, 31);
            this.Username.TabIndex = 12;
            this.Username.Text = "Username_Placeholder";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(1399, 65);
            this.Logout.Margin = new System.Windows.Forms.Padding(6);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(450, 67);
            this.Logout.TabIndex = 11;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // Skills
            // 
            this.Skills.Location = new System.Drawing.Point(939, 65);
            this.Skills.Margin = new System.Windows.Forms.Padding(6);
            this.Skills.Name = "Skills";
            this.Skills.Size = new System.Drawing.Size(450, 67);
            this.Skills.TabIndex = 10;
            this.Skills.Text = "Skills";
            this.Skills.UseVisualStyleBackColor = true;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(19, 7);
            this.Create.Margin = new System.Windows.Forms.Padding(6);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(450, 125);
            this.Create.TabIndex = 7;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Assignments
            // 
            this.Assignments.Location = new System.Drawing.Point(939, 7);
            this.Assignments.Margin = new System.Windows.Forms.Padding(6);
            this.Assignments.Name = "Assignments";
            this.Assignments.Size = new System.Drawing.Size(450, 67);
            this.Assignments.TabIndex = 9;
            this.Assignments.Text = "Assignments";
            this.Assignments.UseVisualStyleBackColor = true;
            // 
            // Student_Report
            // 
            this.Student_Report.Location = new System.Drawing.Point(479, 7);
            this.Student_Report.Margin = new System.Windows.Forms.Padding(6);
            this.Student_Report.Name = "Student_Report";
            this.Student_Report.Size = new System.Drawing.Size(450, 125);
            this.Student_Report.TabIndex = 8;
            this.Student_Report.Text = "Student Report";
            this.Student_Report.UseVisualStyleBackColor = true;
            // 
            // TeacherHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Skills);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Assignments);
            this.Controls.Add(this.Student_Report);
            this.Name = "TeacherHeader";
            this.Size = new System.Drawing.Size(1868, 139);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Skills;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Assignments;
        private System.Windows.Forms.Button Student_Report;
    }
}
