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
    public partial class XepPhongBN : Form
    {
        BaseModel benhNhan = new BaseModel();
        public XepPhongBN() 
        { 
            InitializeComponent();
        }
        public XepPhongBN(string MaPhong, string TenPhong)
        {
            InitializeComponent();
            txtMaPhong.Text = MaPhong;
            txtTenPhong.Text = TenPhong;
        }

        private void txtSDTBN_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtSDTBN.Text.Trim();

            if (timKiem == "")
            {
                XepPhongBN_Load(sender, e);
            }
            else
            {
                string query = "SELECT bn.MaBN, bn.TenBN, bn.GioiTinh, bn_ls.BenhTrang, bn_ls.NgayVao, bn.DiaChi, bn.SDT " +
                    "FROM benhNhan AS bn  " +
                    "JOIN benhNhan_lichSu AS bn_ls " +
                    "ON bn.MaBN = bn_ls.MaBN " +
                    "WHERE SDT like '%" + timKiem + "%' " +
                    "AND bn.TrangThai = 1";

                dgvTimBN.DataSource = benhNhan.Table(query);
                dgvTimBN.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
                dgvTimBN.Columns["TenBN"].HeaderText = "Tên bệnh nhân";
                dgvTimBN.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgvTimBN.Columns["BenhTrang"].HeaderText = "Bệnh Trạng";
                dgvTimBN.Columns["NgayVao"].HeaderText = "Ngày Vào";
                dgvTimBN.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvTimBN.Columns["SDT"].HeaderText = "Số Điện Thoại";
            }
        }
        private bool CheckTextBoxes()
        {
            if (txtMaBN.Text == "")
            {
                MessageBox.Show("Chưa chọn mã bệnh nhân!"); return false;
            }
            if (txtTenBN.Text == "")
            {
                MessageBox.Show("Chưa chọn mã bệnh nhân!"); return false;
            }
            if (txtBenhTrang.Text != "")
            {
                MessageBox.Show("Chưa có bệnh trạng!"); return false;
            }
            return true;
        }

        private void btnSaveInfoDonThuoc_Click(object sender, EventArgs e)
        {
            string findBN = "SELECT MaBN FROM benhNhan_lichSu WHERE MaPhong = ";
            int count = benhNhan.GetAIntValue(findBN);

            if(count > 0)
            {
                MessageBox.Show("Đã tồn tại bệnh nhân này trong phòng!");
            }
            else
            {
                if (CheckTextBoxes())
                {
                    string insertBNPhong = "INSERT INTO benhNhan_lichSu (MaBN, MaPhong, NgayVao, BenhTrang) VALUES " +
                                "('" + txtMaBN.Text + "', N'" + txtMaPhong.Text + "' ,N'" + dateNgayVao.Text + "', N'" + txtBenhTrang.Text + "')";
                    benhNhan.Command(insertBNPhong);
                    MessageBox.Show("Xếp phòng thành công!");
                    XepPhongBN_Load(sender, e);
                }
            }
        }

        private void dgvTimBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSDTBN.Text = dgvTimBN.SelectedRows[0].Cells["SDT"].Value.ToString();
            txtMaBN.Text = dgvTimBN.SelectedRows[0].Cells["MaBN"].Value.ToString();
            txtTenBN.Text = dgvTimBN.SelectedRows[0].Cells["TenBN"].Value.ToString();
            dateNgayVao.Text = dgvTimBN.SelectedRows[0].Cells["NgayVao"].Value.ToString();
            txtBenhTrang.Text = dgvTimBN.SelectedRows[0].Cells["BenhTrang"].Value.ToString();
            txtGT.Text = dgvTimBN.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
            txtDiaChi.Text = dgvTimBN.SelectedRows[0].Cells["DiaChi"].Value.ToString();
        }

        private void btnThoatAddDonThuoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XepPhongBN_Load(object sender, EventArgs e)
        {
            
        }
    }
}
