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
    public partial class DuocSi : Form
    {
        BaseModel ds = new BaseModel();
        DuocSiParams duocSi;
        private string table = "duocSi";
        public DuocSi()
        {
            InitializeComponent();
        }

        private void txtTimKiemNVYTe_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiemDS.Text.Trim();
            if (timKiem == "")
            {
                DS_Load(sender, e);
            }
            else
            {
                string query = "Select * from nhanVienYTe where TenNV like '%" + timKiem + "%'";
                dgvInfoDS.DataSource = ds.Table(query);
            }
        }

        private void dgvInfoNVYTe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaDS.Text = dgvInfoDS.SelectedRows[0].Cells[0].Value.ToString();
                txtTenDS.Text = dgvInfoDS.SelectedRows[0].Cells[1].Value.ToString();
                DOBDS.Text = dgvInfoDS.SelectedRows[0].Cells[2].Value.ToString();
                GetSelectedValue(dgvInfoDS.SelectedRows[0].Cells[3].Value.ToString(), cobGioiTinhDS);
                txtSDTDS.Text = dgvInfoDS.SelectedRows[0].Cells[4].Value.ToString();
                GetSelectedValue(dgvInfoDS.SelectedRows[0].Cells[5].Value.ToString(), cobDiaChiDS);
                string trangThaiValue = dgvInfoDS.SelectedRows[0].Cells[6].Value.ToString();
                MessageBox.Show(trangThaiValue);
                int _trangThai;
                if (int.TryParse(trangThaiValue, out _trangThai))
                {
                    if (_trangThai == 1)
                    {
                        cobTrangThaiDS.Text = "Hoạt động";
                    }
                    else
                    {
                        cobTrangThaiDS.Text = "Ngừng hoạt động";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnThemDSi_Click(object sender, EventArgs e)
        {
            AddDuocSi addDS = new AddDuocSi();
            addDS.Show();
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

        private void txtSDTDS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DS_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoDS.DataSource = ds.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool CheckTextBoxes()
        {
            if (txtTenDS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (DOBDS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!"); return false;
            }
            if (cobGioiTinhDS.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính!"); return false;
            }
            if (txtSDTDS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!"); return false;
            }
            if (cobDiaChiDS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenDS = txtTenDS.Text;
            string _ngaySinh = DOBDS.Text;
            string _gioiTinh = cobGioiTinhDS.Text;
            string _sdt = txtSDTDS.Text;
            string _diaChi = cobDiaChiDS.Text;
            string _trangThai = cobTrangThaiDS.Text;
            duocSi = new DuocSiParams(_tenDS, _ngaySinh, _gioiTinh, _sdt, _diaChi, null, null, _trangThai);
        }

        private void btnSuaDS_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE duocSi SET " +
                        $"TenNV = N'{duocSi.TenNV}', " +
                        $"NgaySinh = N'{duocSi.NgaySinh}', " +
                        $"GioiTinh = N'{duocSi.GioiTinh}', " +
                        $"SDT = N'{duocSi.Sdt}'," +
                        $"DiaChi = N'{duocSi.DiaChi}', " +
                        $"TrangThai = '{duocSi.TrangThai}' " +
                        $"WHERE MaBN = '{txtMaDS.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        ds.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        DS_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
