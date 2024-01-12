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
                string timKiem = txtTimKiemSDTBN.Text.Trim();

                if (timKiem == "")
                {
                    QLHoaDon_Load(sender, e);
                }
                else
                {
                    string query = "SELECT bn.MaBN, bn.TenBN,bn.NgaySinh,bn_ls.NgayVao, bn.GioiTinh, bn_ls.BenhTrang, bn.DiaChi, bn.SDT " +
                   "FROM benhNhan AS bn  " +
                   "JOIN benhNhan_lichSu AS bn_ls " +
                   "ON bn.MaBN = bn_ls.MaBN " +
                   "WHERE SDT like '%" + timKiem + "%'";

                    DataTable resultTable = basemodel.Table(query);

                    if (resultTable.Rows.Count > 0)
                    {
                        dgvTimBN.DataSource = resultTable;
                    }
                    else
                    {
                        dgvTimBN.DataSource = null;
                    }

                    dgvTimBN.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
                    dgvTimBN.Columns["TenBN"].HeaderText = "Tên bệnh nhân";
                    dgvTimBN.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                    dgvTimBN.Columns["NgayVao"].HeaderText = "Ngày Vào";
                    dgvTimBN.Columns["GioiTinh"].HeaderText = "Giới Tính";
                    dgvTimBN.Columns["BenhTrang"].HeaderText = "Bệnh trạng";
                    dgvTimBN.Columns["SDT"].HeaderText = "Số Điện Thoại";
                    dgvTimBN.Columns["DiaChi"].HeaderText = "Địa Chỉ";
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
                    string timKiem = txtTimKiemSDTBN.Text.Trim();

                    if (timKiem == "")
                    {
                        QLHoaDon_Load(sender, e);
                    }
                    else
                    {
                        string query = "SELECT hoaDon.MaHD, hoaDon.MaBN, benhNhan.SDT, hoaDon.NgayTT, hoaDon.TongTien " +
                                       "FROM hoaDon " +
                                       "INNER JOIN benhNhan ON hoaDon.MaBN = benhNhan.MaBN " +
                                       "WHERE benhNhan.SDT LIKE '%" + timKiem + "%'";

                        DataTable resultTable = basemodel.Table(query);

                        if (resultTable.Rows.Count > 0)
                        {
                            dgvDSHoaDonBN.DataSource = resultTable;

                            dgvDSHoaDonBN.Columns["MaHD"].HeaderText = "Mã hóa đơn";
                            dgvDSHoaDonBN.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
                            dgvDSHoaDonBN.Columns["SDT"].HeaderText = "SĐT";
                            dgvDSHoaDonBN.Columns["NgayTT"].HeaderText = "Ngày thanh toán";
                            dgvDSHoaDonBN.Columns["TongTien"].HeaderText = "Tổng tiền";
                        }
                        else
                        {
                            dgvDSHoaDonBN.DataSource = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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
                dateNgayTT.Text = dgvDSHoaDonBN.SelectedRows[0].Cells[3].Value.ToString();
                txtTongTien.Text = dgvDSHoaDonBN.SelectedRows[0].Cells[4].Value.ToString();
                if (e.RowIndex >= 0)
                {
                    string maBN = dgvDSHoaDonBN.Rows[e.RowIndex].Cells["MaBN"].Value.ToString();

                    string query = @"
                                            SELECT 
                                                benhNhan_dichVu.MaDV AS 'Mã',
                                                N'Dịch vụ' AS 'Loại',
                                                CAST(dichVu.TenDV AS NVARCHAR(100)) AS 'Tên',
                                                ISNULL(dichVu.TienDV, 0) AS 'Giá tiền'
                                            FROM 
                                                benhNhan BN
                                            INNER JOIN 
                                                benhNhan_dichVu ON BN.MaBN = benhNhan_dichVu.MaBN
                                            INNER JOIN 
                                                dichVu ON benhNhan_dichVu.MaDV = dichVu.MaDV
                                            INNER JOIN
                                                benhNhan_lichSu LS ON BN.MaBN = LS.MaBN
                                            WHERE 
                                                BN.MaBN = @MaBN

                                            UNION

                                            SELECT 
                                                donThuoc.MaDT AS 'Mã',
                                                N'Đơn thuốc' AS 'Loại',
                                                CAST(donThuoc.MaDT AS NVARCHAR(100)) AS 'Tên',
                                                ISNULL(khoThuoc.TienThuoc, 0) AS 'Giá tiền'
                                            FROM 
                                                benhNhan BN
                                            INNER JOIN 
                                                donThuoc ON BN.MaBN = donThuoc.MaBN
                                            INNER JOIN
                                                benhNhan_lichSu LS ON BN.MaBN = LS.MaBN
                                            LEFT JOIN 
                                                donThuocChiTiet ON donThuoc.MaDT = donThuocChiTiet.MaDT
                                            LEFT JOIN 
                                                khoThuoc ON donThuocChiTiet.MaThuoc = khoThuoc.MaThuoc
                                            WHERE 
                                                BN.MaBN = @MaBN

                                            UNION

                                            SELECT 
                                                phong.MaPhong AS 'Mã',
                                                N'Phòng' AS 'Loại',
                                                CAST(phong.TenPhong AS NVARCHAR(100)) AS 'Tên',
                                                ISNULL(phong.TienPhong, 0) AS 'Giá tiền'
    
                                            FROM 
                                                benhNhan BN
                                            INNER JOIN 
                                                benhNhan_lichSu LS ON BN.MaBN = LS.MaBN
                                            INNER JOIN 
                                                phong ON LS.MaPhong = phong.MaPhong
                                            WHERE 
                                                BN.MaBN = @MaBN;";

                    DataTable detailsTable = basemodel.Table(query, new Dictionary<string, object> { { "@MaBN", maBN } });
                    dgvChiTietHD.DataSource = detailsTable;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Show();
        }
    }
}
