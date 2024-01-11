using GMap.NET.MapProviders;
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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class QLPhong : Form
    {
        BaseModel phong = new BaseModel();
        public QLPhong()
        {
            InitializeComponent();
        }

        private void panelHienThi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QLPhong_Load(object sender, EventArgs e)
        {
            try
            {
                string showTrangThai = @"SELECT 
                                            p.MaPhong, 
                                            p.TenPhong, 
                                            ISNULL(COUNT(DISTINCT bn_ls.MaBN), 0) AS SLGiuongDaDung,
                                            (p.SLGiuong - ISNULL(COUNT(DISTINCT bn_ls.MaBN), 0)) AS SLGiuongTrong,
                                            CASE
                                                WHEN(p.SLGiuong - ISNULL(COUNT(DISTINCT bn_ls.MaBN), 0)) > 0 THEN N'Còn'
                                                ELSE N'Hết'
                                            END AS trangThai
                                                        FROM
                                            phong AS p
                                        LEFT JOIN(
                                            SELECT DISTINCT MaPhong, bn_ls.MaBN
                                            FROM benhNhan_lichSu as bn_ls

                                                JOIN benhNhan as bn ON bn.MaBN = bn_ls.MaBN
                                            WHERE bn.TrangThai = 1
                                        ) AS bn_ls ON p.MaPhong = bn_ls.MaPhong
                                        GROUP BY
                                            p.MaPhong, p.TenPhong, p.SLGiuong;";
                dgvTrangThaiPhong.DataSource = phong.Table(showTrangThai);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            dgvTrangThaiPhong.Columns["MaPhong"].HeaderText = "Mã Phòng";
            dgvTrangThaiPhong.Columns["TenPhong"].HeaderText = "Tên Phòng";
            dgvTrangThaiPhong.Columns["SLGiuongDaDung"].HeaderText = "SL Giường Đã Dùng";
            dgvTrangThaiPhong.Columns["SLGiuongTrong"].HeaderText = "SL Giường Trống";
            dgvTrangThaiPhong.Columns["trangThai"].HeaderText = "Trạng Thái";
        }

        private void dgvTrangThaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChiTietPhong.Enabled = true;
            txtMaPhong.Text = dgvTrangThaiPhong.SelectedRows[0].Cells["MaPhong"].Value.ToString();
            txtTenPhong.Text = dgvTrangThaiPhong.SelectedRows[0].Cells["TenPhong"].Value.ToString();
            txtSLGDaDung.Text = dgvTrangThaiPhong.SelectedRows[0].Cells["SLGiuongDaDung"].Value.ToString();
            txtSLGTrong.Text = dgvTrangThaiPhong.SelectedRows[0].Cells["SLGiuongTrong"].Value.ToString();
        }

        private void btnChiTietPhong_Click(object sender, EventArgs e)
        {
            string MaPhong = txtMaPhong.Text;
            string TenPhong = txtTenPhong.Text;
            ChiTietPhong phong = new ChiTietPhong(MaPhong, TenPhong);
            phong.Show();
        }
    }
}
