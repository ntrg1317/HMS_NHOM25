using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class Patients : Form
    {
        readonly BaseModel benhNhan = new BaseModel();
        BenhNhan bn;

        private readonly string table = "benhNhan";
        public Patients()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            showComboBox();
            try
            {
                dgvInfoBN.DataSource = benhNhan.all(table);
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
                txtTenBN.Text = dgvInfoBN.SelectedRows[0].Cells[2].Value.ToString();
                DOBBN.Text = dgvInfoBN.SelectedRows[0].Cells[3].Value.ToString();
                DateVaoVienBN.Text = dgvInfoBN.SelectedRows[0].Cells[4].Value.ToString();
                GetSelectedValue(dgvInfoBN.SelectedRows[0].Cells[5].Value.ToString(), cobGioiTinhBN);
                txtBenhTrangBN.Text = dgvInfoBN.SelectedRows[0].Cells[6].Value.ToString();
                txtSDTBN.Text = dgvInfoBN.SelectedRows[0].Cells[7].Value.ToString();
                GetSelectedValue(dgvInfoBN.SelectedRows[0].Cells[8].Value.ToString(), cobDiaChiBN);
                txtSDTNguoiThan.Text = dgvInfoBN.SelectedRows[0].Cells[9].Value.ToString();
                string trangThaiValue = dgvInfoBN.SelectedRows[0].Cells[10].Value.ToString();
                if (int.TryParse(trangThaiValue, out int _trangThai))
                {
                    if (_trangThai == 1)
                    {
                        cobTrangThaiBN.Text = "Hoạt động";
                        btnThemDV.Enabled = true;
                    }
                    else
                    {
                        cobTrangThaiBN.Text = "Ngừng hoạt động";
                        btnThemDV.Enabled = false;
                    }
                }
                string tenPhongValue = dgvInfoBN.SelectedRows[0].Cells[1].Value.ToString();
                int _tenPhong = int.Parse(tenPhongValue);
                switch (_tenPhong)
                {
                    case 1:
                        cobTenPhong.Text = "P101";
                        break;
                    case 2:
                        cobTenPhong.Text = "P102";
                        break;
                    case 3:
                        cobTenPhong.Text = "P103";
                        break;
                    case 4:
                        cobTenPhong.Text = "P104";
                        break;
                    case 5:
                        cobTenPhong.Text = "P105";
                        break;
                    case 6:
                        cobTenPhong.Text = "P106";
                        break;
                    case 7:
                        cobTenPhong.Text = "P107";
                        break;
                    case 8:
                        cobTenPhong.Text = "P108";
                        break;
                    case 9:
                        cobTenPhong.Text = "P109";
                        break;
                    case 10:
                        cobTenPhong.Text = "P110";
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            AddPatients addBn = new AddPatients();
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
            object _maPhong = (cobTenPhong.SelectedIndex != -1) ? (int)cobTenPhong.SelectedValue : (object)DBNull.Value;
            string _ngaySinh = DOBBN.Text;
            string _ngayVao = DateVaoVienBN.Text;
            string _gioiTinh = cobGioiTinhBN.Text;
            string _benhTrang = txtBenhTrangBN.Text;
            string _sdt = txtSDTBN.Text;
            string _diaChi = cobDiaChiBN.Text;
            string _sdtNguoiThan = txtSDTNguoiThan.Text;
            string _trangThai = cobTrangThaiBN.Text;

            bn = new BenhNhan(_tenBN, _maPhong, _ngaySinh, _ngayVao, _gioiTinh, _benhTrang, _sdt, _diaChi, _sdtNguoiThan, _trangThai, null, null);
        }

        private void btnSuaBN_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE benhNhan SET " +
                        $"TenBN = N'{bn.TenBN}', " +
                        $"MaPhong = N'{bn.MaPhong}', " +
                        $"NgaySinh = N'{bn.NgaySinh}', " +
                        $"NgayVao = N'{bn.NgayVao}', " +
                        $"SDT = N'{bn.Sdt}'," +
                        $"DiaChi = N'{bn.DiaChi}', " +
                        $"BenhTrang = N'{bn.BenhTrang}', " +
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

        private void showComboBox()
        {
            DataTable dt = benhNhan.all("phong");

            cobTenPhong.DataSource = dt;
            cobTenPhong.DisplayMember = "TenPhong";
            cobTenPhong.ValueMember = "MaPhong";

            cobTenPhong.SelectedIndex = -1;
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            string MaBN = txtMaBN.Text;
            AddBenhNhanDV bn_dv = new AddBenhNhanDV(MaBN);
            bn_dv.Show();
        }
    }
}
