using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_3_and_4;
using System.IO;
using System.Data;

namespace Project_3_and_4_Tests
{
    [TestClass]
    public class Teacher_Create_Assignment_Tests
    {
        [TestMethod]
        public void Read_Questions_File_Tests() {
            //Sets name of test_File to the string test_File and to the questions_File_Name
            //These are constants in the tests
            string test_File = "Test_Questions_File.txt";
            Teacher_Create_Assignment.questions_File_Name = test_File;

            //Test 1: File is empty
            //Opens new writer to write to the test file
            StreamWriter writer = new StreamWriter(test_File);
            //Closes writer to ensure an empty file
            writer.Close();
            //Gets returned string from method being tested
            string returned_String = Teacher_Create_Assignment.Read_Questions_File();
            //Correct string is empty
            string expected_String = "";
            //Tests if the expected and returned string are equal
            Assert.AreEqual(expected_String, returned_String);

            //Test 2: File contains two question sets
            //Opens new writer to write to test file
            writer = new StreamWriter(test_File);
            //Writes two lines to the test file
            writer.WriteLine("question1; 1correctAnswer; 1wrongAnswer1; 1wrongAnswer2; 1wrongAnswer3");
            writer.WriteLine("question2; 2correctAnswer; 2wrongAnswer1; 2wrongAnswer2; 2wrongAnswer3");
            //Close writer
            writer.Close();
            //Gets returned string from method being tested
            returned_String = Teacher_Create_Assignment.Read_Questions_File();
            //Sets string to expected output
            expected_String = "question1; 1correctAnswer; 1wrongAnswer1; 1wrongAnswer2; 1wrongAnswer3; question2; 2correctAnswer; 2wrongAnswer1; 2wrongAnswer2; 2wrongAnswer3";
            //Test to see if expected and returned are equal
            Assert.AreEqual(expected_String, returned_String);
        }
        
        [TestMethod]
        public void Create_Assignment_File_Tests(){
            //Sets path for test file that hold the questions
            string test_questions_File = "Test_Questions_File.txt";
            //Creates a writer to write to the test questions file
            StreamWriter writer = new StreamWriter(test_questions_File);
            //Writes two questions sets
            writer.WriteLine("question1; 1correctAnswer; 1wrongAnswer1; 1wrongAnswer2; 1wrongAnswer3");
            writer.WriteLine("question2; 2correctAnswer; 2wrongAnswer1; 2wrongAnswer2; 2wrongAnswer3");
            //Close the writer
            writer.Close();
            //Sets variables in Teacher_Create_Assignment to be used in Create_Assignment_File
            //Sets location of file with the questions
            Teacher_Create_Assignment.questions_File_Name = test_questions_File;
            //Sets the Assignment Title
            Teacher_Create_Assignment.assignment_Title = "Test Assignment";
            //Sets the boolean that marks the quest button as selected to true
            Teacher_Create_Assignment.quest_Button = true;
            //Sets the skils_List so there are two skills options
            Teacher_Create_Assignment.skills_List = new string[]{"Math", "History"};
            //Sets the skill_Buttons so both skills are marked as selected
            Teacher_Create_Assignment.skills_Buttons = new bool[]{true, true};
            //Sets the description
            Teacher_Create_Assignment.description = "Test Description";
            //Gets the string with the question sets
            string questions = Teacher_Create_Assignment.Read_Questions_File();
            //Runs method to be tested
            Teacher_Create_Assignment.Create_Assignment_File(questions, "Test_list_Of_Assignments_File.txt");
            //Creates string with the expected words in the proper format
            string expected = ("Math;History;\nTest Description\nquestion1; 1correctAnswer; 1wrongAnswer1; 1wrongAnswer2; 1wrongAnswer3; question2; 2correctAnswer; 2wrongAnswer1; 2wrongAnswer2; 2wrongAnswer3");
            //Creates an empty string that will hold everything that is read from the file
            String output = "";
            //Creates reader for the file that Create_Assignment_File should have made
            StreamReader reader = new StreamReader("Test Assignment.txt");
            //Will hold the read line
            string line = "";
            //Says when the file has been finished reading
            bool continue_Reading = true;
            //While there are still lines
            while (continue_Reading)
            {
                //Get next line
                line = reader.ReadLine();
                //Add read line to output
                output += line;
                //If there are no more lines then the while loop is done
                if (reader.Peek() < 0)
                {
                    continue_Reading = false;
                }
                //Else add new line character to mark a new line
                else {
                    output += "\n";
                }
            }
            reader.Close();
            //Test is expected and output are equal
            Assert.AreEqual(expected, output);
            //Removes test assignment file
            File.Delete("Test Assignment.txt");
            //Clears Test_list_Of_Assignments_File of all text
            writer = new StreamWriter("Test_list_Of_Assignments_File.txt");
            writer.Close();
        }

        [TestMethod]
        public void Fill_Columns_Tests() {
            //Report_Assignments.Fill_Columns();
        }
    }
}
