namespace Project_3_and_4
{
    partial class TeacherForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Create = new System.Windows.Forms.Button();
            this.Student_Report = new System.Windows.Forms.Button();
            this.Assignments = new System.Windows.Forms.Button();
            this.Skills = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1868, 731);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(20, 19);
            this.Create.Margin = new System.Windows.Forms.Padding(6);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(450, 125);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Student_Report
            // 
            this.Student_Report.Location = new System.Drawing.Point(480, 19);
            this.Student_Report.Margin = new System.Windows.Forms.Padding(6);
            this.Student_Report.Name = "Student_Report";
            this.Student_Report.Size = new System.Drawing.Size(450, 125);
            this.Student_Report.TabIndex = 2;
            this.Student_Report.Text = "Student Report";
            this.Student_Report.UseVisualStyleBackColor = true;
            // 
            // Assignments
            // 
            this.Assignments.Location = new System.Drawing.Point(940, 19);
            this.Assignments.Margin = new System.Windows.Forms.Padding(6);
            this.Assignments.Name = "Assignments";
            this.Assignments.Size = new System.Drawing.Size(450, 67);
            this.Assignments.TabIndex = 3;
            this.Assignments.Text = "Assignments";
            this.Assignments.UseVisualStyleBackColor = true;
            this.Assignments.Click += new System.EventHandler(this.Assignments_Click);
            // 
            // Skills
            // 
            this.Skills.Location = new System.Drawing.Point(940, 77);
            this.Skills.Margin = new System.Windows.Forms.Padding(6);
            this.Skills.Name = "Skills";
            this.Skills.Size = new System.Drawing.Size(450, 67);
            this.Skills.TabIndex = 4;
            this.Skills.Text = "Skills";
            this.Skills.UseVisualStyleBackColor = true;
            this.Skills.Click += new System.EventHandler(this.Skills_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(1400, 77);
            this.Logout.Margin = new System.Windows.Forms.Padding(6);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(450, 67);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(1400, 29);
            this.Username.Margin = new System.Windows.Forms.Padding(6);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(446, 31);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username_Placeholder";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 887);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Skills);
            this.Controls.Add(this.Assignments);
            this.Controls.Add(this.Student_Report);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Student_Report;
        private System.Windows.Forms.Button Assignments;
        private System.Windows.Forms.Button Skills;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.TextBox Username;
    }
}

