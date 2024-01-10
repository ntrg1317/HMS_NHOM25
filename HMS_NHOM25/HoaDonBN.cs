using System;
﻿using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class HoaDon : Form
    {
        BaseModel basemodel = new BaseModel();
        HoaDonParams hdp;

        private string table = "benhNhan";
        public HoaDon()
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

        private void btnSaveTT_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(txtTongTien.Text) <= 0)
            {
                MessageBox.Show("Không thể tạo hóa đơn cho bệnh nhân có trạng thái không hoạt động!");
            }
            else
            {
                if (CheckTextBoxes())
                {
                    using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
                    {
                        sqlConnection.Open();
                        SqlTransaction transaction = sqlConnection.BeginTransaction();

                        GetValuesTextBoxes();

                        try
                        {
                            if (MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                string query1 = "INSERT INTO hoaDon (MaBN, NgayTT, TongTien) VALUES " + "(N'" + hdp.MaBN + "', N'" + hdp.NgayTT + "', N'" + hdp.TongTien + "')";
                                basemodel.Command(query1);

                                transaction.Commit();

                                MessageBox.Show("Lưu thông tin thành công!");
                                HoaDon_Load(sender, e);
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
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            DeleteTextBoxes();
            dateNgayTT.Value = DateTime.Now;
        }

        private void DeleteTextBoxes()
        {
            txtBenhTrang.Text = "";
            txtHoTen.Text = "";
            txtSexBN.Text = "";
            txtTimKiemSDTBN.Text = "";
            txtTongTien.Text = "";
            dateNgayVao.Text = "";
            dateNgayTT.Text = "";
            dateNgaySinh.Text = "";
            txtDiaChiBN.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if(txtTimKiemSDTBN.Text == "")
            {
                MessageBox.Show("Bạn chưa tìm kiếm bệnh nhân!"); return false;
            }
            if (dateNgayTT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày thanh toán!"); return false;
            }
            if (txtTongTien.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tổng tiền!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _maBN = txtMaBN.Text;
            string _ngayTT = dateNgayTT.Text;
            string _tongTien = txtTongTien.Text;
            hdp = new HoaDonParams(_maBN, _ngayTT, _tongTien);
        }

        private void dgvInforBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgvInforBN.Rows[e.RowIndex];

                    txtMaBN.Text = selectedRow.Cells["MaBN"].Value.ToString();
                    txtSexBN.Text = selectedRow.Cells["GioiTinh"].Value.ToString();
                    txtDiaChiBN.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                    txtBenhTrang.Text = selectedRow.Cells["BenhTrang"].Value.ToString();
                    txtHoTen.Text = selectedRow.Cells["TenBN"].Value.ToString();
                    dateNgaySinh.Text = selectedRow.Cells["NgaySinh"].Value.ToString();
                    dateNgayVao.Text = selectedRow.Cells["NgayVao"].Value.ToString();

                    string maBN = selectedRow.Cells["MaBN"].Value.ToString();

                    string query = @"
SELECT 
    benhNhan_dichVu.MaDV AS 'Mã dịch vụ/Mã đơn thuốc',
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
    AND LS.NgayVao <= benhNhan_dichVu.NgayDung
    AND benhNhan_dichVu.NgayDung <= GETDATE() 
    AND BN.TrangThai = 1

UNION

SELECT 
    DonThuoc.MaDT AS 'Mã dịch vụ/Mã đơn thuốc',
    ISNULL(khoThuoc.TienThuoc, 0) AS 'Giá tiền'
FROM 
    benhNhan BN
INNER JOIN 
    DonThuoc ON BN.MaBN = DonThuoc.MaBN
INNER JOIN
    benhNhan_lichSu LS ON BN.MaBN = LS.MaBN
LEFT JOIN 
    donThuocChiTiet ON DonThuoc.MaDT = donThuocChiTiet.MaDT
LEFT JOIN 
    khoThuoc ON donThuocChiTiet.MaThuoc = khoThuoc.MaThuoc
WHERE 
    BN.MaBN = @MaBN
    AND LS.NgayVao <= DonThuoc.NgayKeDon
    AND DonThuoc.NgayKeDon <= GETDATE()
    AND BN.TrangThai = 1;";




                    DataTable resultTable = basemodel.Table(query, new Dictionary<string, object> { { "@MaBN", maBN } });
                    dgvChiTietHD.DataSource = resultTable;

                    decimal totalGiaTien = 0;
                    if (resultTable.Rows.Count > 0)
                    {
                        totalGiaTien = resultTable.AsEnumerable()
                            .Sum(row => row.Field<decimal>("Giá tiền"));
                    }

                    txtTongTien.Text = totalGiaTien.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtTimKiemSDTBN_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiemSDTBN.Text.Trim();

            if (timKiem == "")
            {
                HoaDon_Load(sender, e);
            }
            else
            {
                string query = "SELECT bn.MaBN, bn.TenBN,bn.NgaySinh,bn_ls.NgayVao, bn.GioiTinh, bn_ls.BenhTrang, bn.DiaChi, bn.SDT " +
                    "FROM benhNhan AS bn  " +
                    "JOIN benhNhan_lichSu AS bn_ls " +
                    "ON bn.MaBN = bn_ls.MaBN " +
                    "WHERE SDT like '%" + timKiem + "%'";

                dgvInforBN.DataSource = basemodel.Table(query);
            }
        }
    }
}
