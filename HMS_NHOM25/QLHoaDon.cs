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
    public partial class QLHoaDon : Form
    {
        BaseModel basemodel = new BaseModel();
        public QLHoaDon()
        {
            InitializeComponent();
        }

        private void txtTimKiemSDTBN_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTimKiemSDTBN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string timKiem = txtTimKiemSDTBN.Text;
                if (timKiem == "")
                {
                   QLHoaDon_Load(sender, e);
                }
                else
                {
                    string timKiemBN = "SELECT * FROM benhNhan WHERE SDT LIKE '%" + timKiem + "%'";
                    dgvTimBN.DataSource = basemodel.Table(timKiemBN);
                    dgvTimBN.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
                    dgvTimBN.Columns["TenBN"].HeaderText = "Tên bệnh nhân";
                    dgvTimBN.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                    dgvTimBN.Columns["GioiTinh"].HeaderText = "Giới Tính";
                    dgvTimBN.Columns["SDT"].HeaderText = "Số Điện Thoại";
                    dgvTimBN.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                    dgvTimBN.Columns["SDTNguoiThan"].HeaderText = "Số Điện Thoại Người Thân";
                    dgvTimBN.Columns["TrangThai"].HeaderText = "Trạng Thái";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QLHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void dgvTimBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaBN.Text = dgvTimBN.SelectedRows[0].Cells["MaBN"].Value.ToString();
                try
                {
                    string timKiem = txtMaBN.Text;
                    if (timKiem == "")
                    {
                        QLHoaDon_Load(sender, e);
                    }
                    else
                    {
                        string timKiemHD = "SELECT * FROM hoaDon WHERE MaBN LIKE '%" + timKiem + "%'";
                        dgvDSHoaDonBN.DataSource = basemodel.Table(timKiemHD);
                        dgvDSHoaDonBN.Columns["MaHD"].HeaderText = "Mã hóa đơn";
                        dgvDSHoaDonBN.Columns["MaBN"].HeaderText = "Mã đơn thuốc";
                        dgvDSHoaDonBN.Columns["NgayTT"].HeaderText = "Ngày thanh toán";
                        dgvDSHoaDonBN.Columns["TongTien"].HeaderText = "Tổng tiền";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDSHoaDonBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dateNgayTT.Text = dgvDSHoaDonBN.SelectedRows[0].Cells[2].Value.ToString();
                txtTongTien.Text = dgvDSHoaDonBN.SelectedRows[0].Cells[3].Value.ToString();
                if (e.RowIndex >= 0)
                {
                    string maBN = dgvDSHoaDonBN.Rows[e.RowIndex].Cells["MaBN"].Value.ToString();

                    string detailsQuery = @"
                                            SELECT 
                                                benhNhan_dichVu.MaDV AS 'Mã dịch vụ/Mã đơn thuốc',
                                                ISNULL(dichVu.TienDV, 0) AS 'Giá Tiền'
                                            FROM 
                                                benhNhan BN
                                            INNER JOIN 
                                                benhNhan_dichVu ON BN.MaBN = benhNhan_dichVu.MaBN
                                            INNER JOIN 
                                                dichVu ON benhNhan_dichVu.MaDV = dichVu.MaDV
                                            WHERE 
                                                BN.MaBN = @MaBN

                                            UNION

                                            SELECT 
                                                DonThuoc.MaDT AS 'Mã dịch vụ/Mã đơn thuốc',
                                                ISNULL(khoThuoc.TienThuoc, 0) AS 'Giá Tiền'
                                            FROM 
                                                benhNhan BN
                                            INNER JOIN 
                                                DonThuoc ON BN.MaBN = DonThuoc.MaBN
                                            LEFT JOIN 
                                                donThuocChiTiet ON DonThuoc.MaDT = donThuocChiTiet.MaDT
                                            LEFT JOIN 
                                                khoThuoc ON donThuocChiTiet.MaThuoc = khoThuoc.MaThuoc
                                            WHERE 
                                                BN.MaBN = @MaBN;";

                    DataTable detailsTable = basemodel.Table(detailsQuery, new Dictionary<string, object> { { "@MaBN", maBN } });
                    dgvChiTietHD.DataSource = detailsTable;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
