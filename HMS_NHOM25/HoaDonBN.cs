using System;
using HMS_NHOM25.Model;
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
            try
            {
                int trangThai = GetTrangThai(txtMaBN.Text);
                if (trangThai == 0)
                {
                    MessageBox.Show("Không thể tạo hóa đơn cho bệnh nhân có trạng thái không hoạt động!");
                }
                else if (trangThai == 1)
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
                                    string query2 = "UPDATE benhNhan SET TrangThai = " + 0 + "WHERE MaBN = " + hdp.MaBN;

                                    basemodel.Command(query1);
                                    basemodel.Command(query2);

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
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
                    txtMaBN.Text = dgvInforBN.SelectedRows[0].Cells["MaBN"].Value.ToString();
                    txtHoTen.Text = dgvInforBN.SelectedRows[0].Cells["TenBN"].Value.ToString();
                    dateNgaySinh.Text = dgvInforBN.SelectedRows[0].Cells["NgaySinh"].Value.ToString();
                    dateNgayVao.Text = dgvInforBN.SelectedRows[0].Cells["NgayVao"].Value.ToString();
                    txtSexBN.Text = dgvInforBN.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                    txtBenhTrang.Text = dgvInforBN.SelectedRows[0].Cells["BenhTrang"].Value.ToString();
                    txtDiaChiBN.Text = dgvInforBN.SelectedRows[0].Cells["DiaChi"].Value.ToString();

                    string maBN = txtMaBN.Text;

                    string query = @"WITH MostRecentNgayVao AS (
                                        SELECT 
                                            BN.MaBN,
                                            MAX(benhNhan_lichSu.NgayVao) AS MostRecentNgayVao
                                        FROM 
                                            benhNhan BN
                                        INNER JOIN 
                                            benhNhan_lichSu ON BN.MaBN = benhNhan_lichSu.MaBN
                                        WHERE 
                                            BN.MaBN = @MaBN
                                            AND BN.TrangThai = 1
                                        GROUP BY 
                                            BN.MaBN
                                    )

                                    SELECT 
                                        BN.MaBN,
                                        benhNhan_dichVu.MaDV AS 'Mã',
                                        N'Dịch vụ' AS 'Loại',
                                        CAST(dichVu.TenDV AS NVARCHAR(100)) AS 'Tên',
                                        ISNULL(dichVu.TienDV, 0) AS 'Giá tiền',
                                        benhNhan_dichVu.NgayDung
                                    FROM 
                                        benhNhan BN
                                    INNER JOIN 
                                        benhNhan_dichVu ON BN.MaBN = benhNhan_dichVu.MaBN
                                    INNER JOIN 
                                        dichVu ON benhNhan_dichVu.MaDV = dichVu.MaDV
                                    INNER JOIN
                                        benhNhan_lichSu ON BN.MaBN = benhNhan_lichSu.MaBN
                                    INNER JOIN 
                                        MostRecentNgayVao ON BN.MaBN = MostRecentNgayVao.MaBN
                                    WHERE 
                                        BN.TrangThai = 1
                                        AND benhNhan_lichSu.NgayVao = MostRecentNgayVao.MostRecentNgayVao
                                        AND benhNhan_dichVu.NgayDung BETWEEN MostRecentNgayVao.MostRecentNgayVao AND GETDATE()

                                    UNION

                                    SELECT 
                                        BN.MaBN,
                                        donThuoc.MaDT AS 'Mã',
                                        N'Đơn thuốc' AS 'Loại',
                                        CAST(donThuoc.MaDT AS NVARCHAR(100)) AS 'Tên',
                                        ISNULL(khoThuoc.TienThuoc, 0) AS 'Giá tiền',
                                        donThuoc.NgayKeDon
                                    FROM 
                                        benhNhan BN
                                    INNER JOIN 
                                        donThuoc ON BN.MaBN = donThuoc.MaBN
                                    INNER JOIN
                                        benhNhan_lichSu ON BN.MaBN = benhNhan_lichSu.MaBN
                                    LEFT JOIN 
                                        donThuocChiTiet ON donThuoc.MaDT = donThuocChiTiet.MaDT
                                    LEFT JOIN 
                                        khoThuoc ON donThuocChiTiet.MaThuoc = khoThuoc.MaThuoc
                                    INNER JOIN 
                                        MostRecentNgayVao ON BN.MaBN = MostRecentNgayVao.MaBN
                                    WHERE 
                                        BN.TrangThai = 1
                                        AND benhNhan_lichSu.NgayVao = MostRecentNgayVao.MostRecentNgayVao
                                        AND donThuoc.NgayKeDon BETWEEN MostRecentNgayVao.MostRecentNgayVao AND GETDATE()

                                    UNION

                                    SELECT 
                                        BN.MaBN,
                                        phong.MaPhong AS 'Mã',
                                        N'Phòng' AS 'Loại',
                                        CAST(phong.TenPhong AS NVARCHAR(100)) AS 'Tên',
                                        ISNULL(phong.TienPhong, 0) AS 'Giá tiền',
                                        benhNhan_lichSu.NgayVao
                                    FROM 
                                        benhNhan BN
                                    INNER JOIN 
                                        benhNhan_lichSu ON BN.MaBN = benhNhan_lichSu.MaBN
                                    INNER JOIN 
                                        phong ON benhNhan_lichSu.MaPhong = phong.MaPhong
                                    INNER JOIN 
                                        MostRecentNgayVao ON BN.MaBN = MostRecentNgayVao.MaBN
                                    WHERE 
                                        BN.TrangThai = 1
                                        AND benhNhan_lichSu.NgayVao = MostRecentNgayVao.MostRecentNgayVao;";


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
            try
            {
                string timKiem = txtTimKiemSDTBN.Text.Trim();

                if (timKiem == "")
                {
                    HoaDon_Load(sender, e);
                }
                else
                {
                    string query = $@"WITH PatientRanked AS (
                                        SELECT 
                                            bn.MaBN, bn.TenBN, bn_ls.NgayVao, bn_ls.BenhTrang,
				                                    bn.NgaySinh, bn.GioiTinh, bn.SDT, p.TenPhong,
				                                    bn.DiaChi,  bn.SDTNguoiThan, bn.TrangThai,
                                            ROW_NUMBER() OVER (PARTITION BY bn.MaBN ORDER BY bn_ls.ngayVao DESC) AS RowNum
                                        FROM 
                                            benhNhan bn
                                        LEFT JOIN 
                                            benhNhan_lichSu bn_ls ON bn.MaBN = bn_ls.MaBN
		                                    LEFT JOIN phong p ON p.MaPhong = bn_ls.MaPhong
                                        WHERE 
                                            bn_ls.ngayVao IS NOT NULL 
				                                    AND bn.TrangThai = 1
                                    )
                                    SELECT 
                                        MaBN, TenBN, NgayVao, BenhTrang,
		                                    NgaySinh, GioiTinh, SDT, TenPhong,
		                                    DiaChi,  SDTNguoiThan, TrangThai
                                    FROM 
                                        PatientRanked
                                    WHERE 
                                        RowNum = 1 
                                        AND SDT like '%{timKiem}%' 
                                    ORDER BY MaBN";

                    DataTable resultTable = basemodel.Table(query);

                    if (resultTable.Rows.Count > 0)
                    {
                        dgvInforBN.DataSource = resultTable;

                        dgvInforBN.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
                        dgvInforBN.Columns["TenBN"].HeaderText = "Tên bệnh nhân";
                        dgvInforBN.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                        dgvInforBN.Columns["NgayVao"].HeaderText = "Ngày Vào";
                        dgvInforBN.Columns["GioiTinh"].HeaderText = "Giới Tính";
                        dgvInforBN.Columns["BenhTrang"].HeaderText = "Bệnh trạng";
                        dgvInforBN.Columns["SDT"].HeaderText = "Số Điện Thoại";
                        dgvInforBN.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                    }
                    else
                    {
                        dgvInforBN.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public int GetTrangThai(string maBN, SqlTransaction transaction = null)
        {
            string query = "SELECT TrangThai FROM benhNhan WHERE MaBN = @MaBN";

            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection, transaction))
                {
                    command.Parameters.AddWithValue("@MaBN", maBN);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
    }
}