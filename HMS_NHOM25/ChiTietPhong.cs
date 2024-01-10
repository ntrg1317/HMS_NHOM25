using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ChiTietPhong : Form
    {
        BaseModel ctphong = new BaseModel();
        public ChiTietPhong(string MaPhong, string TenPhong)
        {
            InitializeComponent();
            txtMaPhong.Text = MaPhong;
            txtTenPhong.Text = TenPhong;
        }

        private void ChiTietPhong_Load(object sender, EventArgs e)
        {
            try
            {
                string MaPhong = txtMaPhong.Text;
                string showTatCaBN = "SELECT bn.MaBN, bn.TenBn, bn_ls.NgayVao, bn_ls.BenhTrang " +
                                    "FROM benhNhan AS bn " +
                                    "JOIN benhNhan_lichSu AS bn_ls " +
                                    "ON bn.MaBN = bn_ls.MaBN " +
                                    "JOIN phong AS p " +
                                    "ON bn_ls.MaPhong = p.MaPhong " +
                                    "WHERE p.MaPhong = '" + MaPhong + "'";
                dgvCTPhong.DataSource = ctphong.Table(showTatCaBN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
            

        private void dgvCTPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBN.Text = dgvCTPhong.SelectedRows[0].Cells[0].Value.ToString();
            txtTenBN.Text = dgvCTPhong.SelectedRows[0].Cells[1].Value.ToString();
            dateNgayVao.Text = dgvCTPhong.SelectedRows[0].Cells[2].Value.ToString();
            txtBenhTrang.Text = dgvCTPhong.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {

        }
    }
}
