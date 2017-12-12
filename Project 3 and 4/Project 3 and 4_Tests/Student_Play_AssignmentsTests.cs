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
    public class Student_Play_AssignmentsTests
    {
        Student_Play_Assignments control;

        _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter students_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter grade_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter assignment_Adapter;
        _Project3_4DatabaseDataSetTableAdapters.Nov18_TeachersTableAdapter teacher_Adapter;

        DataTable students_Table;
        DataTable grade_Table;
        DataTable assignment_Table;
        DataTable teacher_Table;

        [TestMethod()]
        public void grade_AssignmentTest()
        {
            
            int given_Num_Of_Questions = 1;
            int[] given_CorrectAnswerLocation = { 1 };
            int[] given_User_Answers = { 1 };
            int[] given_Level_Amounts = { 1 };
            int given_ID = add_Student();
            int teacher_ID = add_Teacher();
            int assignment_ID = add_Assignment(teacher_ID);

            control = new Student_Play_Assignments(assignment_ID, given_ID);
            control.num_Of_Questions = given_Num_Of_Questions;
            control.correctAnswerLocation = given_CorrectAnswerLocation;
            control.user_Answers = given_User_Answers;
            control.level_Amounts = given_Level_Amounts;
            control.student_ID = given_ID;
            control.assignment_ID = assignment_ID;
            control.grade_Assignment();

            grade_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter();
            grade_Table = grade_Adapter.GetData();
            int last_Grade = grade_Table.Rows.Count - 1;
            int actual_Grade = Convert.ToInt32(grade_Table.Rows[last_Grade][3]);
            int correct_Grade = 100;

            Assert.AreEqual(correct_Grade, actual_Grade);
            grade_Adapter.DeleteQuery(Convert.ToInt32(grade_Table.Rows[last_Grade][0]), given_ID, Convert.ToInt32(grade_Table.Rows[last_Grade][2]), actual_Grade);
            delete_Student(given_ID);
            delete_Assignment(assignment_ID, teacher_ID);
            delete_Teacher(teacher_ID);

        }

        private int add_Assignment(int teacher_ID) {
            assignment_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            assignment_Adapter.InsertQuery("Test Title", "Test Description", 18, teacher_ID);
            assignment_Table = assignment_Adapter.GetData();
            int last_Assignment = assignment_Table.Rows.Count - 1;
            int assignment_ID = Convert.ToInt32(assignment_Table.Rows[last_Assignment][0]);
            return assignment_ID;
        }

        private void delete_Assignment(int Assignment_ID, int teacher_ID) {
            assignment_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            assignment_Table = assignment_Adapter.GetData();
            int last_Assignment = assignment_Table.Rows.Count - 1;
            assignment_Adapter.DeleteQuery(Assignment_ID, Convert.ToInt32(assignment_Table.Rows[last_Assignment][3]), teacher_ID);
        }

        private int add_Teacher()
        {
            teacher_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_TeachersTableAdapter();
            teacher_Adapter.InsertQuery("First", "Last");
            teacher_Table = teacher_Adapter.GetData();
            int last_Teacher = teacher_Table.Rows.Count - 1;
            int teacher_ID = Convert.ToInt32(teacher_Table.Rows[last_Teacher][0]);
            return teacher_ID;
        }

        private void delete_Teacher(int teacher_ID)
        {
            teacher_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_TeachersTableAdapter();
            teacher_Adapter.DeleteQuery(teacher_ID);
        }

        private int add_Student() {
            students_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter();
            students_Adapter.InsertQuery("First", "Last", 1, 0);
            students_Table = students_Adapter.GetData();
            int last_Student = students_Table.Rows.Count - 1;
            int student_ID = Convert.ToInt32(students_Table.Rows[last_Student][0]);
            return student_ID;
        }

        private void delete_Student(int student_ID) {
            students_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_StudentsTableAdapter();
            students_Table = students_Adapter.GetData();
            int last_Student = students_Table.Rows.Count - 1;
            students_Adapter.DeleteQuery(student_ID, Convert.ToInt32(students_Table.Rows[last_Student][3]), Convert.ToInt32(students_Table.Rows[last_Student][4]));
        }
    }
}