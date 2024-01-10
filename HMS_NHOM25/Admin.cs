using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
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

        private void Admin_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoQTV.DataSource = basemodel.all(table);

                dgvInfoQTV.Columns["MaQL"].HeaderText = "Mã Quản Trị Viên";
                dgvInfoQTV.Columns["TenQL"].HeaderText = "Tên Quản Trị Viên";
                dgvInfoQTV.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvInfoQTV.Columns["GioiTinhQTV"].HeaderText = "Giới Tính";
                dgvInfoQTV.Columns["SDT"].HeaderText = "Số Điện Thoại";
                dgvInfoQTV.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvInfoQTV.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
