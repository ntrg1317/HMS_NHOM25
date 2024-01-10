using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class QuanLy : Form
    {
        Function function = new Function();
        public QuanLy()
        {
            InitializeComponent();
        }

        private void btnDieuTri_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new DieuTri(), btnDieuTri, panelHienThi);
        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
