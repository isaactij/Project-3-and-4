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
        public static string questions_File_Name;
        public static bool quest_Button;
        public static bool homework_Button;
        public static bool project_Button;
        public static bool quiz_Button;
        public static bool test_Button;
        public static string assignment_Title;
        public static string description;
        public static bool[] skills_Buttons;
        public static string[] skills_List;

        public Teacher_Create_Assignment()
        {
            InitializeComponent();
        }

        private void Teacher_Create_Assignment_Load(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("test");
            skills_List = read_skills_from_file("list_of_skills.txt");
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            string questions = Read_Questions_File();
            Create_Assignment_File(questions, "list_Of_Assignments.txt");
        }

        public static void Create_Assignment_File(string questions, string list_of_Assignments_File) {
            //Calls Add_Assignment_To_List so the assignment title is added to the list of assignments
            Add_Assignment_To_List(list_of_Assignments_File);
            //Creates a new assginment file named by the assignment title provided
            var file_Creator = File.Create(assignment_Title);
            file_Creator.Close();
            //string that holds the list of skills
            string line_Of_Skills = "";
            //For every skill
            for (int i = 0; i < skills_Buttons.Length; i++) {
                //If the skill is selected
                if (skills_Buttons[i]) {
                    //Add the skill to the list and a semicolon after it
                    line_Of_Skills += skills_List[i];
                    line_Of_Skills += ";";
                }
            }
            //Opens writer for the new assginment file
            StreamWriter writer = new StreamWriter(assignment_Title + ".txt");
            //Writes in a new line the skills chosen for the assignment
            writer.WriteLine(line_Of_Skills);
            //Writes in a new line the description of the assignment
            writer.WriteLine(description);
            //Writes in a new line the string of questions and answers
            writer.WriteLine(questions);
            writer.Close();
        }

        public static void Add_Assignment_To_List(string list_of_Assignments_File) {
            //Opens new reader to read the list of assignments file
            StreamReader reader = new StreamReader(list_of_Assignments_File);
            //Creates an empty array that each space will hold a string of assignment titles of a certain type of assignment
            string[] array_Of_Assignment_Titles = new string[5];
            //Array count for while loop
            int array_Count = 0;
            //Creates string that will hold the read line
            string line = "";
            //Tells when to keep the while loop going
            bool continue_Reading = true;
            //While there is a line
            while (continue_Reading)
            {
                //read line
                line = reader.ReadLine();
                //Adds line to array_Of_Assignment_Titles at array_Count
                array_Of_Assignment_Titles[array_Count] = line;
                //If there are no more lines stop the while loop
                if (reader.Peek() < 0)
                {
                    continue_Reading = false;
                }
                //Else add one to array_Count
                else
                {
                    array_Count++;
                }
            }
            reader.Close();
            //Sees which assignment button is selected and adds the new assignment to the corresponding array_Of_Assignment_Titles space
            if (quest_Button)
            {
                array_Of_Assignment_Titles[0] += assignment_Title + ";";
            }
            else if (homework_Button)
            {
                array_Of_Assignment_Titles[1] += assignment_Title + ";";
            }
            else if (project_Button)
            {
                array_Of_Assignment_Titles[2] += assignment_Title + ";";
            }
            else if (quiz_Button)
            {
                array_Of_Assignment_Titles[3] += assignment_Title + ";";
            }
            else {
                array_Of_Assignment_Titles[4] += assignment_Title + ";";
            }
            //Opens new writer fo list_of_Assignments_File
            StreamWriter writer = new StreamWriter(list_of_Assignments_File);
            //For each space in the array
            for (int i = 0; i < array_Of_Assignment_Titles.Length; i++)
            {
                //Write on a new line the list of assignments
                writer.WriteLine(array_Of_Assignment_Titles[i]);
            }
            writer.Close();
        }

        public static string Read_Questions_File() {
            //Read the file provided by questions_File_Name
            StreamReader reader = new StreamReader(questions_File_Name);
            //String that will hold the next line read
            string line = "";
            //String that will hold the returned string
            string questions_For_Assignment_File = "";
            //Boolean that tells if to keep reading the file
            bool continue_Reading = true;
            //Reads file while continue_Reading is true
            while (continue_Reading) {
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
                else {
                    //Add semicolon to sparate the question and answer sets
                    questions_For_Assignment_File += "; ";
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

        private void Import_Question_Bank_Click(object sender, EventArgs e)
        {
            openQuestionFileDialog.ShowDialog();
        }

        private void openQuestionFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Question_file_name_label.Text = openQuestionFileDialog.SafeFileName;
        }
    }
}
