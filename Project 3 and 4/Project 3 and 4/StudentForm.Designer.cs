namespace Project_3_and_4
{
    partial class StudentForm
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
            this.Username = new System.Windows.Forms.TextBox();
            this.Logout = new System.Windows.Forms.Button();
            this.Skills = new System.Windows.Forms.Button();
            this.Assignments = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Group_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(700, 10);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(225, 20);
            this.Username.TabIndex = 13;
            this.Username.Text = "Username_Placeholder";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(700, 35);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(225, 35);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Skills
            // 
            this.Skills.Location = new System.Drawing.Point(470, 35);
            this.Skills.Name = "Skills";
            this.Skills.Size = new System.Drawing.Size(225, 35);
            this.Skills.TabIndex = 11;
            this.Skills.Text = "Skills";
            this.Skills.UseVisualStyleBackColor = true;
            // 
            // Assignments
            // 
            this.Assignments.Location = new System.Drawing.Point(470, 5);
            this.Assignments.Name = "Assignments";
            this.Assignments.Size = new System.Drawing.Size(225, 35);
            this.Assignments.TabIndex = 10;
            this.Assignments.Text = "Assignments";
            this.Assignments.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 380);
            this.panel1.TabIndex = 7;
            // 
            // Group_Button
            // 
            this.Group_Button.Location = new System.Drawing.Point(239, 5);
            this.Group_Button.Name = "Group_Button";
            this.Group_Button.Size = new System.Drawing.Size(225, 35);
            this.Group_Button.TabIndex = 14;
            this.Group_Button.Text = "Groups";
            this.Group_Button.UseVisualStyleBackColor = true;
            this.Group_Button.Click += new System.EventHandler(this.Group_Button_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.Group_Button);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Skills);
            this.Controls.Add(this.Assignments);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Skills;
        private System.Windows.Forms.Button Assignments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Group_Button;
    }
}