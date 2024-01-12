using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class BenhNhan : Form
    {
        readonly BaseModel benhNhan = new BaseModel();
        Params.BenhNhan bn;
        BenhNhan_LichSuParams bn_ls;

        private readonly string table = "benhNhan";
        public BenhNhan()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT 
                                    bn.MaBN, bn.TenBN, bn_ls.NgayVao, bn_ls.BenhTrang,
                                    bn.NgaySinh, bn.GioiTinh, bn.SDT, p.TenPhong,
                                    bn.DiaChi,  bn.SDTNguoiThan, bn.TrangThai 
                                FROM 
                                    benhNhan bn 
                                LEFT JOIN 
                                    benhNhan_lichSu bn_ls ON bn_ls.MaBN = bn.MaBN 
                                LEFT JOIN 
                                    phong p ON p.MaPhong = bn_ls.MaPhong;";

                dgvInfoBN.DataSource = benhNhan.Table(query);

                dgvInfoBN.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
                dgvInfoBN.Columns["TenBN"].HeaderText = "Tên bệnh nhân";
                dgvInfoBN.Columns["NgayVao"].HeaderText = "Ngày Vào";
                dgvInfoBN.Columns["BenhTrang"].HeaderText = "Bệnh Trạng";
                dgvInfoBN.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvInfoBN.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgvInfoBN.Columns["SDT"].HeaderText = "Số Điện Thoại";
                dgvInfoBN.Columns["TenPhong"].HeaderText = "Tên Phòng";
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
                string query = @"WITH PatientRanked AS ( 
                                    SELECT 
                                        bn.MaBN, bn.TenBN, bn_ls.NgayVao, bn_ls.BenhTrang, 
				                        bn.NgaySinh, bn.GioiTinh, bn.SDT, p.TenPhong, 
				                        bn.DiaChi,  bn.SDTNguoiThan, bn.TrangThai, 
                                        ROW_NUMBER() OVER(PARTITION BY bn.MaBN ORDER BY bn_ls.ngayVao DESC) AS RowNum 
                                    FROM 
                                        benhNhan bn 
                                    LEFT JOIN 
                                        benhNhan_lichSu bn_ls ON bn.MaBN = bn_ls.MaBN 
                                    JOIN phong p ON p.MaPhong = bn_ls.MaPhong
                                    WHERE 
                                        bn_ls.ngayVao IS NOT NULL 
                                ) 
                                SELECT 
                                    MaBN, TenBN, NgayVao, BenhTrang,
		                            NgaySinh, GioiTinh, SDT, TenPhong,
		                            DiaChi,  SDTNguoiThan, TrangThai 
                                FROM 
                                    PatientRanked 
                                WHERE 
                                    RowNum = 1 AND TenBN LIKE '%" + timKiem + "'";

                dgvInfoBN.DataSource = benhNhan.Table(query);
            }
        }

        private void dgvInfoBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaBN.Text = dgvInfoBN.SelectedRows[0].Cells["MaBN"].Value.ToString();
                txtTenBN.Text = dgvInfoBN.SelectedRows[0].Cells["TenBN"].Value.ToString();
                dateNgayVao.Text = dgvInfoBN.SelectedRows[0].Cells["NgayVao"].Value.ToString();
                txtBenhTrang.Text = dgvInfoBN.SelectedRows[0].Cells["BenhTrang"].Value.ToString();
                DOBBN.Text = dgvInfoBN.SelectedRows[0].Cells["NgaySinh"].Value.ToString();
                GetSelectedValue(dgvInfoBN.SelectedRows[0].Cells["GioiTinh"].Value.ToString(), cobGioiTinhBN);
                txtSDTBN.Text = dgvInfoBN.SelectedRows[0].Cells["SDT"].Value.ToString();
                GetSelectedValue(dgvInfoBN.SelectedRows[0].Cells["DiaChi"].Value.ToString(), cobDiaChiBN);
                txtSDTNguoiThan.Text = dgvInfoBN.SelectedRows[0].Cells["SDTNguoiThan"].Value.ToString();
                string trangThaiValue = dgvInfoBN.SelectedRows[0].Cells["TrangThai"].Value.ToString();
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
                if (item.ToString().Trim() == selectedValue.Trim())
                {
                    cob.SelectedItem = item;
                    cob.Text = selectedValue;
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
            if (dateNgayVao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày vào!"); return false;
            }
            if (txtBenhTrang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bệnh trạng của bệnh nhân!"); return false;
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
            string _maBN = txtMaBN.Text;
            string _tenBN = txtTenBN.Text;
            string _ngaySinh = DOBBN.Text;
            string _gioiTinh = cobGioiTinhBN.Text;
            string _sdt = txtSDTBN.Text;
            string _diaChi = cobDiaChiBN.Text;
            string _sdtNguoiThan = txtSDTNguoiThan.Text;
            string _trangThai = cobTrangThaiBN.Text;

            string _ngayVao = dateNgayVao.Text;
            string _benhTrang = txtBenhTrang.Text;

            bn = new Params.BenhNhan(_tenBN, _ngaySinh, _gioiTinh, _sdt, _diaChi, _sdtNguoiThan, _trangThai, null, null);
            bn_ls = new BenhNhan_LichSuParams(_maBN, _ngayVao, _benhTrang);
        }

        private void btnSuaBN_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
                {
                    sqlConnection.Open();
                    SqlTransaction transaction = sqlConnection.BeginTransaction();

                    GetValuesTextBoxes();

                    string query1 = "UPDATE benhNhan SET " +
                        $"TenBN = N'{bn.TenBN}', " +
                        $"NgaySinh = N'{bn.NgaySinh}', " +
                        $"SDT = N'{bn.Sdt}'," +
                        $"DiaChi = N'{bn.DiaChi}', " +
                        $"SDTNguoiThan = N'{bn.SdtNguoiThan}', " +
                        $"TrangThai = '{bn.TrangThai}' " +
                        $"WHERE MaBN = '{txtMaBN.Text}'";

                    string query2 = "UPDATE benhNhan_lichSu SET " +
                        $"NgayVao = N'{bn_ls.NgayVao}', " +
                        $"BenhTrang = N'{bn_ls.BenhTrang}' " +
                        $"WHERE MaBN = '{bn_ls.MaBN}'";

                    try
                    {
                        if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            benhNhan.Command(query1);

                            benhNhan.Command(query2);

                            transaction.Commit();

                            MessageBox.Show("Lưu thông tin thành công!");
                            Patients_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
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
