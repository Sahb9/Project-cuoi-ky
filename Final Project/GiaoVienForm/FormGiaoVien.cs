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
    public partial class FormGiaoVien : Form
    {
        public FormGiaoVien()
        {
            InitializeComponent();
        }

      

       

      

        private void buttonChoMuon_Click(object sender, EventArgs e)
        {
            panelx.Height = buttonChoMuon.Height;
            panelx.Top = buttonChoMuon.Top;
        }

        private void buttonMuonSach_Click(object sender, EventArgs e)
        {
            panelx.Height = buttonMuonSach.Height;
            panelx.Top = buttonMuonSach.Top;
            
        }

        private void buttonTraSach_Click(object sender, EventArgs e)
        {
            
            panelx.Height = buttonTraSach.Height;
            panelx.Top = buttonTraSach.Top;
        }
    }
}
