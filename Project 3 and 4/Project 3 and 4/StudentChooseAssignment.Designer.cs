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
            this.nov17AssignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project34DatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Project3_4DatabaseDataSet = new Project_3_and_4._Project3_4DatabaseDataSet();
            this.nov17_AssignmentsTableAdapter = new Project_3_and_4._Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            this.nov17AssignmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chooseAssignmentLabel = new System.Windows.Forms.Label();
            this.skillsLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project34DatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project3_4DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.nov17AssignmentsBindingSource1;
            this.listBox1.DisplayMember = "Assignment Title";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(40, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(453, 604);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "Assignment Title";
            // 
            // nov17AssignmentsBindingSource
            // 
            this.nov17AssignmentsBindingSource.DataMember = "Nov17_Assignments";
            this.nov17AssignmentsBindingSource.DataSource = this.project34DatabaseDataSetBindingSource;
            // 
            // project34DatabaseDataSetBindingSource
            // 
            this.project34DatabaseDataSetBindingSource.DataSource = this._Project3_4DatabaseDataSet;
            this.project34DatabaseDataSetBindingSource.Position = 0;
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
            // nov17AssignmentsBindingSource1
            // 
            this.nov17AssignmentsBindingSource1.DataMember = "Nov17_Assignments";
            this.nov17AssignmentsBindingSource1.DataSource = this._Project3_4DatabaseDataSet;
            // 
            // chooseAssignmentLabel
            // 
            this.chooseAssignmentLabel.AutoSize = true;
            this.chooseAssignmentLabel.Location = new System.Drawing.Point(35, 36);
            this.chooseAssignmentLabel.Name = "chooseAssignmentLabel";
            this.chooseAssignmentLabel.Size = new System.Drawing.Size(208, 25);
            this.chooseAssignmentLabel.TabIndex = 2;
            this.chooseAssignmentLabel.Text = "Choose assignment:";
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.Location = new System.Drawing.Point(578, 85);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(69, 25);
            this.skillsLabel.TabIndex = 3;
            this.skillsLabel.Text = "Skills:";
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Location = new System.Drawing.Point(578, 145);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(181, 25);
            this.pointLabel.TabIndex = 4;
            this.pointLabel.Text = "Number of points:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(578, 209);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(126, 25);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(583, 257);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(489, 174);
            this.descriptionRichTextBox.TabIndex = 6;
            this.descriptionRichTextBox.Text = "";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(578, 475);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(104, 25);
            this.questionLabel.TabIndex = 7;
            this.questionLabel.Text = "Question:";
            // 
            // questionRichTextBox
            // 
            this.questionRichTextBox.Location = new System.Drawing.Point(583, 513);
            this.questionRichTextBox.Name = "questionRichTextBox";
            this.questionRichTextBox.Size = new System.Drawing.Size(489, 174);
            this.questionRichTextBox.TabIndex = 8;
            this.questionRichTextBox.Text = "";
            // 
            // StudentChooseAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionRichTextBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.skillsLabel);
            this.Controls.Add(this.chooseAssignmentLabel);
            this.Controls.Add(this.listBox1);
            this.Name = "StudentChooseAssignment";
            this.Size = new System.Drawing.Size(1868, 731);
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project34DatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project3_4DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource nov17AssignmentsBindingSource;
        private System.Windows.Forms.BindingSource project34DatabaseDataSetBindingSource;
        private _Project3_4DatabaseDataSet _Project3_4DatabaseDataSet;
        private _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter nov17_AssignmentsTableAdapter;
        private System.Windows.Forms.BindingSource nov17AssignmentsBindingSource1;
        private System.Windows.Forms.Label chooseAssignmentLabel;
        private System.Windows.Forms.Label skillsLabel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RichTextBox questionRichTextBox;
    }
}
