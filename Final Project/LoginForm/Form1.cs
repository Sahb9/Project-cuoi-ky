using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
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

        private void BT_Login_Click(object sender, EventArgs e)
        {
            if (radioButtonAdminstrative.Checked)
            {

            }
            else if (radioButtonTeacher.Checked)
            {

            }
            else if (radioButtonStudent.Checked)
            {

            }
            else
                MessageBox.Show("Vui lòng chọn dấu tích ");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
