namespace Project_3_and_4
{
    partial class LoginForm
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
            this.Login_username_label = new System.Windows.Forms.Label();
            this.Login_password_label = new System.Windows.Forms.Label();
            this.Login_username_textbox = new System.Windows.Forms.TextBox();
            this.Login_password_textbox = new System.Windows.Forms.TextBox();
            this.Login_login_button = new System.Windows.Forms.Button();
            this.Login_error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_username_label
            // 
            this.Login_username_label.AutoSize = true;
            this.Login_username_label.Location = new System.Drawing.Point(23, 57);
            this.Login_username_label.Name = "Login_username_label";
            this.Login_username_label.Size = new System.Drawing.Size(55, 13);
            this.Login_username_label.TabIndex = 0;
            this.Login_username_label.Text = "Username";
            // 
            // Login_password_label
            // 
            this.Login_password_label.AutoSize = true;
            this.Login_password_label.Location = new System.Drawing.Point(23, 101);
            this.Login_password_label.Name = "Login_password_label";
            this.Login_password_label.Size = new System.Drawing.Size(53, 13);
            this.Login_password_label.TabIndex = 1;
            this.Login_password_label.Text = "Password";
            // 
            // Login_username_textbox
            // 
            this.Login_username_textbox.Location = new System.Drawing.Point(26, 73);
            this.Login_username_textbox.Name = "Login_username_textbox";
            this.Login_username_textbox.Size = new System.Drawing.Size(175, 20);
            this.Login_username_textbox.TabIndex = 2;
            // 
            // Login_password_textbox
            // 
            this.Login_password_textbox.Location = new System.Drawing.Point(26, 117);
            this.Login_password_textbox.Name = "Login_password_textbox";
            this.Login_password_textbox.Size = new System.Drawing.Size(175, 20);
            this.Login_password_textbox.TabIndex = 3;
            // 
            // Login_login_button
            // 
            this.Login_login_button.Location = new System.Drawing.Point(26, 186);
            this.Login_login_button.Name = "Login_login_button";
            this.Login_login_button.Size = new System.Drawing.Size(75, 23);
            this.Login_login_button.TabIndex = 4;
            this.Login_login_button.Text = "Login";
            this.Login_login_button.UseVisualStyleBackColor = true;
            this.Login_login_button.Click += new System.EventHandler(this.Login_login_button_Click);
            // 
            // Login_error_label
            // 
            this.Login_error_label.AutoSize = true;
            this.Login_error_label.Location = new System.Drawing.Point(28, 152);
            this.Login_error_label.Name = "Login_error_label";
            this.Login_error_label.Size = new System.Drawing.Size(0, 13);
            this.Login_error_label.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Login_error_label);
            this.Controls.Add(this.Login_login_button);
            this.Controls.Add(this.Login_password_textbox);
            this.Controls.Add(this.Login_username_textbox);
            this.Controls.Add(this.Login_password_label);
            this.Controls.Add(this.Login_username_label);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button teacherButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Label Login_username_label;
        private System.Windows.Forms.Label Login_password_label;
        private System.Windows.Forms.TextBox Login_username_textbox;
        private System.Windows.Forms.TextBox Login_password_textbox;
        private System.Windows.Forms.Button Login_login_button;
        private System.Windows.Forms.Label Login_error_label;
    }
}