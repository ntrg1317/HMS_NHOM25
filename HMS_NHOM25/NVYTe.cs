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
    public partial class NVYTe : Form
    {
        BaseModel nhanVienYTe = new BaseModel();
        private string table = "nhanVienYTe";
        public NVYTe()
        {
            InitializeComponent();
        }

        private void btnThemNVYTe_Click(object sender, EventArgs e)
        {
            AddNVYTe addNVYTe = new AddNVYTe();
            addNVYTe.Show();
        }

        private void NVYTe_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoNVYTe.DataSource = nhanVienYTe.all(table);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " +  ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiemNVYTe_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiemNVYTe.Text.Trim();
            if (timKiem == "")
            {
                NVYTe_Load(sender, e);
            }
            else
            {
                string query = "Select * from nhanVienYTe where TenNV like '%" + timKiem + "%'";
                dgvInfoNVYTe.DataSource = nhanVienYTe.Table(query);
            }
        }

        private void dgvInfoNVYTe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNVYTe.Text = dgvInfoNVYTe.SelectedRows[0].Cells[0].Value.ToString();
            txtTenNVYTe.Text = dgvInfoNVYTe.SelectedRows[0].Cells[1].Value.ToString();
            DOBNVYTe.Text = dgvInfoNVYTe.SelectedRows[0].Cells[2].Value.ToString();
            cobGioiTinhNVYTe.Text = dgvInfoNVYTe.SelectedRows[0].Cells[3].Value.ToString();
            txtSDTNVYTe.Text = dgvInfoNVYTe.SelectedRows[0].Cells[4].Value.ToString();
            txtDiaChiNVYT.Text = dgvInfoNVYTe.SelectedRows[0].Cells[5].Value.ToString();
            cobTrangThaiNVYTe.Text = dgvInfoNVYTe.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
