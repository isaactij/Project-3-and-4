using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3_and_4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_login_button_Click(object sender, EventArgs e)
        {
            _Project3_4DatabaseDataSetTableAdapters.Nov18_Student_LoginTableAdapter student_adapter;
            student_adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_Student_LoginTableAdapter();
            DataTable student_table = student_adapter.GetData();

            bool loggedIn = false;

            for (int i = 0; i < student_table.Rows.Count; i++)
            {
                String username = Convert.ToString(student_table.Rows[i][2]); // this index might be wrong, not sure if the first one is counted in the index, I made it so it is counted
                String password = Convert.ToString(student_table.Rows[i][3]);
                if (username == Login_username_textbox.Text && password == Login_password_textbox.Text)
                {
                    loggedIn = true;
                    this.Hide();
                    StudentForm studentForm = new StudentForm();
                    studentForm.Student_Load(Convert.ToInt32(student_table.Rows[i][1]));
                    studentForm.ShowDialog();
                    this.Show();
                }
            }

            _Project3_4DatabaseDataSetTableAdapters.Nov18_Teacher_LoginTableAdapter teacher_adapter;
            teacher_adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov18_Teacher_LoginTableAdapter();
            DataTable teacher_table = teacher_adapter.GetData();

            for (int i = 0; i < teacher_table.Rows.Count; i++)
            {
                String username = Convert.ToString(teacher_table.Rows[i][2]); // this index might be wrong, not sure if the first one is counted in the index, I made it so it is counted
                String password = Convert.ToString(teacher_table.Rows[i][3]);
                if (username == Login_username_textbox.Text && password == Login_password_textbox.Text)
                {
                    loggedIn = true;
                    this.Hide();
                    TeacherForm teacherForm = new TeacherForm();
                    teacherForm.Teacher_Load(Convert.ToInt32(teacher_table.Rows[i][1]));
                    teacherForm.ShowDialog();
                    this.Show();
                }
            }
            if (loggedIn)
                Login_error_label.Text = "This combination is verified.\n You will be redirected shortly.";
            else
                Login_error_label.Text = "This username and password combination is\n not recognized. Please try again.";
        }

        /*private void teacherButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.ShowDialog();
            this.Show();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
            this.Show();
        }*/
    }
}
