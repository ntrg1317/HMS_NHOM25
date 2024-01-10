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
    public partial class DanhMuc : Form
    {
        Function function = new Function();
        public DanhMuc()
        {
            InitializeComponent();
        }

        private void btnBN_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new Patients(), btnBN, panelHienThi);
        }

        private void btnDSPhong_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new Phong(), btnDSPhong, panelHienThi);
        }

        private void btnDSDvu_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new DichVu(), btnDSDvu, panelHienThi);
        }

        private void btnDSHD_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new DSHoaDon(), btnDSHD, panelHienThi);
        }

        private void btnDSThuoc_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new KhoThuoc(), btnDSThuoc, panelHienThi);
        }

        private void btnDSDonThuoc_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new DSDonThuoc(), btnDSDonThuoc, panelHienThi);
        }

        private void btnDSNhanSu_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new QLNS(), btnDSNhanSu, panelHienThi);
        }
    }
}
