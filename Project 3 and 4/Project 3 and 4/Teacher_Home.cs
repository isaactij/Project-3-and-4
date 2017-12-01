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
    public partial class Teacher_Home : UserControl
    {
        _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter students_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov25_Student_LevelsTableAdapter student_Levels_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter assignment_Grades_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter assignments_Adapter;

        DataTable students_Table;
        DataTable student_Levels_Table;
        DataTable assignment_Grades_Table;
        DataTable assignments_Table;

        public Teacher_Home()
        {
            InitializeComponent();
        }

        private void Teacher_Home_Load(object sender, EventArgs e)
        {
            students_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter();
            students_Table = students_Adapter.GetData();
            student_Levels_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_Student_LevelsTableAdapter();
            student_Levels_Table = student_Levels_Adapter.GetData();
            assignment_Grades_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter();
            assignment_Grades_Table = assignment_Grades_Adapter.GetData();
            assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            assignments_Table = assignments_Adapter.GetData();
            for (int i = 0; i < students_Table.Rows.Count; i++)
            {
                string student_Name = Convert.ToString(students_Table.Rows[i][2]) + ", " + Convert.ToString(students_Table.Rows[i][1]);
                Students_listBox1.Items.Add(student_Name);
            }
            panel1.Hide();
        }

        private void Students_listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selected = Students_listBox1.SelectedItem.ToString();
            //if (selected.Equals(""))
            if(Students_listBox1.SelectedItem == null)
            {
                panel1.Hide();
            }
            else {
                panel1.Show();
                Fill_Panel();
            }
        }

        private void Fill_Panel() {
            Column_One_listBox.Items.Clear();
            Column_Two_listBox.Items.Clear();
            Level_ProgressBar.Value = 0;
            string name = Students_listBox1.SelectedItem.ToString();
            for (int i = 0; i < students_Table.Rows.Count; i++) {
                string current_Name = Convert.ToString(students_Table.Rows[i][2]) + ", " + Convert.ToString(students_Table.Rows[i][1]);
                if (current_Name.Equals(name)) {
                    int level_ID = Convert.ToInt32(students_Table.Rows[i][3]);
                    Level_ProgressBar.Minimum = 0;
                    for (int j = 0; j < student_Levels_Table.Rows.Count; j++) {
                        if (level_ID == Convert.ToInt32(student_Levels_Table.Rows[j][0])){
                            Level_Text.Text = Convert.ToString(student_Levels_Table.Rows[j][2]);
                            int level_Difference = Convert.ToInt32(student_Levels_Table.Rows[j + 1][1]) - Convert.ToInt32(student_Levels_Table.Rows[j][1]);
                            Level_ProgressBar.Maximum = level_Difference;
                        }
                    }
                    int level_Progress = Convert.ToInt32(students_Table.Rows[i][4]);
                    Level_ProgressBar.Value = level_Progress;
                    for (int j = 0; j < assignment_Grades_Table.Rows.Count; j++) {
                        if (Convert.ToInt32(assignment_Grades_Table.Rows[j][1]) == Convert.ToInt32(students_Table.Rows[i][0])) {
                            for (int k = 0; k < assignments_Table.Rows.Count; k++) {
                                if (Convert.ToString(assignments_Table.Rows[k][0]).Equals(Convert.ToString(assignment_Grades_Table.Rows[j][2]))) {
                                    Column_One_listBox.Items.Add(assignments_Table.Rows[k][1]);
                                }
                            }
                            Column_Two_listBox.Items.Add(assignment_Grades_Table.Rows[j][3]);
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
