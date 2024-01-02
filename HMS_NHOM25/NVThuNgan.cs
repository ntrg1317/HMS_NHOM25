using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
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
        BaseModel nvtn = new BaseModel();
        private string table = "nhanVienThuNgan";
        public NVThuNgan()
        {
            InitializeComponent();
        }

        private void btnThemNVTN_Click(object sender, EventArgs e)
        {
            AddNVTN addNVTN = new AddNVTN();
            addNVTN.Show();
        }

        private void NVThuNgan_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoNVTN.DataSource = nvtn.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvInfoNVTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNVTN.Text = dgvInfoNVTN.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNVTN.Text = dgvInfoNVTN.SelectedRows[0].Cells[1].Value.ToString();
            DOBNVTN.Text = dgvInfoNVTN.SelectedRows[0].Cells[2].Value.ToString();
            cobGioiTinhNVTN.Text = dgvInfoNVTN.SelectedRows[0].Cells[3].Value.ToString();
            txtSDTNVTN.Text = dgvInfoNVTN.SelectedRows[0].Cells[4].Value.ToString();
            cobDiaChiNVTN.Text = dgvInfoNVTN.SelectedRows[0].Cells[5].Value.ToString();
            cobTrangThaiNVTN.Text = dgvInfoNVTN.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void txtTimKiemNVTN_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiemNVTN.Text.Trim();
            if (timKiem == "")
            {
                NVThuNgan_Load(sender, e);
            }
            else
            {
                string query = "Select * from nhanVienThuNgan where TenNV like '%" + timKiem + "%'";
                dgvInfoNVTN.DataSource = nvtn.Table(query);
            }
        }
    }
}
