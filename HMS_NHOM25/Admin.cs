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
    public partial class Admin : Form
    {
        BaseModel basemodel = new BaseModel();
        private string table = "quanTriVien";
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void dgvInfoQTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaQTV.Text = dgvInfoQTV.SelectedRows[0].Cells[0].Value.ToString();
            txtTenQTV.Text = dgvInfoQTV.SelectedRows[0].Cells[1].Value.ToString();
            DOBQTV.Text = dgvInfoQTV.SelectedRows[0].Cells[2].Value.ToString();
            cobGioiTinhQTV.Text = dgvInfoQTV.SelectedRows[0].Cells[3].Value.ToString();
            txtSDTQTV.Text = dgvInfoQTV.SelectedRows[0].Cells[4].Value.ToString();
            cobDiaChiQTV.Text = dgvInfoQTV.SelectedRows[0].Cells[5].Value.ToString();
            cobTrangThaiQTV.Text = dgvInfoQTV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void txtTimKiemQTV_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiemQTV.Text.Trim();
            if (timKiem == "")
            {
                Admin_Load(sender, e);
            }
            else
            {
                string query = "Select * from nhanVienThuNgan where TenNV like '%" + timKiem + "%'";
                dgvInfoQTV.DataSource = basemodel.Table(query);
            }
        }

        private void txtSDTQTV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
