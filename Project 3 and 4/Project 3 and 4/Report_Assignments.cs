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
    public partial class Report_Assignments : UserControl
    {
        _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter assignments_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_Assignment_TypesTableAdapter assignment_Types_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter assignment_Grade_Adapter;
        public static DataTable assignments_Table;
        public static DataTable assignment_Types_Table;
        public static DataTable assignment_Grade;

        public Report_Assignments()
        {
            InitializeComponent();
        }

        private void Report_Assignments_Load(object sender, EventArgs e)
        {
            assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            assignments_Table = assignments_Adapter.GetData();
            assignment_Types_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Assignment_TypesTableAdapter();
            assignment_Types_Table = assignment_Types_Adapter.GetData();
            assignment_Grade_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter();
            assignment_Grade = assignment_Grade_Adapter.GetData();
            Fill_Columns();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Page_Title_Label_Click(object sender, EventArgs e)
        {
        }

        private void Column_One_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Column_Two_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Column_Three_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Column_Four_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Fill_Columns()
        {
            int count = assignments_Table.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                //ListBox Column_One_List = new ListBox();
                //ListBox Column_Two_List = new ListBox();
                //ListBox Column_Three_List = new ListBox();
                //sListBox Column_Four_List = new ListBox();
                Column_One_List.Items.Add(assignments_Table.Rows[i][1]);
                //Column_One_List.DisplayMember = Convert.ToString(assignments_Table.Rows[i][1]);
                int assignment_Type = Convert.ToInt32(assignments_Table.Rows[i][4]);
                int row_Position = 0;
                bool while_Continue = true;
                while (while_Continue)
                {
                    int row_Value = Convert.ToInt32(assignment_Types_Table.Rows[row_Position][0]);
                    if (row_Value == assignment_Type)
                    {
                        while_Continue = false;
                    }
                    else
                    {
                        row_Position++;
                    }
                }
                Column_Two_List.Items.Add(assignment_Types_Table.Rows[row_Position][1]);
                int grade_Table_Rows = assignment_Grade.Rows.Count;
                int rows_Counted = 0;
                int total_Grades = 0;
                int assignment_ID = Convert.ToInt32(assignments_Table.Rows[i][0]);
                for (int j = 0; j < grade_Table_Rows; j++)
                {
                    if (assignment_ID == Convert.ToInt32(assignment_Grade.Rows[j][2]))
                    {
                        rows_Counted++;
                        total_Grades += Convert.ToInt32(assignment_Grade.Rows[j][3]);
                    }
                }
                Column_Three_List.Items.Add(rows_Counted);
                int average_Grade = total_Grades;
                if (rows_Counted != 0)
                {
                    average_Grade = total_Grades / rows_Counted;
                }
                Column_Four_List.Items.Add(average_Grade);
            }
        }
    }
}

