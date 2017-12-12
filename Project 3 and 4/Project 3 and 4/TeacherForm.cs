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
    public partial class TeacherForm : Form
    {
        int teacher_ID;

        public TeacherForm()
        {
            InitializeComponent();
        }

        public void Teacher_Load(int teacher_ID_Load)
        {
            teacher_ID = teacher_ID_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var myControl = new Teacher_Home();
            panel1.Controls.Add(myControl);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new Teacher_Create_Assignment();
            myControl.Teacher_Load(teacher_ID);
            panel1.Controls.Add(myControl);
        }

        private void Assignments_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new Report_Assignments();
            panel1.Controls.Add(myControl);
        }

        private void Skills_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new Report_Skills();
            panel1.Controls.Add(myControl);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Student_Report_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new Teacher_Home();
            panel1.Controls.Add(myControl);
        }
    }
}
