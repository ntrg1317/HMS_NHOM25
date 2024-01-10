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
    public partial class QLNS : Form
    {
        Function function = new Function();
        public QLNS()
        {
            InitializeComponent();
        }

        

        private void btnDSBS_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new BacSi(), btnDSBS, panelHienThi);
        }

        private void btnDSDuocSi_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new DuocSi(), btnDSDuocSi, panelHienThi);
        }

        private void btnDSNVTN_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new NVThuNgan(), btnDSNVTN, panelHienThi);
        }

        private void btnQTV_Click(object sender, EventArgs e)
        {
            function.OpenChildForm(new QuanTriVien(), btnQTV, panelHienThi);
        }
    }
}
