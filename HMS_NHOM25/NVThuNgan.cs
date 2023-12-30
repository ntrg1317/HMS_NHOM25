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
    public partial class NVThuNgan : Form
    {
        BaseModel nhanVienThuNgan = new BaseModel();
        private string table = "nhanVienThuNgan";
        public NVThuNgan()
        {
            InitializeComponent();
        }

        private void NVThuNgan_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoNVTN.DataSource = nhanVienThuNgan.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex.Message);
            }

        }
        private void btnThemNVTN_Click(object sender, EventArgs e)
        {
            AddNVTN addNVTN = new AddNVTN();
            addNVTN.Show();
        }
    }
}
