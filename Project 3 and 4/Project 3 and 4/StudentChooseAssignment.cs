using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3_and_4
{
    public partial class StudentChooseAssignment : UserControl
    {
        int studentId = 1; // Change this to the real ID.
        int teacherId = 1; // Change this to the real ID.
        public StudentChooseAssignment()
        {
            InitializeComponent();
            titleLabel.Text = "Title: ";
            typeLabel.Text = "Type: ";
            descriptionRichTextBox.Clear();
            openButton.Enabled = false;

            // Load assignments
            listBox1.Items.Clear();
            _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter assignmentsTableAdapter;
            assignmentsTableAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            DataTable assignmentsTable = assignmentsTableAdapter.GetData();
            for (int i = 0; i < assignmentsTable.Rows.Count; i++)
            {
                if (Convert.ToInt32(assignmentsTable.Rows[i][4]) == teacherId)
                {
                    ListViewItem dataItem = new ListViewItem();
                    dataItem.Text = Convert.ToString(assignmentsTable.Rows[i][1]);
                    dataItem.Tag = Convert.ToString(assignmentsTable.Rows[i][0]);
                    listBox1.Items.Add(dataItem);
                }
            }
            listBox1.DisplayMember = "Text";
            listBox1.ValueMember = "Tag";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter assignmentsTableAdapter;
            assignmentsTableAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            DataTable assignmentsTable = assignmentsTableAdapter.GetData();
            ListViewItem selectedListItem = (ListViewItem)listBox1.SelectedItem;
            int assignmentId = Convert.ToInt32(selectedListItem.Tag);
            titleLabel.Text = "Title: ";
            typeLabel.Text = "Type: ";
            descriptionRichTextBox.Clear();
            openButton.Enabled = false;

            for (int i = 0; i < assignmentsTable.Rows.Count; i++)
            {
                if (Convert.ToInt32(assignmentsTable.Rows[i][0]) == assignmentId)
                {
                    titleLabel.Text += assignmentsTable.Rows[i][1];
                    descriptionRichTextBox.Text = Convert.ToString(assignmentsTable.Rows[i][2]);
                    int typeId = Convert.ToInt32(assignmentsTable.Rows[i][3]);

                    // get type
                    _Project3_4DatabaseDataSetTableAdapters.Nov17_Assignment_TypesTableAdapter assignmentsTypeTableAdapter;
                    assignmentsTypeTableAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Assignment_TypesTableAdapter();
                    DataTable assignmentsTypeTable = assignmentsTypeTableAdapter.GetData();
                    for (int j = 0; j < assignmentsTypeTable.Rows.Count; j++)
                    {
                        if (Convert.ToInt32(assignmentsTypeTable.Rows[j][0]) == typeId)
                        {
                            typeLabel.Text += Convert.ToString(assignmentsTypeTable.Rows[j][1]);
                            break;
                        }
                    }

                    // check if they did it or not
                    _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter assignmentsGradeTableAdapter;
                    assignmentsGradeTableAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter();
                    DataTable assignmentsGradeTable = assignmentsGradeTableAdapter.GetData();
                    Boolean canOpen = true;
                    for (int j = 0; j < assignmentsGradeTable.Rows.Count; j++)
                    {
                        if (Convert.ToInt32(assignmentsGradeTable.Rows[j][1]) == studentId)
                        {
                            if (Convert.ToInt32(assignmentsGradeTable.Rows[j][2]) == assignmentId)
                            {
                                // disable open button if they did the assignemnt already
                                canOpen = false;
                            }
                        }
                    }
                    if (canOpen)
                    {
                        openButton.Enabled = true;
                    }
                    break;
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var myControl = new Student_Play_Assignments();
            myControl.Parent = this.Parent;
            this.Parent.Controls.Add(myControl);
            this.Parent.Controls.Remove(this);
        }
    }
}
