using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class BenhNhan : Form
    {
        readonly BaseModel benhNhan = new BaseModel();
        Params.BenhNhan bn;

        private readonly string table = "benhNhan";
        public BenhNhan()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoBN.DataSource = benhNhan.all(table);

                dgvInfoBN.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
                dgvInfoBN.Columns["TenBN"].HeaderText = "Tên bệnh nhân";
                dgvInfoBN.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvInfoBN.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgvInfoBN.Columns["SDT"].HeaderText = "Số Điện Thoại";
                dgvInfoBN.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvInfoBN.Columns["SDTNguoiThan"].HeaderText = "Số Điện Thoại Người Thân";
                dgvInfoBN.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtTimKiemBN_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiemBN.Text.Trim();

            if (timKiem == "")
            {
                Patients_Load(sender, e);
            }
            else
            {
                string query = "Select * from benhNhan where TenBN like '%" + timKiem + "%'";

                dgvInfoBN.DataSource = benhNhan.Table(query);
            }
        }

        private void dgvInfoBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaBN.Text = dgvInfoBN.SelectedRows[0].Cells[0].Value.ToString();
                txtTenBN.Text = dgvInfoBN.SelectedRows[0].Cells[1].Value.ToString();
                DOBBN.Text = dgvInfoBN.SelectedRows[0].Cells[2].Value.ToString();
                GetSelectedValue(dgvInfoBN.SelectedRows[0].Cells[3].Value.ToString(), cobGioiTinhBN);
                txtSDTBN.Text = dgvInfoBN.SelectedRows[0].Cells[4].Value.ToString();
                GetSelectedValue(dgvInfoBN.SelectedRows[0].Cells[5].Value.ToString(), cobDiaChiBN);
                txtSDTNguoiThan.Text = dgvInfoBN.SelectedRows[0].Cells[6].Value.ToString();
                string trangThaiValue = dgvInfoBN.SelectedRows[0].Cells[7].Value.ToString();
                if (int.TryParse(trangThaiValue, out int _trangThai))
                {
                    if (_trangThai == 1)
                    {
                        cobTrangThaiBN.Text = "Hoạt động";
                    }
                    else
                    {
                        cobTrangThaiBN.Text = "Ngừng hoạt động";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            ThemBenhNhan addBn = new ThemBenhNhan();
            addBn.Show();
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
            if (txtTenBN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (DOBBN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!"); return false;
            }
            if (cobGioiTinhBN.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính!"); return false;
            }
            if (txtSDTBN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!"); return false;
            }
            if (txtSDTBN.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại có tối đa 10 chữ số!"); return false;
            }
            if (txtSDTNguoiThan.Text != "" && txtSDTNguoiThan.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại có tối đa 10 chữ số!"); return false;
            }
            if (cobDiaChiBN.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenBN = txtTenBN.Text;
            string _ngaySinh = DOBBN.Text;
            string _gioiTinh = cobGioiTinhBN.Text;
            string _sdt = txtSDTBN.Text;
            string _diaChi = cobDiaChiBN.Text;
            string _sdtNguoiThan = txtSDTNguoiThan.Text;
            string _trangThai = cobTrangThaiBN.Text;

            bn = new Params.BenhNhan(_tenBN, _ngaySinh, _gioiTinh, _sdt, _diaChi, _sdtNguoiThan, _trangThai, null, null);
        }

        private void btnSuaBN_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE benhNhan SET " +
                        $"TenBN = N'{bn.TenBN}', " +
                        $"NgaySinh = N'{bn.NgaySinh}', " +
                        $"SDT = N'{bn.Sdt}'," +
                        $"DiaChi = N'{bn.DiaChi}', " +
                        $"SDTNguoiThan = N'{bn.SdtNguoiThan}', " +
                        $"TrangThai = '{bn.TrangThai}' " +
                        $"WHERE MaBN = '{txtMaBN.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        benhNhan.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        Patients_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaBN_Click(object sender, EventArgs e)
        {
            string choose = dgvInfoBN.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "DELETE benhNhan";
            query1 += "Where MaBN ='" + choose + "'";
            string query2 = "DELETE taiKhoan";
            query2 += "Where MaTK ='" + choose + "'";
            if (dgvInfoBN.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        benhNhan.Command(query1);
                        benhNhan.Command(query2);
                        MessageBox.Show("Xóa thông tin thành công!");
                        Patients_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void txtSDTBN_KeyPress(object sender, KeyPressEventArgs e)
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
