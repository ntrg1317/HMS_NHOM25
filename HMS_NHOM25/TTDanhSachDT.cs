using HMS_NHOM25.Model;
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
    public partial class TTDanhSachDT : Form
    {
        BaseModel basemodel = new BaseModel();
        private string table = "donThuoc";

        public TTDanhSachDT()
        {
            InitializeComponent();
        }

        private void TTDanhSachDT_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDSDonThuoc.DataSource = basemodel.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnChiTietDT_Click(object sender, EventArgs e)
        {
            TTDonThuocBN tTDonThuocBN = new TTDonThuocBN();
            tTDonThuocBN.Show();
        }
    }
}
