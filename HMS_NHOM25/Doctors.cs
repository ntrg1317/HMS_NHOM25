using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class Doctors : Form
    {
        BaseModel bacSi = new BaseModel();
        BacSi qlBacSi;

        private string table = "bacSi";
        public Doctors()
        {
            InitializeComponent();
        }

        public void Doctors_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoBS.DataSource = bacSi.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void txtTimKiemBS_TextChanged(object sender, EventArgs e)
        {
            string nameBS = txtTimKiemBS.Text.Trim();
            if (nameBS == "")
            {
                Doctors_Load(sender, e);
            }
            else
            {
                string query = "Select * from bacSi where TenBS like '%" + nameBS + "%'";
                dgvInfoBS.DataSource = bacSi.Table(query);
            }
        }

        private bool CheckTextBoxes()
        {
            if (txtTenBS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (DOBBS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!"); return false;
            }
            if (cobSexBS.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính!"); return false;
            }
            if (txtSDTBS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!"); return false;
            }
            if (cobDiaChiBS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!"); return false;
            }
            if (cobChuyenMonBS.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn chuyên môn!"); return false;
            }
            if (txtBangCapBS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bằng cấp!"); return false;
            }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _tenBS = txtTenBS.Text;
            string _ngaySinh = DOBBS.Text;
            string _gioiTinh = cobSexBS.Text;
            string _sdt = txtSDTBS.Text;
            string _diaChi = cobDiaChiBS.Text;
            string _chuyenMon = cobChuyenMonBS.Text;
            string _bangCap = txtBangCapBS.Text;
            string _trangThai = cobTrangThaiBS.Text;
            qlBacSi = new BacSi(_tenBS, _ngaySinh, _gioiTinh, _sdt, _diaChi, _chuyenMon, _bangCap, null, null, _trangThai);
        }
        private void btnSuaBS_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE bacSi SET " +
                        $"TenBS = N'{qlBacSi.TenBS}', " +
                        $"NgaySinh = N'{qlBacSi.NgaySinh}', " +
                        $"GioiTinh = N'{qlBacSi.GioiTinh}', " +
                        $"SDT = N'{qlBacSi.Sdt}'," +
                        $"DiaChi = N'{qlBacSi.DiaChi}', " +
                        $"ChuyenMon = N'{qlBacSi.ChuyenMon}', " +
                        $"BangCap = N'{qlBacSi.BangCap}', " +
                        $"TrangThai = '{qlBacSi.TrangThai}' " +
                        $"WHERE MaBS = '{txtMaBS.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        bacSi.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        Doctors_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaBS_Click(object sender, EventArgs e)
        {
            string choose = dgvInfoBS.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "DELETE bacSi";
            query1 += "Where MaBS ='" + choose + "'";
            string query2 = "DELETE taiKhoan";
            query2 += "Where MaTK ='" + choose + "'";
            if (dgvInfoBS.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        bacSi.Command(query1);
                        bacSi.Command(query2);
                        MessageBox.Show("Xóa thông tin thành công!");
                        Doctors_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgvInfoBS_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtMaBS.Text = dgvInfoBS.SelectedRows[0].Cells[0].Value.ToString();
                txtTenBS.Text = dgvInfoBS.SelectedRows[0].Cells[1].Value.ToString();
                DOBBS.Text = dgvInfoBS.SelectedRows[0].Cells[2].Value.ToString();
                GetSelectedValue(dgvInfoBS.SelectedRows[0].Cells[3].Value.ToString(), cobSexBS);
                txtSDTBS.Text = dgvInfoBS.SelectedRows[0].Cells[4].Value.ToString();
                GetSelectedValue(dgvInfoBS.SelectedRows[0].Cells[5].Value.ToString(), cobDiaChiBS);
                GetSelectedValue(dgvInfoBS.SelectedRows[0].Cells[6].Value.ToString(), cobChuyenMonBS);
                txtBangCapBS.Text = dgvInfoBS.SelectedRows[0].Cells[7].Value.ToString();
                string trangThaiValue = dgvInfoBS.SelectedRows[0].Cells[8].Value.ToString();
                int _trangThai;

                if (int.TryParse(trangThaiValue, out _trangThai))
                {
                    if (_trangThai == 1)
                    {
                        cobTrangThaiBS.Text = "Hoạt động";
                    }
                    else
                    {
                        cobTrangThaiBS.Text = "Ngừng hoạt động";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnThemBS_Click(object sender, EventArgs e)
        {
            AddDoctor doctor = new AddDoctor();
            doctor.Show();
        }

        private void txtSDTBS_KeyPress(object sender, KeyPressEventArgs e)
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
