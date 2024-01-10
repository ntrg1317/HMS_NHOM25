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
    public partial class DieuTri : Form
    {
        Function function = new Function();
        public DieuTri()
        {
            InitializeComponent();
        }

        private void btnLSDT_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new LichSuDieuTri(), btnLSDT, panelHienThi);
        }

        private void btnDVSD_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new DVSuDung(), btnDVSD, panelHienThi);
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new DonThuocBN(), btnDT, panelHienThi);
        }
    }
}
