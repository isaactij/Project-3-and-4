using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Project_3_and_4
{
    public partial class Student_Play_Assignments : UserControl
    {
        _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter assignments_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_Assignment_TypesTableAdapter assignment_Types_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov25_QuestionsTableAdapter questions_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter grades_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov25_Difficulty_LevelsTableAdapter difficulty_Levels_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter students_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov25_Student_LevelsTableAdapter student_Levels_Adapter;
        DataTable assignments_Table;
        DataTable assignment_Types_Table;
        DataTable questions_Table;
        DataTable difficutly_Levels_Table;
        DataTable students_Table;
        DataTable student_Levels_Table;
        //Change Later
        int assignment_ID;
        //Change Later
        int student_ID;
        bool has_Questions;
        string[,] questions;
        int num_Of_Questions;
        int questions_Array_Index;
        int[] correctAnswerLocation;
        bool last_Question;
        int[] user_Answers;
        int[] level_Amounts;

        public Student_Play_Assignments()
        {
            InitializeComponent();
        }

        private void Student_Play_Assignments_Load(object sender, EventArgs e)
        {
            assignment_ID = 23;
            student_ID = 1;

            assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            assignments_Table = assignments_Adapter.GetData();
            assignment_Types_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_Assignment_TypesTableAdapter();
            assignment_Types_Table = assignment_Types_Adapter.GetData();
            Set_Up_Panel();
        }

        private void Set_Up_Panel()
        {
            bool found = false;
            int row_Index = 0;
            while (!found)
            {
                if (Convert.ToInt32(assignments_Table.Rows[row_Index][0]) == assignment_ID)
                {
                    Assignment_Title_label.Text = Convert.ToString(assignments_Table.Rows[row_Index][1]);
                    Description_Text_label.Text = Convert.ToString(assignments_Table.Rows[row_Index][2]);
                    found = true;
                }
                else
                {
                    row_Index++;
                }
            }
            get_Assignment_Type(row_Index);
            if (has_Questions)
            {
                level_Amounts = new int[50];
                get_Questions();
                questions_Array_Index = 0;
                correctAnswerLocation = new int[num_Of_Questions];
                user_Answers = new int[num_Of_Questions];
                Previous_Button.Hide();
                randomize_Answers();
                display_Question();
            }
            else {
                Answer_button1.Hide();
                Answer_button2.Hide();
                Answer_button3.Hide();
                Answer_button4.Hide();
                Previous_Button.Hide();
                Next_Button.Hide();
                question_Number_Label.Hide();
                Question_Text_label.Hide();
            }
        }

        private void get_Assignment_Type(int row_Index)
        {
            int type_ID = Convert.ToInt32(assignments_Table.Rows[row_Index][3]);
            for (int i = 0; i < assignment_Types_Table.Rows.Count; i++)
            {
                if (Convert.ToInt32(assignment_Types_Table.Rows[i][0]) == type_ID)
                {
                    if (Convert.ToString(assignment_Types_Table.Rows[i][1]).Equals("QUEST"))
                    {
                        has_Questions = true;
                    }
                    else
                    {
                        if (Convert.ToString(assignment_Types_Table.Rows[i][1]).Equals("HOMEWORK"))
                        {
                            has_Questions = false;
                        }
                        else
                        {
                            if (Convert.ToString(assignment_Types_Table.Rows[i][1]).Equals("TEST"))
                            {
                                has_Questions = true;
                            }
                            else
                            {
                                if (Convert.ToString(assignment_Types_Table.Rows[i][1]).Equals("PROJECT"))
                                {
                                    has_Questions = false;
                                }
                                else
                                {
                                    has_Questions = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void get_Questions()
        {
            questions_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_QuestionsTableAdapter();
            difficulty_Levels_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_Difficulty_LevelsTableAdapter();
            questions_Table = questions_Adapter.GetData();
            difficutly_Levels_Table = difficulty_Levels_Adapter.GetData();
            int temp_Questions_Index = 0;
            questions = new string[50, 5];
            for (int i = 0; i < questions_Table.Rows.Count; i++)
            {
                if (Convert.ToInt32(questions_Table.Rows[i][4]) == assignment_ID)
                {
                    questions[temp_Questions_Index, 0] = Convert.ToString(questions_Table.Rows[i][1]);
                    questions[temp_Questions_Index, 1] = Convert.ToString(questions_Table.Rows[i][5]);
                    questions[temp_Questions_Index, 2] = Convert.ToString(questions_Table.Rows[i][6]);
                    questions[temp_Questions_Index, 3] = Convert.ToString(questions_Table.Rows[i][7]);
                    questions[temp_Questions_Index, 4] = Convert.ToString(questions_Table.Rows[i][8]);
                    int difficulty_level_ID = Convert.ToInt32(questions_Table.Rows[i][3]);
                    for (int j = 0; j < difficutly_Levels_Table.Rows.Count; j++) {
                        if (Convert.ToInt32(difficutly_Levels_Table.Rows[j][0]) == difficulty_level_ID) {
                            level_Amounts[temp_Questions_Index] = Convert.ToInt32(difficutly_Levels_Table.Rows[j][2]);
                        }
                    }
                    temp_Questions_Index++;
                }
            }
            num_Of_Questions = temp_Questions_Index;
        }

        private void display_Question()
        {
            question_Number_Label.Text = (questions_Array_Index + 1) + "\\" + num_Of_Questions;
            Question_Text_label.Text = questions[questions_Array_Index, 0];
            Answer_button1.Text = questions[questions_Array_Index, 1];
            Answer_button2.Text = questions[questions_Array_Index, 2];
            Answer_button3.Text = questions[questions_Array_Index, 3];
            Answer_button4.Text = questions[questions_Array_Index, 4];
            if (user_Answers[questions_Array_Index] == 1)
            {
                Answer_button1.Checked = true;
            }
            else if (user_Answers[questions_Array_Index] == 2)
            {
                Answer_button2.Checked = true;
            }
            else if (user_Answers[questions_Array_Index] == 3)
            {
                Answer_button3.Checked = true;
            }
            else if (user_Answers[questions_Array_Index] == 4)
            {
                Answer_button4.Checked = true;
            }
        }

        private void randomize_Answers()
        {
            System.Random random = new System.Random();
            for (int j = 0; j < questions.GetLength(0); j++)
            {
                if (questions[j, 0] != null)
                {
                    //Creates an arrayList of 1-4, each representing a UI button
                    ArrayList choices = new ArrayList();
                    choices.Add(1);
                    choices.Add(2);
                    choices.Add(3);
                    choices.Add(4);
                    string backup_Answer1 = questions[j, 1];
                    string backup_Answer2 = questions[j, 2];
                    string backup_Answer3 = questions[j, 3];
                    string backup_Answer4 = questions[j, 4];
                    //Sets each button to a randomly chosen answer
                    for (int i = 1; i <= 4; i++)
                    {
                        //Chooses random int representing a space
                        int random_Number = random.Next(choices.Count);
                        //Gets the value of the space
                        int chosen_Number = Convert.ToInt32(choices[random_Number]);
                        //If chosen value is the correct answer, correctAnswerLocation is set to the button
                        if (chosen_Number == 1)
                        {
                            correctAnswerLocation[j] = i;
                        }
                        //Sets the text value of whichever button the for loop is on to the chosen value
                        if (i == 1)
                        {
                            if (chosen_Number == 1)
                            {
                                questions[j, 1] = backup_Answer1;
                            }
                            else if (chosen_Number == 2)
                            {
                                questions[j, 1] = backup_Answer2;
                            }
                            else if (chosen_Number == 3)
                            {
                                questions[j, 1] = backup_Answer3;
                            }
                            else
                            {
                                questions[j, 1] = backup_Answer4;
                            }
                        }
                        else if (i == 2)
                        {
                            if (chosen_Number == 1)
                            {
                                questions[j, 2] = backup_Answer1;
                            }
                            else if (chosen_Number == 2)
                            {
                                questions[j, 2] = backup_Answer2;
                            }
                            else if (chosen_Number == 3)
                            {
                                questions[j, 2] = backup_Answer3;
                            }
                            else
                            {
                                questions[j, 2] = backup_Answer4;
                            }
                        }
                        else if (i == 3)
                        {
                            if (chosen_Number == 1)
                            {
                                questions[j, 3] = backup_Answer1;
                            }
                            else if (chosen_Number == 2)
                            {
                                questions[j, 3] = backup_Answer2;
                            }
                            else if (chosen_Number == 3)
                            {
                                questions[j, 3] = backup_Answer3;
                            }
                            else
                            {
                                questions[j, 3] = backup_Answer4;
                            }
                        }
                        else
                        {
                            if (chosen_Number == 1)
                            {
                                questions[j, 4] = backup_Answer1;
                            }
                            else if (chosen_Number == 2)
                            {
                                questions[j, 4] = backup_Answer2;
                            }
                            else if (chosen_Number == 3)
                            {
                                questions[j, 4] = backup_Answer3;
                            }
                            else
                            {
                                questions[j, 4] = backup_Answer4;
                            }
                        }
                        //Removes chosen value from the arrayList of available choices
                        choices.Remove(chosen_Number);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Description_Text_label_Click(object sender, EventArgs e)
        {

        }

        private void Question_Text_label_Click(object sender, EventArgs e)
        {

        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            save_User_Answer();
            Previous_Button.Show();
            if (questions_Array_Index + 1 < num_Of_Questions - 1)
            {
                questions_Array_Index++;
                display_Question();
            }
            else
            {
                if (!last_Question)
                {
                    Next_Button.Text = "Submit";
                    questions_Array_Index++;
                    last_Question = true;
                    display_Question();
                }
                else
                {
                    grade_Assignment();
                }
            }
        }

        private void Previous_Button_Click(object sender, EventArgs e)
        {
            save_User_Answer();
            Next_Button.Text = "Next";
            last_Question = false;
            if (questions_Array_Index - 1 > 0)
            {
                questions_Array_Index--;
                display_Question();
            }
            else
            {
                Previous_Button.Hide();
                questions_Array_Index--;
                display_Question();
            }
        }

        private void save_User_Answer() {
            if (Answer_button1.Checked)
            {
                user_Answers[questions_Array_Index] = 1;
            }
            else if (Answer_button2.Checked)
            {
                user_Answers[questions_Array_Index] = 2;
            }
            else if (Answer_button3.Checked)
            {
                user_Answers[questions_Array_Index] = 3;
            }
            else if (Answer_button4.Checked)
            {
                user_Answers[questions_Array_Index] = 4;
            }
            else
            {
                user_Answers[questions_Array_Index] = 1;
            }
        }

        private void grade_Assignment()
        {
            students_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter();
            students_Table = students_Adapter.GetData();
            student_Levels_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov25_Student_LevelsTableAdapter();
            student_Levels_Table = student_Levels_Adapter.GetData();
            int amount_Answered_Correctly = 0;
            int level_To_Add = 0;
            for (int i = 0; i < num_Of_Questions; i++) {
                if (user_Answers[i] == correctAnswerLocation[i]) {
                    amount_Answered_Correctly++;
                    level_To_Add += level_Amounts[i];
                }
            }
            for (int i = 0; i < students_Table.Rows.Count; i++) {
                if (Convert.ToInt32(students_Table.Rows[i][0]) == student_ID) {
                    int new_Level_Amount = Convert.ToInt32(students_Table.Rows[i][4]) + level_To_Add;
                    int student_Level = Convert.ToInt32(students_Table.Rows[i][3]);
                    for (int j = 0; j < student_Levels_Table.Rows.Count; j++) {
                        if (Convert.ToInt32(student_Levels_Table.Rows[j][0]) == student_Level) {
                            if (j + 1 != student_Levels_Table.Rows.Count - 1) {
                                if (j != student_Levels_Table.Rows.Count - 1)
                                {
                                    if (Convert.ToInt32(student_Levels_Table.Rows[j + 1][2]) < new_Level_Amount)
                                    {
                                        new_Level_Amount = new_Level_Amount - Convert.ToInt32(student_Levels_Table.Rows[j + 1][2]);
                                        students_Adapter.UpdateQuery(Convert.ToInt32(student_Levels_Table.Rows[j + 1][0]), new_Level_Amount, student_ID, student_ID);
                                    }
                                    else
                                    {
                                        students_Adapter.UpdateQuery(Convert.ToInt32(student_Levels_Table.Rows[j][0]), new_Level_Amount, student_ID, student_ID);
                                    }
                                }
                            }
                            else
                            {
                                if (Convert.ToInt32(student_Levels_Table.Rows[j + 1][2]) < new_Level_Amount)
                                {
                                    students_Adapter.UpdateQuery(Convert.ToInt32(student_Levels_Table.Rows[j + 1][0]), 0, student_ID, student_ID);
                                }
                                else {
                                    students_Adapter.UpdateQuery(Convert.ToInt32(student_Levels_Table.Rows[j][0]), new_Level_Amount, student_ID, student_ID);
                                }
                                
                            }
                        }
                    }
                }
            }
            
            double grade = (amount_Answered_Correctly / num_Of_Questions) * 100;
            grades_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter();
            grades_Adapter.InsertQuery(student_ID, assignment_ID, grade);
            Question_Text_label.Text = "Grade: " + grade + "%";
            Answer_button1.Hide();
            Answer_button2.Hide();
            Answer_button3.Hide();
            Answer_button4.Hide();
            Previous_Button.Hide();
            Next_Button.Hide();
            question_Number_Label.Hide();
        }

    }
}
