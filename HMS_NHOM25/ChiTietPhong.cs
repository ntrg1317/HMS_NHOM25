﻿using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ChiTietPhong : Form
    {
        BaseModel ctphong = new BaseModel();
        BenhNhan_LichSuParams bn_ls;
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
                                    "WHERE p.MaPhong = '" + MaPhong + "' " +
                                    "AND bn.TrangThai = 1";
                dgvCTPhong.DataSource = ctphong.Table(showTatCaBN);

                dgvCTPhong.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
                dgvCTPhong.Columns["TenBN"].HeaderText = "Tên bệnh nhân";
                dgvCTPhong.Columns["NgayVao"].HeaderText = "Ngày Vào";
                dgvCTPhong.Columns["BenhTrang"].HeaderText = "Bệnh Trạng";
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DeleteTextBoxes();
        }

        private void btnThemBN_Phong_Click(object sender, EventArgs e)
        {
            XepPhongBN xepPhongBN = new XepPhongBN(txtMaPhong.Text, txtTenPhong.Text);
            xepPhongBN.Show();
        }

        private void DeleteTextBoxes()
        {
            txtMaBN.Text = "";
            txtTenBN.Text = "";
            dateNgayVao.Text = "";
            txtBenhTrang.Text = "";
        }

        private void GetValuesTextBoxes()
        {
            string _maBN = txtMaBN.Text;
            string _tenBN = txtTenBN.Text;  
            string _ngayVao = dateNgayVao.Text;
            string _benhTrang = txtBenhTrang.Text;

            bn_ls = new BenhNhan_LichSuParams(_maBN, _tenBN, _ngayVao, _benhTrang);
        }

        private bool CheckTextBoxes()
        {
            if (txtMaBN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (txtMaBN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!"); return false;
            }
            if (dateNgayVao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!"); return false;
            }
            if (txtBenhTrang.Text == "")
            {
                MessageBox.Show("Số điện thoại có tối đa 10 chữ số!"); return false;
            }
            return true;
        }
    }
}
