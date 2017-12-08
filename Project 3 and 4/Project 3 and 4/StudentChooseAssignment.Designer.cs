namespace Project_3_and_4
{
    partial class StudentChooseAssignment
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nov17AssignmentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._Project3_4DatabaseDataSet = new Project_3_and_4._Project3_4DatabaseDataSet();
            this.nov17AssignmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nov17AssignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nov17_AssignmentsTableAdapter = new Project_3_and_4._Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            this.chooseAssignmentLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.project34DatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project3_4DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project34DatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "Assignment ID";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 44);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 316);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "Assignment ID";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nov17AssignmentsBindingSource2
            // 
            this.nov17AssignmentsBindingSource2.DataMember = "Nov17_Assignments";
            this.nov17AssignmentsBindingSource2.DataSource = this._Project3_4DatabaseDataSet;
            // 
            // _Project3_4DatabaseDataSet
            // 
            this._Project3_4DatabaseDataSet.DataSetName = "_Project3_4DatabaseDataSet";
            this._Project3_4DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nov17_AssignmentsTableAdapter
            // 
            this.nov17_AssignmentsTableAdapter.ClearBeforeFill = true;
            // 
            // chooseAssignmentLabel
            // 
            this.chooseAssignmentLabel.AutoSize = true;
            this.chooseAssignmentLabel.Location = new System.Drawing.Point(18, 19);
            this.chooseAssignmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseAssignmentLabel.Name = "chooseAssignmentLabel";
            this.chooseAssignmentLabel.Size = new System.Drawing.Size(102, 13);
            this.chooseAssignmentLabel.TabIndex = 2;
            this.chooseAssignmentLabel.Text = "Choose assignment:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(289, 44);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(289, 109);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(292, 134);
            this.descriptionRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(246, 123);
            this.descriptionRichTextBox.TabIndex = 6;
            this.descriptionRichTextBox.Text = "";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(456, 324);
            this.openButton.Margin = new System.Windows.Forms.Padding(2);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(80, 34);
            this.openButton.TabIndex = 9;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // project34DatabaseDataSetBindingSource
            // 
            this.project34DatabaseDataSetBindingSource.DataSource = this._Project3_4DatabaseDataSet;
            this.project34DatabaseDataSetBindingSource.Position = 0;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(289, 77);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 10;
            this.typeLabel.Text = "Type:";
            // 
            // StudentChooseAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.chooseAssignmentLabel);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentChooseAssignment";
            this.Size = new System.Drawing.Size(934, 380);
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project3_4DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project34DatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource nov17AssignmentsBindingSource;
        private _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter nov17_AssignmentsTableAdapter;
        private System.Windows.Forms.BindingSource nov17AssignmentsBindingSource1;
        private System.Windows.Forms.Label chooseAssignmentLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.BindingSource nov17AssignmentsBindingSource2;
        private _Project3_4DatabaseDataSet _Project3_4DatabaseDataSet;
        private System.Windows.Forms.BindingSource project34DatabaseDataSetBindingSource;
        private System.Windows.Forms.Label typeLabel;
    }
}
