using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Bunifu.Framework.Lib;
using Bunifu.Framework.LICENSE;
using System.Runtime.Remoting.Contexts;
//using UserControls;
namespace Final_Project
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

   



        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            gioiThieu1.BringToFront();
            buttonExit.BringToFront();
            // thay doi o day nha!
        }





        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_quanLySach_Click_1(object sender, EventArgs e)
        {
            panelx.Height = buttonQuanLySach.Height;
            panelx.Top = buttonQuanLySach.Top;
            quanLySach1.BringToFront();
            buttonExit.BringToFront();
        }
        private void buttonQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            //hiện thanh xuất hiện màu đỏ 
            panelx.Height = buttonQuanLyNhanVien.Height;
            panelx.Top = buttonQuanLyNhanVien.Top;
            //hiện giao diện quản lý nhân viên
            quanLyNhanVien1.BringToFront();
            //hiện nút exit
            buttonExit.BringToFront();
        }
    }
}
