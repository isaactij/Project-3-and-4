namespace Project_3_and_4
{
    partial class Report_Skills
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Column_Two_List = new System.Windows.Forms.ListBox();
            this.Column_One_List = new System.Windows.Forms.ListBox();
            this.Column_One_Label = new System.Windows.Forms.Label();
            this.Page_Title_Label = new System.Windows.Forms.Label();
            this.Column_Four_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Column_Two_List, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Column_One_List, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Column_One_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Column_Four_Label, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 361);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Column_Two_List
            // 
            this.Column_Two_List.FormattingEnabled = true;
            this.Column_Two_List.Location = new System.Drawing.Point(193, 23);
            this.Column_Two_List.Name = "Column_Two_List";
            this.Column_Two_List.Size = new System.Drawing.Size(184, 329);
            this.Column_Two_List.TabIndex = 1;
            // 
            // Column_One_List
            // 
            this.Column_One_List.FormattingEnabled = true;
            this.Column_One_List.Location = new System.Drawing.Point(3, 23);
            this.Column_One_List.Name = "Column_One_List";
            this.Column_One_List.Size = new System.Drawing.Size(184, 329);
            this.Column_One_List.TabIndex = 0;
            // 
            // Column_One_Label
            // 
            this.Column_One_Label.AutoSize = true;
            this.Column_One_Label.Location = new System.Drawing.Point(3, 0);
            this.Column_One_Label.Name = "Column_One_Label";
            this.Column_One_Label.Size = new System.Drawing.Size(49, 13);
            this.Column_One_Label.TabIndex = 4;
            this.Column_One_Label.Text = "Skill Title";
            // 
            // Page_Title_Label
            // 
            this.Page_Title_Label.AutoSize = true;
            this.Page_Title_Label.Location = new System.Drawing.Point(-3, 0);
            this.Page_Title_Label.Name = "Page_Title_Label";
            this.Page_Title_Label.Size = new System.Drawing.Size(66, 13);
            this.Page_Title_Label.TabIndex = 2;
            this.Page_Title_Label.Text = "Skills Report";
            // 
            // Column_Four_Label
            // 
            this.Column_Four_Label.AutoSize = true;
            this.Column_Four_Label.Location = new System.Drawing.Point(193, 0);
            this.Column_Four_Label.Name = "Column_Four_Label";
            this.Column_Four_Label.Size = new System.Drawing.Size(79, 13);
            this.Column_Four_Label.TabIndex = 7;
            this.Column_Four_Label.Text = "Average Grade";
            // 
            // Report_Skills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Page_Title_Label);
            this.Name = "Report_Skills";
            this.Size = new System.Drawing.Size(380, 410);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox Column_Two_List;
        private System.Windows.Forms.ListBox Column_One_List;
        private System.Windows.Forms.Label Column_One_Label;
        private System.Windows.Forms.Label Page_Title_Label;
        private System.Windows.Forms.Label Column_Four_Label;
    }
}
