namespace Project_3_and_4
{
    partial class Report_Assignments
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
            this.Page_Title_Label = new System.Windows.Forms.Label();
            this.Column_One_Label = new System.Windows.Forms.Label();
            this.Column_Four_Label = new System.Windows.Forms.Label();
            this.Column_Three_Label = new System.Windows.Forms.Label();
            this.Column_Two_Label = new System.Windows.Forms.Label();
            this.Column_Four_List = new System.Windows.Forms.ListBox();
            this.Column_Three_List = new System.Windows.Forms.ListBox();
            this.Column_Two_List = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Column_One_List = new System.Windows.Forms.CheckedListBox();
            this.Remove_Button = new System.Windows.Forms.Button();
            this._Project3_4DatabaseDataSet1 = new Project_3_and_4._Project3_4DatabaseDataSet();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Project3_4DatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Page_Title_Label
            // 
            this.Page_Title_Label.AutoSize = true;
            this.Page_Title_Label.Location = new System.Drawing.Point(13, 11);
            this.Page_Title_Label.Name = "Page_Title_Label";
            this.Page_Title_Label.Size = new System.Drawing.Size(101, 13);
            this.Page_Title_Label.TabIndex = 0;
            this.Page_Title_Label.Text = "Assignments Report";
            this.Page_Title_Label.Click += new System.EventHandler(this.Page_Title_Label_Click);
            // 
            // Column_One_Label
            // 
            this.Column_One_Label.AutoSize = true;
            this.Column_One_Label.Location = new System.Drawing.Point(3, 0);
            this.Column_One_Label.Name = "Column_One_Label";
            this.Column_One_Label.Size = new System.Drawing.Size(84, 13);
            this.Column_One_Label.TabIndex = 4;
            this.Column_One_Label.Text = "Assignment Title";
            // 
            // Column_Four_Label
            // 
            this.Column_Four_Label.AutoSize = true;
            this.Column_Four_Label.Location = new System.Drawing.Point(435, 0);
            this.Column_Four_Label.Name = "Column_Four_Label";
            this.Column_Four_Label.Size = new System.Drawing.Size(79, 13);
            this.Column_Four_Label.TabIndex = 7;
            this.Column_Four_Label.Text = "Average Grade";
            // 
            // Column_Three_Label
            // 
            this.Column_Three_Label.AutoSize = true;
            this.Column_Three_Label.Location = new System.Drawing.Point(291, 0);
            this.Column_Three_Label.Name = "Column_Three_Label";
            this.Column_Three_Label.Size = new System.Drawing.Size(71, 13);
            this.Column_Three_Label.TabIndex = 6;
            this.Column_Three_Label.Text = "# of Students";
            // 
            // Column_Two_Label
            // 
            this.Column_Two_Label.AutoSize = true;
            this.Column_Two_Label.Location = new System.Drawing.Point(147, 0);
            this.Column_Two_Label.Name = "Column_Two_Label";
            this.Column_Two_Label.Size = new System.Drawing.Size(31, 13);
            this.Column_Two_Label.TabIndex = 5;
            this.Column_Two_Label.Text = "Type";
            // 
            // Column_Four_List
            // 
            this.Column_Four_List.FormattingEnabled = true;
            this.Column_Four_List.Location = new System.Drawing.Point(435, 23);
            this.Column_Four_List.Name = "Column_Four_List";
            this.Column_Four_List.Size = new System.Drawing.Size(140, 290);
            this.Column_Four_List.TabIndex = 3;
            this.Column_Four_List.SelectedIndexChanged += new System.EventHandler(this.Column_Four_List_SelectedIndexChanged);
            // 
            // Column_Three_List
            // 
            this.Column_Three_List.FormattingEnabled = true;
            this.Column_Three_List.Location = new System.Drawing.Point(291, 23);
            this.Column_Three_List.Name = "Column_Three_List";
            this.Column_Three_List.Size = new System.Drawing.Size(138, 290);
            this.Column_Three_List.TabIndex = 2;
            this.Column_Three_List.SelectedIndexChanged += new System.EventHandler(this.Column_Three_List_SelectedIndexChanged);
            // 
            // Column_Two_List
            // 
            this.Column_Two_List.FormattingEnabled = true;
            this.Column_Two_List.Location = new System.Drawing.Point(147, 23);
            this.Column_Two_List.Name = "Column_Two_List";
            this.Column_Two_List.Size = new System.Drawing.Size(138, 290);
            this.Column_Two_List.TabIndex = 1;
            this.Column_Two_List.SelectedIndexChanged += new System.EventHandler(this.Column_Two_List_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Column_Two_List, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Column_Three_List, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Column_Four_List, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Column_Two_Label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Column_Three_Label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Column_Four_Label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Column_One_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Column_One_List, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(578, 328);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Column_One_List
            // 
            this.Column_One_List.FormattingEnabled = true;
            this.Column_One_List.Location = new System.Drawing.Point(3, 23);
            this.Column_One_List.Name = "Column_One_List";
            this.Column_One_List.Size = new System.Drawing.Size(138, 289);
            this.Column_One_List.TabIndex = 8;
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(500, 11);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Button.TabIndex = 2;
            this.Remove_Button.Text = "Remove";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // _Project3_4DatabaseDataSet1
            // 
            this._Project3_4DatabaseDataSet1.DataSetName = "_Project3_4DatabaseDataSet";
            this._Project3_4DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Report_Assignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Page_Title_Label);
            this.Name = "Report_Assignments";
            this.Size = new System.Drawing.Size(934, 380);
            this.Load += new System.EventHandler(this.Report_Assignments_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Project3_4DatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Page_Title_Label;
        private _Project3_4DatabaseDataSet _Project3_4DatabaseDataSet1;
        private System.Windows.Forms.Label Column_One_Label;
        private System.Windows.Forms.Label Column_Four_Label;
        private System.Windows.Forms.Label Column_Three_Label;
        private System.Windows.Forms.Label Column_Two_Label;
        private System.Windows.Forms.ListBox Column_Four_List;
        private System.Windows.Forms.ListBox Column_Three_List;
        private System.Windows.Forms.ListBox Column_Two_List;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox Column_One_List;
        private System.Windows.Forms.Button Remove_Button;
    }
}
