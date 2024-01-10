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
    public partial class DVSuDung : Form
    {
        public DVSuDung()
        {
            InitializeComponent();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            string MaBN = txtMaBN.Text;
            AddBenhNhanDV bn_dv = new AddBenhNhanDV(MaBN);
            bn_dv.Show();
        }
    }
}
