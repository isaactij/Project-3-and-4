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
    public partial class Teacher_Create_Assignment : UserControl
    {
        public static string[] skills_List;
        bool errors = false;
        int teacher_ID;//Change later
        _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter assignments_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov25_Difficulty_LevelsTableAdapter difficulty_Levels_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter skills_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov25_QuestionsTableAdapter questions_Adapter;
        DataTable questions_Table;
        bool display_Information;
        string[,] questions;
        DataGridViewTextBoxColumn questions_Column;
        DataGridViewComboBoxColumn difficulties;
        DataGridViewComboBoxColumn skills;

        public Teacher_Create_Assignment()
        {
            InitializeComponent();
        }

        private void Teacher_Create_Assignment_Load(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("test");
            display_Information = false;
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            check_For_Errors();
            if (!errors)
            {
                Read_Questions_File();
                if (!errors)
                {
                    //Create_Assignment_File(questions, "list_Of_Assignments.txt");
                    Add_Assignment_To_Database();
                    //Add_Skills_In_Assginment_To_Database();
                }
            }

        }

        //public void Add_Skills_In_Assginment_To_Database()
        //{
        //    _Project3_4DatabaseDataSetTableAdapters.Nov17_Skills_In_AssignmentsTableAdapter skills_In_Assignments_Adapter;
        //    skills_In_Assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Skills_In_AssignmentsTableAdapter();
        //    assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
        //    DataTable assignments_Table = assignments_Adapter.GetData();
        //    int last_Row = assignments_Table.Rows.Count - 1;
        //    int assignment_ID = Convert.ToInt32(assignments_Table.Rows[last_Row][0]);
        //    _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter skills_Adapter;
        //    skills_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
        //    DataTable skills_Table = skills_Adapter.GetData();
        //    for (int i = 0; i < Skills_checkbox_list.Items.Count; i++)
        //    {
        //        if (Skills_checkbox_list.GetItemChecked(i))
        //        {
        //            for (int j = 0; j < skills_Table.Rows.Count; j++)
        //            {
        //                if (skills_Table.Rows[j][1].Equals(Skills_checkbox_list.Items[i]))
        //                {
        //                    int skills_ID = Convert.ToInt32(skills_Table.Rows[j][0]);
        //                    skills_In_Assignments_Adapter.InsertQuery(assignment_ID, skills_ID);
        //                }
        //            }
        //        }
        //    }

        //}

        public void Add_Assignment_To_Database()
        {
            teacher_ID = 1;
            assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            int type = 0;
            if (Choose_assignment_quest.Checked)
            {
                type = 18;
            }
            else if (Choose_assignment_hw.Checked)
            {
                type = 19;
            }
            else if (choose_assignment_project.Checked)
            {
                type = 20;
            }
            else if (choose_assignment_quiz.Checked)
            {
                type = 21;
            }
            else
            {
                type = 22;
            }
            assignments_Adapter.InsertQuery(Assignment_Title_TextBox.Text, Description_TextBox.Text, type, teacher_ID);
            assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            DataTable assignments_Table = assignments_Adapter.GetData();
            int num_Rows = assignments_Table.Rows.Count;
            int assignment_ID = Convert.ToInt32(assignments_Table.Rows[num_Rows - 1][0]);
            skills_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            DataTable skills_Table = skills_Adapter.GetData();
            difficulty_Levels_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_Difficulty_LevelsTableAdapter();
            DataTable difficulty_Levels_Table = difficulty_Levels_Adapter.GetData();
            int skill_ID = 0;
            int difficulty_Level_ID = 0;
            questions_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_QuestionsTableAdapter();
            questions_Table = questions_Adapter.GetData();
            for (int i = 0; i < questions.GetLength(0); i++)
            {
                if (questions[i, 0] != null)
                {
                    for (int j = 0; j < skills_Table.Rows.Count; j++)
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[1].Value).Equals(skills_Table.Rows[j][1]))
                        {
                            skill_ID = Convert.ToInt32(skills_Table.Rows[j][0]);
                        }
                    }
                    for (int j = 0; j < difficulty_Levels_Table.Rows.Count; j++)
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value).Equals(difficulty_Levels_Table.Rows[j][1]))
                        {
                            difficulty_Level_ID = Convert.ToInt32(difficulty_Levels_Table.Rows[j][0]);
                        }
                    }
                    questions_Adapter.InsertQuery(questions[i, 0], skill_ID, difficulty_Level_ID, assignment_ID, questions[i, 1], questions[i, 2], questions[i, 3], questions[i, 4]);
                }
            }
            error("Added");
        }

        public void Read_Questions_File()
        {
            questions = new string[50, 5];
            int questions_Index = 0;
            //Read the file provided by questions_File_Name
            StreamReader reader = new StreamReader(openQuestionFileDialog.FileName);

            //String that will hold the next line read
            string line = "";
            //String that will hold the returned string
            //string questions_For_Assignment_File = "";
            //Boolean that tells if to keep reading the file
            bool continue_Reading = true;
            //Reads file while continue_Reading is true
            while (continue_Reading)
            {
                //Reads next line
                line = reader.ReadLine();
                //Adds read line to the return string
                //questions_For_Assignment_File += line;
                //If there is not another string to be read
                if (reader.Peek() < 0)
                {
                    //continue_Reading is set to false which will stop the while loop
                    continue_Reading = false;
                }
                else
                {
                    //Add semicolon to sparate the question and answer sets
                    //questions_For_Assignment_File += "; ";
                }
                string[] split = line.Split(';');
                if (split.Length != 5)
                {
                    error("File not in correct format. ");
                    continue_Reading = false;
                }
                else
                {
                    for (int i = 0; i < split.Length; i++)
                    {
                        questions[questions_Index, i] = split[i];
                    }
                    questions_Index++;
                }
            }
            reader.Close();
            //return questions_For_Assignment_File;
        }

        private void check_For_Errors()
        {
            Error_Label.Text = "";
            errors = false;
            if (Question_file_name_label.Text.Equals("fileName.txt"))
            {
                error("Choose questions file. ");
            }
            if (!Choose_assignment_quest.Checked && !Choose_assignment_hw.Checked && !choose_assignment_project.Checked && !choose_assignment_quiz.Checked && !choose_assignment_test.Checked)
            {
                error("Choose type. ");
            }
            if (Assignment_Title_TextBox.Text.Equals(""))
            {
                error("Enter title. ");
            }
            //int counted_Skills = 0;
            //for (int i = 0; i < Skills_checkbox_list.Items.Count; i++)
            //{
            //    //If the skill is selected
            //    if (Skills_checkbox_list.GetItemChecked(i))
            //    {
            //        counted_Skills++;
            //    }
            //}
            //if (counted_Skills == 0)
            //{
            //    error("Select skill. ");
            //}
            if (Description_TextBox.Text.Equals(""))
            {
                error("Enter Description. ");
            }
        }

        private void error(string message)
        {
            Error_Label.Text += message;
            errors = true;
        }

        private void Import_Question_Bank_Click(object sender, EventArgs e)
        {
            openQuestionFileDialog.ShowDialog();
            Read_Questions_File();
            Add_To_Table();
        }

        private void Add_To_Table()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            questions_Column = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(questions_Column);
            difficulty_Levels_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_Difficulty_LevelsTableAdapter();
            DataTable difficulty_Levels_Table = difficulty_Levels_Adapter.GetData();
            difficulties = new DataGridViewComboBoxColumn();
            difficulties.HeaderText = "Difficulty Levels";
            for (int i = 0; i < difficulty_Levels_Table.Rows.Count; i++)
            {
                difficulties.Items.Add(difficulty_Levels_Table.Rows[i][1]);
            }

            skills_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            DataTable skillsTable = skills_Adapter.GetData();
            skills = new DataGridViewComboBoxColumn();
            skills.HeaderText = "Skill";
            int teacherID = 1; // TODO: Change this with real teacherID
            for (int i = 0; i < skillsTable.Rows.Count; i++)
            {
                if (Convert.ToInt32(skillsTable.Rows[i][2]) == teacherID)
                {
                    skills.Items.Add(Convert.ToString(skillsTable.Rows[i][1]));
                }
            }
            skills.DefaultCellStyle.NullValue = skills.Items[0];
            dataGridView1.Columns.Add(skills);

            for (int i = 0; i < questions.GetLength(0); i++)
            {
                if (questions[i, 0] != null)
                {
                    //Column_One_Listbox.Items.Add(questions[i, 0]);
                    dataGridView1.Rows.Add(questions[i, 0]);
                    //Column_Three_Listbox.Items.Add(difficulties);
                }
            }
            difficulties.DefaultCellStyle.NullValue = difficulties.Items[0];
            dataGridView1.Columns.Add(difficulties);
        }

        private void openQuestionFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Question_file_name_label.Text = openQuestionFileDialog.SafeFileName;
        }

        private void Information_Button_Click(object sender, EventArgs e)
        {
            if (display_Information)
            {
                Information_Label.Text = "";
                display_Information = false;
            }
            else
            {
                Information_Label.Text = "Please choose a .txt file that has the questions and answers stored like such:\nquestion1; 1correctAnswer; 1wrongAnswer1; 1wrongAnswer2; 1wrongAnswer3\nquestion2; 2correctAnswer; 2wrongAnswer1; 2wrongAnswer2; 2wrongAnswer3";
                display_Information = true;
            }
        }

        private void add_skill_button_Click(object sender, EventArgs e)
        {
            const int teacherID = 1; // TODO: Change this with real teacherID
            if (Skills_add_skill_text.Text == "") return;
            Skills_add_skill_text.Text = Skills_add_skill_text.Text.ToUpper();
            _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter skillsTableAdapter;
            skillsTableAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            DataTable skillsTable = skillsTableAdapter.GetData();
            int dup = 0;
            for (int i = 0; i < skillsTable.Rows.Count; i++)
            {
                if (Convert.ToInt32(skillsTable.Rows[i][2]) == teacherID)
                {
                    String skillName = Convert.ToString(skillsTable.Rows[i][1]);
                    if (skillName == Skills_add_skill_text.Text)
                    {
                        dup = 1;
                        break;
                    }
                }
            }
            if (dup == 0)
            {
                skillsTableAdapter.InsertQuery(Skills_add_skill_text.Text, teacherID);
            }
            else
            {
                Error_Label.Text = "Duplicated skill.";
            }
            Skills_add_skill_text.Text = "";
            Add_To_Table();
        }

        private void remove_skill_button_Click(object sender, EventArgs e)
        {
            const int teacherID = 1; // TODO: Change this with real teacherID
            if (Skills_add_skill_text.Text == "") return;
            Skills_add_skill_text.Text = Skills_add_skill_text.Text.ToUpper();
            _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter skillsTableAdapter;
            skillsTableAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            DataTable skillsTable = skillsTableAdapter.GetData();
            for (int i = 0; i < skillsTable.Rows.Count; i++)
            {
                if (Convert.ToInt32(skillsTable.Rows[i][2]) == teacherID)
                {
                    int skillID = Convert.ToInt32(skillsTable.Rows[i][0]);
                    String skillName = Convert.ToString(skillsTable.Rows[i][1]);
                    if (skillName == Skills_add_skill_text.Text)
                    {
                        // check if skill is associated with any assignment.
                        _Project3_4DatabaseDataSetTableAdapters.Nov17_Skills_In_AssignmentsTableAdapter skills_In_Assignments_Adapter;
                        skills_In_Assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Skills_In_AssignmentsTableAdapter();
                        DataTable skillsInAssignmentsTable = skills_In_Assignments_Adapter.GetData();
                        int removeOk = 1;
                        for (int j = 0; j < skillsInAssignmentsTable.Rows.Count; j++)
                        {
                            if (Convert.ToInt32(skillsInAssignmentsTable.Rows[j][2]) == skillID)
                            {
                                Error_Label.Text = "Cannot remove this skill. Please remove the assignment has this skill first.";
                                removeOk = 0;
                                break;
                            }
                        }
                        if (removeOk == 1)
                        {
                            // remove skill
                            skillsTableAdapter.DeleteQuery(skillID, teacherID);
                        }
                    }
                }
            }
            Skills_add_skill_text.Text = "";
            Add_To_Table();
        }

    }
}
