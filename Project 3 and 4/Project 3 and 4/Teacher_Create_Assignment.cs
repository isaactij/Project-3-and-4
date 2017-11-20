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
        bool display_Information;

        public Teacher_Create_Assignment()
        {
            InitializeComponent();
        }

        private void Teacher_Create_Assignment_Load(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("test");
            skills_List = read_skills_from_file("list_of_skills.txt");
            display_Information = false;
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

        public void Create_Assignment_File(string questions, string list_of_Assignments_File)
        {
            //Calls Add_Assignment_To_List so the assignment title is added to the list of assignments
            Add_Assignment_To_List(list_of_Assignments_File);
            //Creates a new assginment file named by the assignment title provided
            var file_Creator = File.Create(Assignment_Title_TextBox.Text);
            file_Creator.Close();
            //string that holds the list of skills
            string line_Of_Skills = "";
            //For every skill
            for (int i = 0; i < Skills_checkbox_list.Items.Count; i++)
            {
                //If the skill is selected
                if (Skills_checkbox_list.GetItemChecked(i))
                {
                    //Add the skill to the list and a semicolon after it
                    line_Of_Skills += skills_List[i];
                    line_Of_Skills += ";";
                }
            }
            //Opens writer for the new assginment file
            StreamWriter writer = new StreamWriter(Assignment_Title_TextBox.Text + ".txt");
            //Writes in a new line the skills chosen for the assignment
            writer.WriteLine(line_Of_Skills);
            //Writes in a new line the description of the assignment
            writer.WriteLine(Description_TextBox.Text);
            //Writes in a new line the string of questions and answers
            writer.WriteLine(questions);
            writer.Close();
        }

        public void Add_Assignment_To_List(string list_of_Assignments_File)
        {
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
            if (Choose_assignment_quest.Checked)
            {
                array_Of_Assignment_Titles[0] += Assignment_Title_TextBox.Text + ";";
            }
            else if (Choose_assignment_hw.Checked)
            {
                array_Of_Assignment_Titles[1] += Assignment_Title_TextBox.Text + ";";
            }
            else if (choose_assignment_project.Checked)
            {
                array_Of_Assignment_Titles[2] += Assignment_Title_TextBox.Text + ";";
            }
            else if (choose_assignment_quiz.Checked)
            {
                array_Of_Assignment_Titles[3] += Assignment_Title_TextBox.Text + ";";
            }
            else
            {
                array_Of_Assignment_Titles[4] += Assignment_Title_TextBox.Text + ";";
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
    }
}
