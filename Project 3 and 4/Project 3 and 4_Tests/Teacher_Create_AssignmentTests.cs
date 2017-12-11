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
    public class Teacher_Create_AssignmentTests
    {
        Teacher_Create_Assignment user_Control;

        _Project3_4DatabaseDataSetTableAdapters.Nov18_TeachersTableAdapter teacher_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter assignments_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_Assignment_TypesTableAdapter assignments_Types_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter skills_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov25_Difficulty_LevelsTableAdapter difficulty_Adapter;

        DataTable teacher_Table;
        DataTable assignments_Table;
        DataTable assignments_Types_Table;
        DataTable skills_Table;
        DataTable difficulty_Table;

        [TestMethod()]
        public void Read_Questions_FileTest()
        {
            user_Control = new Teacher_Create_Assignment();
            user_Control.openQuestionFileDialog.FileName = "Test_Questions_File.txt";
            user_Control.Read_Questions_File();
            string[,] actual = user_Control.questions;
            string[,] expected = new string[50, 5];
            expected[0, 0] = "question1";
            expected[0, 1] = " 1correctAnswer";
            expected[0, 2] = " 1wrongAnswer1";
            expected[0, 3] = " 1wrongAnswer2";
            expected[0, 4] = " 1wrongAnswer3";
            expected[1, 0] = "question2";
            expected[1, 1] = " 2correctAnswer";
            expected[1, 2] = " 2wrongAnswer1";
            expected[1, 3] = " 2wrongAnswer2";
            expected[1, 4] = " 2wrongAnswer3";
            for (int i = 0; i < actual.GetLength(0); i++)
            {
                for (int j = 0; j < actual.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }

        [TestMethod()]
        public void Add_Assignment_To_DatabaseTest()
        {
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
            string given_Title = "Test Title";
            string given_Description = "Test Description";
            int given_Teacher = add_Teacher();

            //string[,] questions = new string[50, 5];
            //questions[0, 0] = "question1";
            //questions[0, 1] = " 1correctAnswer";
            //questions[0, 2] = " 1wrongAnswer1";
            //questions[0, 3] = " 1wrongAnswer2";
            //questions[0, 4] = " 1wrongAnswer3";
            //questions[1, 0] = "question2";
            //questions[1, 1] = " 2correctAnswer";
            //questions[1, 2] = " 2wrongAnswer1";
            //questions[1, 3] = " 2wrongAnswer2";
            //questions[1, 4] = " 2wrongAnswer3";

            user_Control = new Teacher_Create_Assignment();
            user_Control.choose_assignment_project.Checked = true;
            user_Control.Assignment_Title_TextBox.Text = given_Title;
            user_Control.Description_TextBox.Text = given_Description;
            user_Control.teacher_ID = given_Teacher;
            //user_Control.questions = questions;
            user_Control.Add_Assignment_To_Database();

            assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            assignments_Table = assignments_Adapter.GetData();
            int last_Assignment = assignments_Table.Rows.Count - 1;
            int assignment_Type = Convert.ToInt32(assignments_Table.Rows[last_Assignment][3]);
            string assignment_Title = Convert.ToString(assignments_Table.Rows[last_Assignment][1]);
            string assignment_Description = Convert.ToString(assignments_Table.Rows[last_Assignment][2]);
            int assignment_Teacher = Convert.ToInt32(assignments_Table.Rows[last_Assignment][4]);

            Assert.AreEqual(given_Title, assignment_Title);
            Assert.AreEqual(given_Description, assignment_Description);
            Assert.AreEqual(given_Teacher, assignment_Teacher);
            Assert.AreEqual(given_Type, assignment_Type);

            assignments_Adapter.DeleteQuery(Convert.ToInt32(assignments_Table.Rows[last_Assignment][0]), assignment_Type, assignment_Teacher);
            delete_Teacher(given_Teacher);
        }

        [TestMethod()]
        public void check_For_ErrorsTest() {
            user_Control = new Teacher_Create_Assignment();
            user_Control.check_For_Errors();
            string expected = "Choose type. Enter title. Enter Description. ";
            string actual = user_Control.Error_Label.Text;
            Assert.AreEqual(expected, actual);
            user_Control.Choose_assignment_quest.Checked = true;
            expected = "Choose questions file. Enter title. Enter Description. ";
            user_Control.check_For_Errors();
            actual = user_Control.Error_Label.Text;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void add_skill_button_ClickTest() {
            user_Control = new Teacher_Create_Assignment();
            string given_Skill = "Test";
            user_Control.Skills_add_skill_text.Text = given_Skill;
            user_Control.questions = new string[50, 5];
            int teacher_ID = add_Teacher();
            user_Control.teacher_ID = teacher_ID;
            user_Control.add_skill_button_Click(null, null);
            skills_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            skills_Table = skills_Adapter.GetData();
            int last_Skill = skills_Table.Rows.Count - 1;
            string skill = Convert.ToString(skills_Table.Rows[last_Skill][1]);
            given_Skill = given_Skill.ToUpper();
            Assert.AreEqual(given_Skill, skill);
            int skill_ID = Convert.ToInt32(skills_Table.Rows[last_Skill][0]);
            skills_Adapter.DeleteQuery(skill_ID, teacher_ID);
            delete_Teacher(teacher_ID);
        }

        [TestMethod()]
        public void remove_skill_button_ClickTest() {
            user_Control = new Teacher_Create_Assignment();
            skills_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            string given_Skill = "TEST";
            int teacher_ID = add_Teacher();
            skills_Adapter.InsertQuery(given_Skill, teacher_ID);
            given_Skill = given_Skill.ToLower();
            user_Control.Skills_add_skill_text.Text = given_Skill;
            user_Control.questions = new string[50, 5];
            user_Control.teacher_ID = teacher_ID;
            user_Control.remove_skill_button_Click(null, null);
            skills_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_SkillsTableAdapter();
            skills_Table = skills_Adapter.GetData();
            int last_Skill = skills_Table.Rows.Count - 1;
            string skill = Convert.ToString(skills_Table.Rows[last_Skill][1]);
            given_Skill = given_Skill.ToUpper();
            Assert.AreNotEqual(given_Skill, skill);
            delete_Teacher(teacher_ID);
        }

        [TestMethod()]
        public void Add_or_Remove_Button_ClickTest() {
            user_Control = new Teacher_Create_Assignment();
            string given_Name = "Test";
            user_Control.Difficulty_Name_Textbox.Text = given_Name;
            user_Control.display_Add_Difficulty_Button = true;
            user_Control.Difficulty_Level_Amount_Textbox.Text = "100";
            user_Control.questions = new string[50, 5];
            user_Control.Add_or_Remove_Button_Click(null, null);
            difficulty_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_Difficulty_LevelsTableAdapter();
            difficulty_Table = difficulty_Adapter.GetData();
            int last_Difficulty = difficulty_Table.Rows.Count - 1;
            string difficulty = Convert.ToString(difficulty_Table.Rows[last_Difficulty][1]);
            given_Name = given_Name.ToUpper();
            Assert.AreEqual(given_Name, difficulty);
            int difficulty_ID = Convert.ToInt32(difficulty_Table.Rows[last_Difficulty][0]);
            int difficulty_Amount = Convert.ToInt32(difficulty_Table.Rows[last_Difficulty][2]);
            difficulty_Adapter.DeleteQuery(difficulty_ID, difficulty_Amount);
        }

        private int add_Teacher() {
            teacher_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_TeachersTableAdapter();
            teacher_Adapter.InsertQuery("First", "Last");
            teacher_Table = teacher_Adapter.GetData();
            int last_Teacher = teacher_Table.Rows.Count - 1;
            int teacher_ID = Convert.ToInt32(teacher_Table.Rows[last_Teacher][0]);
            return teacher_ID;
        }

        private void delete_Teacher(int teacher_ID) {
            teacher_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_TeachersTableAdapter();
            teacher_Adapter.DeleteQuery(teacher_ID);
        }
    }
}