using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_3_and_4;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_and_4.Tests
{
    [TestClass()]
    public class Report_AssignmentsTests
    {
        Report_Assignments control;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter assignment_Adapters;
        _Project3_4DatabaseDataSetTableAdapters.Nov18_TeachersTableAdapter teacher_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_Assignment_TypesTableAdapter assignments_Types_Adapter;

        DataTable assignments_Table;
        DataTable teacher_Table;
        DataTable assignments_Types_Table;

        [TestMethod()]
        public void Remove_Button_ClickTest()
        {
            control = new Report_Assignments();
            string given_Title = "Test Title";
            string given_Description = "Test Description";
            int given_Teacher = add_Teacher();
            int given_Type = 0;
            assignments_Types_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Assignment_TypesTableAdapter();
            assignments_Types_Table = assignments_Types_Adapter.GetData();
            for (int i = 0; i < assignments_Types_Table.Rows.Count; i++)
            {
                if (Convert.ToString(assignments_Types_Table.Rows[i][1]).Equals("PROJECT"))
                {
                    given_Type = Convert.ToInt32(assignments_Types_Table.Rows[i][0]);
                }
            }
            assignment_Adapters = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            assignment_Adapters.InsertQuery(given_Title, given_Description, given_Type, given_Teacher);
            control.Column_One_List.Items.Add(given_Title);
            control.Column_One_List.SetItemCheckState(0, System.Windows.Forms.CheckState.Checked);
            control.Remove_Button_Click(null, null);
            assignment_Adapters = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            assignments_Table = assignment_Adapters.GetData();
            int last_Assignment = assignments_Table.Rows.Count - 1;
            string assignment_Title = Convert.ToString(assignments_Table.Rows[last_Assignment][0]);
            Assert.AreNotEqual(given_Title, assignment_Title);
            delete_Teacher(given_Teacher);
        }

        private int add_Teacher()
        {
            teacher_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_TeachersTableAdapter();
            teacher_Adapter.InsertQuery("First", "Last");
            teacher_Table = teacher_Adapter.GetData();
            int last_Teacher = teacher_Table.Rows.Count - 1;
            int teacher_ID = Convert.ToInt32(teacher_Table.Rows[last_Teacher][0]);
            return teacher_ID;
        }

        private void delete_Teacher(int teacher_ID)
        {
            teacher_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_TeachersTableAdapter();
            teacher_Adapter.DeleteQuery(teacher_ID);
        }
    }
}