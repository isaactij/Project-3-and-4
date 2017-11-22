﻿using System;
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
        bool display_Information;

        public Teacher_Create_Assignment()
        {
            InitializeComponent();
        }

        private void Teacher_Create_Assignment_Load(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("test");
            display_Information = false;
            refreshSkillsList();
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            check_For_Errors();
            if (!errors)
            {
                string questions = Read_Questions_File();
                if (!errors)
                {
                    //Create_Assignment_File(questions, "list_Of_Assignments.txt");
                    Add_Assignment_To_Database(questions);
                    Add_Skills_In_Assginment_To_Database();
                }
            }

        }

        public void Add_Skills_In_Assginment_To_Database()
        {
            _Project3_4DatabaseDataSetTableAdapters.Nov17_Skills_In_AssignmentsTableAdapter skills_In_Assignments_Adapter;
            skills_In_Assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Skills_In_AssignmentsTableAdapter();
            assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            DataTable assignments_Table = assignments_Adapter.GetData();
            int last_Row = assignments_Table.Rows.Count - 1;
            int assignment_ID = Convert.ToInt32(assignments_Table.Rows[last_Row][0]);
            _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter skills_Adapter;
            skills_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            DataTable skills_Table = skills_Adapter.GetData();
            for (int i = 0; i < Skills_checkbox_list.Items.Count; i++)
            {
                if (Skills_checkbox_list.GetItemChecked(i))
                {
                    for (int j = 0; j < skills_Table.Rows.Count; j++)
                    {
                        if (skills_Table.Rows[j][1].Equals(Skills_checkbox_list.Items[i]))
                        {
                            int skills_ID = Convert.ToInt32(skills_Table.Rows[j][0]);
                            skills_In_Assignments_Adapter.InsertQuery(assignment_ID, skills_ID);
                        }
                    }
                }
            }

        }

        public void Add_Assignment_To_Database(string questions)
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
            assignments_Adapter.InsertQuery(Assignment_Title_TextBox.Text, Description_TextBox.Text, questions, type, teacher_ID);
        }

        public string Read_Questions_File()
        {
            //Read the file provided by questions_File_Name
            StreamReader reader = new StreamReader(openQuestionFileDialog.FileName);

            //String that will hold the next line read
            string line = "";
            //String that will hold the returned string
            string questions_For_Assignment_File = "";
            //Boolean that tells if to keep reading the file
            bool continue_Reading = true;
            //Reads file while continue_Reading is true
            while (continue_Reading)
            {
                //Reads next line
                line = reader.ReadLine();
                //Adds read line to the return string
                questions_For_Assignment_File += line;
                //If there is not another string to be read
                if (reader.Peek() < 0)
                {
                    //continue_Reading is set to false which will stop the while loop
                    continue_Reading = false;
                }
                else
                {
                    //Add semicolon to sparate the question and answer sets
                    questions_For_Assignment_File += "; ";
                }
                string[] split = line.Split(';');
                if (split.Length != 5)
                {
                    error("File not in correct format. ");
                    continue_Reading = false;
                }
            }
            reader.Close();
            return questions_For_Assignment_File;
        }

        private String[] read_skills_from_file(String fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            String line = reader.ReadLine();
            String[] skills_list = line.Split(';');
            return skills_list;
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
            int counted_Skills = 0;
            for (int i = 0; i < Skills_checkbox_list.Items.Count; i++)
            {
                //If the skill is selected
                if (Skills_checkbox_list.GetItemChecked(i))
                {
                    counted_Skills++;
                }
            }
            if (counted_Skills == 0)
            {
                //error("Select skill. ");
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
            else {
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
                    if (skillName == Skills_add_skill_text.Text) {
                        dup = 1;
                        break;
                    }
                }
            }
            if (dup == 0) {
                skillsTableAdapter.InsertQuery(Skills_add_skill_text.Text, teacherID);
            } else {
                Error_Label.Text = "Duplicated skill.";
            }
            Skills_add_skill_text.Text = "";
            refreshSkillsList();
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
                    if (skillName == Skills_add_skill_text.Text) {
                        // check if skill is associated with any assignment.
                        _Project3_4DatabaseDataSetTableAdapters.Nov17_Skills_In_AssignmentsTableAdapter skills_In_Assignments_Adapter;
                        skills_In_Assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Skills_In_AssignmentsTableAdapter();
                        DataTable skillsInAssignmentsTable = skills_In_Assignments_Adapter.GetData();
                        int removeOk = 1;
                        for (int j = 0; j < skillsInAssignmentsTable.Rows.Count; j++){
                            if (Convert.ToInt32(skillsInAssignmentsTable.Rows[j][2]) == skillID) {
                                Error_Label.Text = "Cannot remove this skill. Please remove the assignment has this skill first.";
                                removeOk = 0;
                                break;
                            }
                        }
                        if (removeOk == 1) {
                            // remove skill
                            skillsTableAdapter.DeleteQuery(skillID, teacherID);
                        }
                    }
                }
            }
            Skills_add_skill_text.Text = "";
            refreshSkillsList();
        }

        private void refreshSkillsList()
        {
            const int teacherID = 1; // TODO: Change this with real teacherID
            _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter skillsTableAdapter;
            skillsTableAdapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            DataTable skillsTable = skillsTableAdapter.GetData();

            Skills_checkbox_list.Items.Clear();
            for (int i = 0; i < skillsTable.Rows.Count; i++)
            {
                if (Convert.ToInt32(skillsTable.Rows[i][2]) == teacherID)
                {
                    String skillName = Convert.ToString(skillsTable.Rows[i][1]);
                    Skills_checkbox_list.Items.Add(skillName);
                }
            }
        }
    }
}
