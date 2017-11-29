using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3_and_4
{
    public partial class TeacherHeader : UserControl
    {
        public TeacherHeader()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new Teacher_Create_Assignment();
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
    }
}
