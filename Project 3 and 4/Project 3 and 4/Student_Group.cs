using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_3_and_4
{
    public partial class Student_Group : UserControl
    {
        int studentID;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_GroupsTableAdapter group_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_Student_GroupsTableAdapter student_Group_Adapter;

        DataTable group_Table;
        DataTable student_Group_Table;

        public Student_Group()
        {
            InitializeComponent();
        }

        public void Student_Load(int student_ID_Load)
        {
            studentID = student_ID_Load;
        }

        public void Groups_addGroup_Button_Click(object sender, EventArgs e)
        {
            if (Groups_Addgroup_Textbox.Text == "") return;
            Groups_Addgroup_Textbox.Text = Groups_Addgroup_Textbox.Text.ToUpper();
            _Project3_4DatabaseDataSetTableAdapters.Nov17_GroupsTableAdapter groupsAdapter;
            groupsAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_GroupsTableAdapter();
            DataTable groupsTable = groupsAdapter.GetData();
            int dup = 0;
            for (int i = 0; i < groupsTable.Rows.Count; i++)
            {
                String groupsName = Convert.ToString(groupsTable.Rows[i][1]); // adjust the row to whatever the group name is
                if (groupsName == Groups_Addgroup_Textbox.Text)
                {
                    dup = 1;
                    break;
                }
            }
            if (dup == 0)
            {
                groupsAdapter.InsertQuery(Groups_Addgroup_Textbox.Text); // what
            }
            else
            {
                 Error_Label.Text = "Duplicated skill.";
            }
            Groups_Addgroup_Textbox.Text = "";
            refreshGroupsList();
        }

        private void refreshGroupsList()
        {
            _Project3_4DatabaseDataSetTableAdapters.Nov17_GroupsTableAdapter groupsAdapter;
            groupsAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_GroupsTableAdapter();
            DataTable groupsTable = groupsAdapter.GetData();

            Groups_Checkbox.Items.Clear();
            for (int i = 0; i < groupsTable.Rows.Count; i++)
            {
                String groupsName = Convert.ToString(groupsTable.Rows[i][1]);
                Groups_Checkbox.Items.Add(groupsName);
            }
        }

        public void Groups_Accept_Button_Click(object sender, EventArgs e)
        {
            _Project3_4DatabaseDataSetTableAdapters.Nov17_Student_GroupsTableAdapter studentGroupsAdapter;
            studentGroupsAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Student_GroupsTableAdapter();
            DataTable studentGroupsTable = studentGroupsAdapter.GetData();

            _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter studentsAdapter;
            studentsAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter();
            DataTable studentsTable = studentsAdapter.GetData();

            _Project3_4DatabaseDataSetTableAdapters.Nov17_GroupsTableAdapter groupsAdapter;
            groupsAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_GroupsTableAdapter();
            DataTable groupsTable = groupsAdapter.GetData();

            // iterates through the checkbox
            for (int i = 0; i < Groups_Checkbox.Items.Count; i++)
            {
                if (Groups_Checkbox.GetItemChecked(i))
                {
                    // iterate through the groupsTable
                    for (int j = 0; j < groupsTable.Rows.Count; j++)
                    {
                        // comparing name in groupsTable to name in checkbox
                        if (groupsTable.Rows[j][1].Equals(Groups_Checkbox.Items[i]))
                        {
                            // new groupID
                            int newGroupID = Convert.ToInt32(groupsTable.Rows[j][0]);

                            bool inGroup = false;
                            // check if studentID is in the studentGroups
                            for (int k = 0; k < studentGroupsTable.Rows.Count; k++)
                            {
                                // if the student ID is in studentGroups
                                if (Convert.ToInt32(studentGroupsTable.Rows[k][1]).Equals(studentID))
                                {
                                    inGroup = true;
                                    // update the studentGroupID to the new group
                                    studentGroupsAdapter.UpdateQuery(studentID, newGroupID, 
                                        Convert.ToInt32(studentGroupsTable.Rows[k][0]),
                                        Convert.ToInt32(studentGroupsTable.Rows[k][0]), studentID, 
                                        Convert.ToInt32(studentGroupsTable.Rows[k][2]));
                                    break;
                                }

                            }
                            // if the student ID is not in studentGroups (student is not already in a group)
                            if(!inGroup)
                            {
                                studentGroupsAdapter.InsertQuery(studentID, newGroupID);
                            }
                            break;
                        }

                    }
                    break;
                }
            }
            StudentForm a = (StudentForm)this.Parent.Parent;
            a.Group();
        }

        private void Student_Group_Load(object sender, EventArgs e)
        {
            refreshGroupsList();
        }

        private void Groups_Checkbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int checked_Boxes = 0;
            for (int i = 0; i < Groups_Checkbox.Items.Count; i ++) {
                if (Groups_Checkbox.GetItemChecked(i)) {
                    checked_Boxes++;
                }
            }
            if (checked_Boxes > 1)
            {
                Groups_Accept_Button.Enabled = false;
                Error_Label.Text = "You must select exactly one group only.";
            }
            else
            {
                Groups_Accept_Button.Enabled = true;
                Error_Label.Text = "";
            }
        }
    }

    
}
