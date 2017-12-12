namespace Project_3_and_4
{
    partial class Student_Group
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
            this.Groups_Checkbox = new System.Windows.Forms.CheckedListBox();
            this.Groups_Label = new System.Windows.Forms.Label();
            this.Groups_Addgroup_Textbox = new System.Windows.Forms.TextBox();
            this.Groups_addGroup_Button = new System.Windows.Forms.Button();
            this.Error_Label = new System.Windows.Forms.Label();
            this.Groups_Accept_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Groups_Checkbox
            // 
            this.Groups_Checkbox.FormattingEnabled = true;
            this.Groups_Checkbox.Location = new System.Drawing.Point(30, 57);
            this.Groups_Checkbox.Name = "Groups_Checkbox";
            this.Groups_Checkbox.Size = new System.Drawing.Size(120, 94);
            this.Groups_Checkbox.TabIndex = 0;
            this.Groups_Checkbox.SelectedIndexChanged += new System.EventHandler(this.Groups_Checkbox_SelectedIndexChanged);
            // 
            // Groups_Label
            // 
            this.Groups_Label.AutoSize = true;
            this.Groups_Label.Location = new System.Drawing.Point(30, 38);
            this.Groups_Label.Name = "Groups_Label";
            this.Groups_Label.Size = new System.Drawing.Size(41, 13);
            this.Groups_Label.TabIndex = 1;
            this.Groups_Label.Text = "Groups";
            // 
            // Groups_Addgroup_Textbox
            // 
            this.Groups_Addgroup_Textbox.Location = new System.Drawing.Point(177, 57);
            this.Groups_Addgroup_Textbox.Name = "Groups_Addgroup_Textbox";
            this.Groups_Addgroup_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Groups_Addgroup_Textbox.TabIndex = 2;
            // 
            // Groups_addGroup_Button
            // 
            this.Groups_addGroup_Button.Location = new System.Drawing.Point(177, 93);
            this.Groups_addGroup_Button.Name = "Groups_addGroup_Button";
            this.Groups_addGroup_Button.Size = new System.Drawing.Size(75, 23);
            this.Groups_addGroup_Button.TabIndex = 3;
            this.Groups_addGroup_Button.Text = "Add Group";
            this.Groups_addGroup_Button.UseVisualStyleBackColor = true;
            this.Groups_addGroup_Button.Click += new System.EventHandler(this.Groups_addGroup_Button_Click);
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.Location = new System.Drawing.Point(30, 172);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(77, 13);
            this.Error_Label.TabIndex = 4;
            this.Error_Label.Text = "Validation Text";
            // 
            // Groups_Accept_Button
            // 
            this.Groups_Accept_Button.Location = new System.Drawing.Point(234, 289);
            this.Groups_Accept_Button.Name = "Groups_Accept_Button";
            this.Groups_Accept_Button.Size = new System.Drawing.Size(75, 23);
            this.Groups_Accept_Button.TabIndex = 5;
            this.Groups_Accept_Button.Text = "Accept";
            this.Groups_Accept_Button.UseVisualStyleBackColor = true;
            this.Groups_Accept_Button.Click += new System.EventHandler(this.Groups_Accept_Button_Click);
            // 
            // Student_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Groups_Accept_Button);
            this.Controls.Add(this.Error_Label);
            this.Controls.Add(this.Groups_addGroup_Button);
            this.Controls.Add(this.Groups_Addgroup_Textbox);
            this.Controls.Add(this.Groups_Label);
            this.Controls.Add(this.Groups_Checkbox);
            this.Name = "Student_Group";
            this.Size = new System.Drawing.Size(934, 380);
            this.Load += new System.EventHandler(this.Student_Group_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Groups_Checkbox;
        private System.Windows.Forms.Label Groups_Label;
        private System.Windows.Forms.TextBox Groups_Addgroup_Textbox;
        private System.Windows.Forms.Button Groups_addGroup_Button;
        private System.Windows.Forms.Label Error_Label;
        private System.Windows.Forms.Button Groups_Accept_Button;
    }
}
