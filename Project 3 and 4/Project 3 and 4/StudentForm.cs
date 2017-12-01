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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Group_Button_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var myControl = new Student_Group();
            panel1.Controls.Add(myControl);
        }
    }
}
