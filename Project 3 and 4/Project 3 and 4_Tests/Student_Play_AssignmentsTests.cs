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

        DataTable students_Table;
        DataTable grade_Table;

        [TestMethod()]
        public void grade_AssignmentTest()
        {
            control = new Student_Play_Assignments();
            int given_Num_Of_Questions = 1;
            int[] given_CorrectAnswerLocation = { 1 };
            int[] given_User_Answers = { 1 };
            int[] given_Level_Amounts = { 1 };
            int given_ID = add_Student();

            control.num_Of_Questions = given_Num_Of_Questions;
            control.correctAnswerLocation = given_CorrectAnswerLocation;
            control.user_Answers = given_User_Answers;
            control.level_Amounts = given_Level_Amounts;
            control.student_ID = given_ID;
            control.grade_Assignment();

            grade_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_Assignment_GradeTableAdapter();
            grade_Table = grade_Adapter.GetData();
            int last_Grade = grade_Table.Rows.Count;
            int actual_Grade = Convert.ToInt32(grade_Table.Rows[last_Grade][3]);
            int correct_Grade = 100;

            Assert.AreEqual(correct_Grade, actual_Grade);
            grade_Adapter.DeleteQuery(Convert.ToInt32(grade_Table.Rows[last_Grade][0]), given_ID, Convert.ToInt32(grade_Table.Rows[last_Grade][2]), actual_Grade);
            delete_Student(given_ID);
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
            int last_Student = students_Table.Rows.Count;
            students_Adapter.DeleteQuery(student_ID, Convert.ToInt32(students_Table.Rows[last_Student][3]), Convert.ToInt32(students_Table.Rows[last_Student][4]));
        }
    }
}