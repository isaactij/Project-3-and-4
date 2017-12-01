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
    public partial class Student_Play_Assignments : UserControl
    {
        _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter assignments_Adapter;
        DataTable assignments_Table;
        //Change Later
        int assignment_ID;

        public Student_Play_Assignments()
        {
            InitializeComponent();
        }

        private void Student_Play_Assignments_Load(object sender, EventArgs e)
        {
            assignments_Adapter = new _Project3_4DatabaseDataSetTableAdapters.Nov17_AssignmentsTableAdapter();
            assignments_Table = assignments_Adapter.GetData();
            assignment_ID = 16;
            Set_Up_Panel();
        }

        private void Set_Up_Panel() {
            bool found = false;
            int row_Index = 0;
            while (!found) {
                if (Convert.ToInt32(assignments_Table.Rows[row_Index][0]) == assignment_ID)
                {
                    Assignment_Title_label.Text = Convert.ToString(assignments_Table.Rows[row_Index][1]);
                    Description_Text_label.Text = Convert.ToString(assignments_Table.Rows[row_Index][2]);
                    found = true;
                }
                else {
                    row_Index++;
                }
            }
        }

        private void Answer_button1_Click(object sender, EventArgs e)
        {

        }

        private void Answer_button2_Click(object sender, EventArgs e)
        {

        }

        private void Answer_button3_Click(object sender, EventArgs e)
        {

        }

        private void Answer_button4_Click(object sender, EventArgs e)
        {

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


    }
}
