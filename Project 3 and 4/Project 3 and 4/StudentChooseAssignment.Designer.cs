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
            this.nov17AssignmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nov17AssignmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nov17_AssignmentsTableAdapter = new Project_3_and_4._Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            this.chooseAssignmentLabel = new System.Windows.Forms.Label();
            this.skillsLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.difficultyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource)).BeginInit();
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
            // nov17_AssignmentsTableAdapter
            // 
            this.nov17_AssignmentsTableAdapter.ClearBeforeFill = true;
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
            this.pointLabel.Location = new System.Drawing.Point(578, 119);
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
            this.descriptionRichTextBox.Size = new System.Drawing.Size(489, 232);
            this.descriptionRichTextBox.TabIndex = 6;
            this.descriptionRichTextBox.Text = "";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(912, 624);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(160, 65);
            this.openButton.TabIndex = 9;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(578, 165);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(100, 25);
            this.difficultyLabel.TabIndex = 10;
            this.difficultyLabel.Text = "Difficulty:";
            // 
            // StudentChooseAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.skillsLabel);
            this.Controls.Add(this.chooseAssignmentLabel);
            this.Controls.Add(this.listBox1);
            this.Name = "StudentChooseAssignment";
            this.Size = new System.Drawing.Size(1868, 731);
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nov17AssignmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource nov17AssignmentsBindingSource;
        private _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter nov17_AssignmentsTableAdapter;
        private System.Windows.Forms.BindingSource nov17AssignmentsBindingSource1;
        private System.Windows.Forms.Label chooseAssignmentLabel;
        private System.Windows.Forms.Label skillsLabel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label difficultyLabel;
    }
}
