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
            this.SuspendLayout();
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(58, 100);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(75, 23);
            this.Create_Button.TabIndex = 0;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseVisualStyleBackColor = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Teacher_Create_Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Create_Button);
            this.Name = "Teacher_Create_Assignment";
            this.Load += new System.EventHandler(this.Teacher_Create_Assignment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Create_Button;
    }
}
