using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class NVThuNgan : Form
    {
        BaseModel nvtn = new BaseModel();
        NVThuNganParams nv;

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
            try
            {
                txtMaNVTN.Text = dgvInfoNVTN.SelectedRows[0].Cells[0].Value.ToString();
                txtTenNVTN.Text = dgvInfoNVTN.SelectedRows[0].Cells[1].Value.ToString();
                DOBNVTN.Text = dgvInfoNVTN.SelectedRows[0].Cells[2].Value.ToString();
                GetSelectedValue(dgvInfoNVTN.SelectedRows[0].Cells[3].Value.ToString(), cobGioiTinhNVTN);
                txtSDTNVTN.Text = dgvInfoNVTN.SelectedRows[0].Cells[4].Value.ToString();
                GetSelectedValue(dgvInfoNVTN.SelectedRows[0].Cells[5].Value.ToString(), cobDiaChiNVTN);
                string trangThaiValue = dgvInfoNVTN.SelectedRows[0].Cells[6].Value.ToString();
                int _trangThai;
                if (int.TryParse(trangThaiValue, out _trangThai))
                {
                    if (_trangThai == 1)
                    {
                        cobTrangThaiNVTN.Text = "Hoạt động";
                    }
                    else
                    {
                        cobTrangThaiNVTN.Text = "Ngừng hoạt động";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnSuaNVTN_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE nhanVienThuNgan SET " +
                        $"TenNV = N'{nv.TenNV}', " +
                        $"NgaySinh = N'{nv.NgaySinh}', " +
                        $"GioiTinh = N'{nv.GioiTinh}', " +
                        $"SDT = N'{nv.Sdt}'," +
                        $"DiaChi = N'{nv.DiaChi}', " +
                        $"TrangThai = '{nv.TrangThai}' " +
                        $"WHERE MaNV = '{txtMaNVTN.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        nvtn.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        NVThuNgan_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void GetSelectedValue(string selectedValue, ComboBox cob)
        {
            foreach (object item in cob.Items)
            {
                if (item.ToString() == selectedValue.Trim())
                {
                    cob.SelectedItem = item;
                    break;
                }
            }
        }

        private bool CheckTextBoxes()
        {
            if (txtTenNVTN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (DOBNVTN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!"); return false;
            }
            if (cobGioiTinhNVTN.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính!"); return false;
            }
            if (txtSDTNVTN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!"); return false;
            }
            if (txtSDTNVTN.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại có tối đa 10 chữ số!"); return false;
            }
            if (cobDiaChiNVTN.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenNV = txtTenNVTN.Text;
            string _ngaySinh = DOBNVTN.Text;
            string _gioiTinh = cobGioiTinhNVTN.Text;
            string _sdt = txtSDTNVTN.Text;
            string _diaChi = cobDiaChiNVTN.Text;
            string _trangThai = cobTrangThaiNVTN.Text;

            nv = new NVThuNganParams(_tenNV, _ngaySinh, _gioiTinh, _sdt, _diaChi, _trangThai, null, null);
        }

        private void btnXoaNVTN_Click(object sender, EventArgs e)
        {
            string choose = dgvInfoNVTN.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "DELETE nhanVienThuNgan";
            query1 += "Where MaNV ='" + choose + "'";
            string query2 = "DELETE taiKhoan";
            query2 += "Where MaTK ='" + choose + "'";
            if (dgvInfoNVTN.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        nvtn.Command(query1);
                        nvtn.Command(query2);
                        MessageBox.Show("Xóa thông tin thành công!");
                        NVThuNgan_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void txtSDTNVTN_KeyPress(object sender, KeyPressEventArgs e)
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
