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
        _Project3_4DatabaseDataSetTableAdapters.Nov17_GroupsTableAdapter group_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_Student_GroupsTableAdapter student_Group_Adapter;
        DataTable students_Table;
        DataTable student_Levels_Table;
        DataTable group_Table;
        DataTable student_Group_Table;
        int student_ID;

        public StudentForm()
        {
            InitializeComponent();
            Group();
        }

        public void Student_Load(int student_ID_Load) {
            student_ID = student_ID_Load;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new StudentChooseAssignment(student_ID);
            //myControl.Student_Load(student_ID);
            panel1.Controls.Add(myControl);
            Level();
            Group();
        }

        public void Group() {
            student_Group_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Student_GroupsTableAdapter();
            student_Group_Table = student_Group_Adapter.GetData();
            int group_ID = 0;
            string group_Name = "";
            for (int i = 0; i < student_Group_Table.Rows.Count; i++) {
                if (Convert.ToInt32(student_Group_Table.Rows[i][1]) == student_ID) {
                    group_ID = Convert.ToInt32(student_Group_Table.Rows[i][2]);
                }
            }
            group_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_GroupsTableAdapter();
            group_Table = group_Adapter.GetData();
            for (int i = 0; i < group_Table.Rows.Count; i++) {
                if (Convert.ToInt32(group_Table.Rows[i][0]) == group_ID) {
                    group_Name = Convert.ToString(group_Table.Rows[i][1]);
                }
            }
            if (group_Name.Equals(""))
            {
                Group_Label.Hide();
            }
            else {
                Group_Label.Show();
                Group_Label.Text = "Group: " + group_Name;
            }
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
            myControl.Student_Load(student_ID);
            panel1.Controls.Add(myControl);
            Level();
            Group();
        }

        private void Assignments_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new StudentChooseAssignment(student_ID);
            panel1.Controls.Add(myControl);
            Level();
            Group();
        }
    }
}
