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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
