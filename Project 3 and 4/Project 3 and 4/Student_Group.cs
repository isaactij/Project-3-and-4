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
        public Student_Group()
        {
            InitializeComponent();
        }

        private void Groups_addGroup_Button_Click(object sender, EventArgs e)
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

        private void Groups_Accept_Button_Click(object sender, EventArgs e)
        {
            _Project3_4DatabaseDataSetTableAdapters.Nov17_Student_GroupsTableAdapter studentGroupsAdapter;
            studentGroupsAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Student_GroupsTableAdapter();
            DataTable studentGroupsTable = studentGroupsAdapter.GetData();

            _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter studentsAdapter;
            studentsAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter();
            DataTable studentsTable = studentsAdapter.GetData();
            // dont know why we go to the last row
            int lastRow = studentsTable.Rows.Count - 1;
            int studentID = Convert.ToInt32(studentsTable.Rows[lastRow][0]);

            _Project3_4DatabaseDataSetTableAdapters.Nov17_GroupsTableAdapter groupsAdapter;
            groupsAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_GroupsTableAdapter();
            DataTable groupsTable = groupsAdapter.GetData();
            for (int i = 0; i < Groups_Checkbox.Items.Count; i++)
            {
                if (Groups_Checkbox.GetItemChecked(i))
                {
                    for (int j = 0; j < groupsTable.Rows.Count; j++)
                    {
                        if (groupsTable.Rows[j][1].Equals(Groups_Checkbox.Items[i]))
                        {
                            int groupID = Convert.ToInt32(groupsTable.Rows[j][0]);
                            studentGroupsAdapter.InsertQuery(studentID, groupID);
                        }
                    }
                }
            }
        }

        private void Student_Group_Load(object sender, EventArgs e)
        {
            refreshGroupsList();
        }
    }

    
}
