using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3_and_4
{
    public partial class StudentForm : Form
    {
        _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter students_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov25_Student_LevelsTableAdapter student_Levels_Adapter;
        DataTable students_Table;
        DataTable student_Levels_Table;
        int student_ID;//Change

        public StudentForm()
        {
            InitializeComponent();
        }

        public void Play_Assignment() {
            panel1.Controls.Clear();
            var myControl = new Student_Play_Assignments();
            panel1.Controls.Add(myControl);
            Level();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new StudentChooseAssignment();
            panel1.Controls.Add(myControl);
            student_ID = 1;//Change
            Level();
        }

        private void Level() {
            students_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter();
            student_Levels_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_Student_LevelsTableAdapter();
            students_Table = students_Adapter.GetData();
            student_Levels_Table = student_Levels_Adapter.GetData();
            Level_ProgressBar.Value = 0;
            for (int i = 0; i < students_Table.Rows.Count; i++)
            {
                int current_ID = Convert.ToInt32(students_Table.Rows[i][0]);
                if (current_ID == student_ID)
                {
                    int level_ID = Convert.ToInt32(students_Table.Rows[i][3]);
                    Level_ProgressBar.Minimum = 0;
                    for (int j = 0; j < student_Levels_Table.Rows.Count; j++)
                    {
                        if (level_ID == Convert.ToInt32(student_Levels_Table.Rows[j][0]))
                        {
                            Level_Label.Text = "Level: " + Convert.ToString(student_Levels_Table.Rows[j][1]);
                            int level_Difference = 0;
                            if (j != student_Levels_Table.Rows.Count - 1)
                            {
                                level_Difference = Convert.ToInt32(student_Levels_Table.Rows[j + 1][2]) - Convert.ToInt32(student_Levels_Table.Rows[j][2]);
                            }
                            else
                            {
                                Level_ProgressBar.Hide();
                            }
                            Level_ProgressBar.Maximum = level_Difference;
                        }
                    }
                    int level_Progress = Convert.ToInt32(students_Table.Rows[i][4]);
                    Level_ProgressBar.Value = level_Progress;
                }
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Group_Button_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new Student_Group();
            panel1.Controls.Add(myControl);
            Level();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new Student_Play_Assignments();
            panel1.Controls.Add(myControl);
            Level();
        }
    }
}
