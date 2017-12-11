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
        public int teacher_ID;//Change later
        _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter assignments_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov25_Difficulty_LevelsTableAdapter difficulty_Levels_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter skills_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov25_QuestionsTableAdapter questions_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_Assignment_TypesTableAdapter assignment_Types_Adapter;
        DataTable questions_Table;
        DataTable assignment_Types_Table;
        DataTable difficulty_Levels_Table;
        bool display_Information;
        public string[,] questions;
        DataGridViewTextBoxColumn questions_Column;
        DataGridViewComboBoxColumn difficulties;
        DataGridViewComboBoxColumn skills;
        public bool display_Add_Difficulty_Button;
        bool display_Remove_Difficulty_Button;

        public Teacher_Create_Assignment()
        {
            InitializeComponent();
        }

        private void Teacher_Create_Assignment_Load(object sender, EventArgs e)
        {
            display_Information = false;
            Information_Label.Text = "";
            Error_Label.Text = "";
            Difficulty_Name_Title_Label.Hide();
            Difficulty_Name_Textbox.Hide();
            Difficulty_Amount_Title_Label.Hide();
            Difficulty_Level_Amount_Textbox.Hide();
            Add_or_Remove_Button.Hide();
            display_Add_Difficulty_Button = false;
            display_Remove_Difficulty_Button = false;
            questions = new string[50, 5];
            Import_Question_Bank.Hide();
            Question_file_name_label.Hide();
            Information_Button.Hide();
            dataGridView1.Hide();
            teacher_ID = 1;//Change
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            check_For_Errors();
            if (!errors)
            {
                if (Choose_assignment_quest.Checked || choose_assignment_quiz.Checked || choose_assignment_test.Checked)
                {
                    Read_Questions_File();
                }
                if (!errors)
                {
                    Add_Assignment_To_Database();
                }
            }

        }

        public void Add_Assignment_To_Database()
        {
            
            assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            assignment_Types_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Assignment_TypesTableAdapter();
            assignment_Types_Table = assignment_Types_Adapter.GetData();
            int type = 0;
            if (Choose_assignment_quest.Checked)
            {
                for (int i = 0; i < assignment_Types_Table.Rows.Count; i++)
                {
                    if (Convert.ToString(assignment_Types_Table.Rows[i][1]).Equals("QUEST"))
                    {
                        type = Convert.ToInt32(assignment_Types_Table.Rows[i][0]);
                    }
                }
            }
            else if (Choose_assignment_hw.Checked)
            {
                for (int i = 0; i < assignment_Types_Table.Rows.Count; i++)
                {
                    if (Convert.ToString(assignment_Types_Table.Rows[i][1]).Equals("HOMEWORK"))
                    {
                        type = Convert.ToInt32(assignment_Types_Table.Rows[i][0]);
                    }
                }
            }
            else if (choose_assignment_project.Checked)
            {
                for (int i = 0; i < assignment_Types_Table.Rows.Count; i++)
                {
                    if (Convert.ToString(assignment_Types_Table.Rows[i][1]).Equals("PROJECT"))
                    {
                        type = Convert.ToInt32(assignment_Types_Table.Rows[i][0]);
                    }
                }
            }
            else if (choose_assignment_quiz.Checked)
            {
                for (int i = 0; i < assignment_Types_Table.Rows.Count; i++)
                {
                    if (Convert.ToString(assignment_Types_Table.Rows[i][1]).Equals("QUIZ"))
                    {
                        type = Convert.ToInt32(assignment_Types_Table.Rows[i][0]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < assignment_Types_Table.Rows.Count; i++)
                {
                    if (Convert.ToString(assignment_Types_Table.Rows[i][1]).Equals("TEST"))
                    {
                        type = Convert.ToInt32(assignment_Types_Table.Rows[i][0]);
                    }
                }
            }
            assignments_Adapter.InsertQuery(Assignment_Title_TextBox.Text, Description_TextBox.Text, type, teacher_ID);

            if (Choose_assignment_quest.Checked || choose_assignment_quiz.Checked || choose_assignment_test.Checked)
            {
                assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
                DataTable assignments_Table = assignments_Adapter.GetData();
                int num_Rows = assignments_Table.Rows.Count;
                int assignment_ID = Convert.ToInt32(assignments_Table.Rows[num_Rows - 1][0]);
                skills_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
                DataTable skills_Table = skills_Adapter.GetData();
                difficulty_Levels_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_Difficulty_LevelsTableAdapter();
                difficulty_Levels_Table = difficulty_Levels_Adapter.GetData();
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
                //If there is not another string to be read
                if (reader.Peek() < 0)
                {
                    //continue_Reading is set to false which will stop the while loop
                    continue_Reading = false;
                }
                string[] split = line.Split(';');
                Error_Label.Text = "";
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
        }

        public void check_For_Errors()
        {
            Error_Label.Text = "";
            errors = false;
            if (Choose_assignment_quest.Checked || choose_assignment_quiz.Checked || choose_assignment_test.Checked)
            {
                if (Question_file_name_label.Text.Equals("fileName.txt"))
                {
                    error("Choose questions file. ");
                }
                bool skill_Error = false;
                bool difficulty_Error = false;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (!skill_Error && dataGridView1.Rows[i].Cells[1].Value == null)
                    {
                        error("Choose skill. ");
                        skill_Error = true;
                    }
                    if (!difficulty_Error && dataGridView1.Rows[i].Cells[2].Value == null)
                    {
                        error("Choose difficulty. ");
                        difficulty_Error = true;
                    }
                }
            }
            if (!Choose_assignment_quest.Checked && !Choose_assignment_hw.Checked && !choose_assignment_project.Checked && !choose_assignment_quiz.Checked && !choose_assignment_test.Checked)
            {
                error("Choose type. ");
            }
            if (Assignment_Title_TextBox.Text.Equals(""))
            {
                error("Enter title. ");
            }
            
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
            if (!Question_file_name_label.Text.Equals("fileName.txt")) {
                Read_Questions_File();
                Fill_Table();
            }
        }

        public void Fill_Table()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            questions_Column = new DataGridViewTextBoxColumn();
            questions_Column.HeaderText = "Questions";
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
            dataGridView1.Columns.Add(skills);

            for (int i = 0; i < questions.GetLength(0); i++)
            {
                if (questions[i, 0] != null)
                {
                    dataGridView1.Rows.Add(questions[i, 0]);
                }
            }
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
                Information_Label.Text = "Please choose a .txt file that has the questions and answers stored like such:\nquestion1; 1correctAnswer; 1wrongAnswer1; 1wrongAnswer2; 1wrongAnswer3\nquestion2; 2correctAnswer; 2wrongAnswer1; 2wrongAnswer2; 2wrongAnswer3\nAt most 50 questions";
                display_Information = true;
            }
        }

        public void add_skill_button_Click(object sender, EventArgs e)
        {
            if (Skills_add_skill_text.Text == "") {
                return;
            }
            Skills_add_skill_text.Text = Skills_add_skill_text.Text.ToUpper();
            _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter skillsTableAdapter;
            skillsTableAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            DataTable skillsTable = skillsTableAdapter.GetData();
            int dup = 0;
            for (int i = 0; i < skillsTable.Rows.Count; i++)
            {
                if (Convert.ToInt32(skillsTable.Rows[i][2]) == teacher_ID)
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
                skillsTableAdapter.InsertQuery(Skills_add_skill_text.Text, teacher_ID);
            }
            else
            {
                error("Duplicated skill. ");
            }
            Skills_add_skill_text.Text = "";
                Fill_Table();
            
        }

        public void remove_skill_button_Click(object sender, EventArgs e)
        {
            if (Skills_add_skill_text.Text == "") return;
            Skills_add_skill_text.Text = Skills_add_skill_text.Text.ToUpper();
            _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter skillsTableAdapter;
            skillsTableAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            DataTable skillsTable = skillsTableAdapter.GetData();
            for (int i = 0; i < skillsTable.Rows.Count; i++)
            {
                if (Convert.ToInt32(skillsTable.Rows[i][2]) == teacher_ID)
                {
                    int skillID = Convert.ToInt32(skillsTable.Rows[i][0]);
                    String skillName = Convert.ToString(skillsTable.Rows[i][1]);
                    if (skillName == Skills_add_skill_text.Text)
                    {
                        // check if skill is associated with any assignment.
                        _Project3_4DatabaseDataSetTableAdapters.Nov25_QuestionsTableAdapter questionsAdapter;
                        questionsAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_QuestionsTableAdapter();
                        DataTable questionsTable = questionsAdapter.GetData();
                        int removeOk = 1;
                        for (int j = 0; j < questionsTable.Rows.Count; j++)
                        {
                            if (Convert.ToInt32(questionsTable.Rows[j][2]) == skillID)
                            {
                                Error_Label.Text = "Cannot remove this skill. Please remove the assignment has this skill first. ";
                                removeOk = 0;
                                break;
                            }
                        }
                        if (removeOk == 1)
                        {
                            // remove skill
                            skillsTableAdapter.DeleteQuery(skillID, teacher_ID);
                        }
                    }
                }
            }
            Skills_add_skill_text.Text = "";
            Fill_Table();
        }

        private void Difficulty_Amount_Title_Label_Click(object sender, EventArgs e)
        {

        }

        private void Add_Difficulty_Button_Click(object sender, EventArgs e)
        {
            display_Remove_Difficulty_Button = false;
            if (!display_Add_Difficulty_Button)
            {
                Difficulty_Name_Title_Label.Show();
                Difficulty_Name_Textbox.Show();
                Difficulty_Amount_Title_Label.Show();
                Difficulty_Level_Amount_Textbox.Show();
                Add_or_Remove_Button.Show();
                Add_or_Remove_Button.Text = "Add";
                display_Add_Difficulty_Button = true;
            }
            else
            {
                Difficulty_Name_Title_Label.Hide();
                Difficulty_Name_Textbox.Hide();
                Difficulty_Amount_Title_Label.Hide();
                Difficulty_Level_Amount_Textbox.Hide();
                Add_or_Remove_Button.Hide();
                display_Add_Difficulty_Button = false;
            }

        }

        private void Remove_Difficulty_Button_Click(object sender, EventArgs e)
        {
            display_Add_Difficulty_Button = false;
            if (!display_Remove_Difficulty_Button)
            {
                Difficulty_Name_Title_Label.Show();
                Difficulty_Name_Textbox.Show();
                Add_or_Remove_Button.Show();
                Difficulty_Amount_Title_Label.Hide();
                Difficulty_Level_Amount_Textbox.Hide();
                Add_or_Remove_Button.Text = "Remove";
                display_Remove_Difficulty_Button = true;
            }
            else
            {
                Difficulty_Name_Title_Label.Hide();
                Difficulty_Name_Textbox.Hide();
                Difficulty_Amount_Title_Label.Hide();
                Difficulty_Level_Amount_Textbox.Hide();
                Add_or_Remove_Button.Hide();
                display_Remove_Difficulty_Button = false;
            }

        }

        public void Add_or_Remove_Button_Click(object sender, EventArgs e)
        {
            difficulty_Levels_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_Difficulty_LevelsTableAdapter();
            difficulty_Levels_Table = difficulty_Levels_Adapter.GetData();
            string name = Difficulty_Name_Textbox.Text;
            name = name.ToUpper();
            if (display_Add_Difficulty_Button)
            {
                int amount;
                try
                {
                    amount = Convert.ToInt32(Difficulty_Level_Amount_Textbox.Text);
                }
                catch
                {
                    error("Difficuty Level Amount is not valid");
                    return;
                }
                bool already_In = false;
                for (int i = 0; i < difficulty_Levels_Table.Rows.Count; i++)
                {
                    if (Convert.ToString(difficulty_Levels_Table.Rows[i][1]).Equals(name) || Convert.ToInt32(difficulty_Levels_Table.Rows[i][2]) == amount)
                    {
                        already_In = true;
                    }
                }
                if (already_In)
                {
                    error("Difficulty is already in table. ");
                    return;
                }
                else
                {
                    difficulty_Levels_Adapter.InsertQuery(name, Convert.ToInt32(Difficulty_Level_Amount_Textbox.Text));
                }
                Difficulty_Name_Title_Label.Hide();
                Difficulty_Name_Textbox.Hide();
                Difficulty_Amount_Title_Label.Hide();
                Difficulty_Level_Amount_Textbox.Hide();
                Add_or_Remove_Button.Hide();
                display_Add_Difficulty_Button = false;
            }
            else {
                int difficulty_Index = 0;
                for (int i = 0; i < difficulty_Levels_Table.Rows.Count; i++)
                {
                    if (Convert.ToString(difficulty_Levels_Table.Rows[i][1]).Equals(name))
                    {
                        difficulty_Index = i;
                    }
                }
                if (difficulty_Index == 0)
                {
                    error("Does not contain specified difficulty. ");
                    return;
                }
                else {
                    difficulty_Levels_Adapter.DeleteQuery(Convert.ToInt32(difficulty_Levels_Table.Rows[difficulty_Index][0]), Convert.ToInt32(difficulty_Levels_Table.Rows[difficulty_Index][2]));
                }
                Difficulty_Name_Title_Label.Hide();
                Difficulty_Name_Textbox.Hide();
                Difficulty_Amount_Title_Label.Hide();
                Difficulty_Level_Amount_Textbox.Hide();
                Add_or_Remove_Button.Hide();
                display_Remove_Difficulty_Button = false;
            }
            Fill_Table();
        }

        private void Choose_assignment_quest_CheckedChanged(object sender, EventArgs e)
        {
            Import_Question_Bank.Show();
            Question_file_name_label.Show();
            Information_Button.Show();
            dataGridView1.Show();
        }

        private void Choose_assignment_hw_CheckedChanged(object sender, EventArgs e)
        {
            Import_Question_Bank.Hide();
            Question_file_name_label.Hide();
            Information_Button.Hide();
            dataGridView1.Hide();
        }

        private void choose_assignment_project_CheckedChanged(object sender, EventArgs e)
        {
            Import_Question_Bank.Hide();
            Question_file_name_label.Hide();
            Information_Button.Hide();
            dataGridView1.Hide();
        }

        private void choose_assignment_quiz_CheckedChanged(object sender, EventArgs e)
        {
            Import_Question_Bank.Show();
            Question_file_name_label.Show();
            Information_Button.Show();
            dataGridView1.Show();
        }

        private void choose_assignment_test_CheckedChanged(object sender, EventArgs e)
        {
            Import_Question_Bank.Show();
            Question_file_name_label.Show();
            Information_Button.Show();
            dataGridView1.Show();
        }
        
    }
}
