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
    public partial class Report_Skills : UserControl
    {
        _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter skills_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_Skills_In_AssignmentsTableAdapter skills_In_Assignments_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter assignment_Grade_Adapter;
        public static DataTable skills_Table;
        public static DataTable skills_Int_Assignments_Table;
        public static DataTable assignment_Grade_Table;

        public Report_Skills()
        {
            InitializeComponent();
        }

        private void Report_Skills_Load(object sender, EventArgs e)
        {
            skills_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            skills_Table = skills_Adapter.GetData();
            skills_In_Assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Skills_In_AssignmentsTableAdapter();
            skills_Int_Assignments_Table = skills_In_Assignments_Adapter.GetData();
            assignment_Grade_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter();
            assignment_Grade_Table = assignment_Grade_Adapter.GetData();
            Fill_Columns();
        }
        private void Column_One_List_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Column_Two_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Fill_Columns()
        {
            int count = skills_Table.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                int assignments_Added = 0;
                double total_Grade = 0;
                Column_One_List.Items.Add(skills_Table.Rows[i][1]);
                int skill_ID = Convert.ToInt32(skills_Table.Rows[i][0]);
                for (int j = 0; j < skills_Int_Assignments_Table.Rows.Count; j++) {
                    if (Convert.ToInt32(skills_Int_Assignments_Table.Rows[j][2]) == skill_ID) {
                        int assignment_ID = Convert.ToInt32(skills_Int_Assignments_Table.Rows[j][1]);
                        for (int k = 0; k < assignment_Grade_Table.Rows.Count; k++) {
                            if (assignment_ID == Convert.ToInt32(assignment_Grade_Table.Rows[k][2])) {
                                assignments_Added++;
                                total_Grade += Convert.ToDouble(assignment_Grade_Table.Rows[k][3]);
                            }
                        }
                    }
                }
                double average = total_Grade;
                if (assignments_Added > 0) {
                    average = average / assignments_Added;
                }
                Column_Two_List.Items.Add(average);
            }
        }
    }

}
