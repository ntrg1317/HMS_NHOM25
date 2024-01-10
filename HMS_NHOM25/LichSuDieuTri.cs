using HMS_NHOM25.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class LichSuDieuTri : Form
    {
        BaseModel bn = new BaseModel();
        public LichSuDieuTri()
        {
            InitializeComponent();
        }

        private void txtSDTBN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string timKiem = txtSDTBN.Text;
                if (timKiem == "")
                {
                    LichSuDieuTri_Load(sender, e);
                }
                else
                {
                    string timKiemBN = "SELECT * FROM benhNhan WHERE SDT LIKE '%" + timKiem + "%'";
                    dgvTimBN.DataSource = bn.Table(timKiemBN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvTimBN.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
            dgvTimBN.Columns["TenBN"].HeaderText = "Tên bênh nhân";
            dgvTimBN.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvTimBN.Columns["GioiTinh"].HeaderText = "Giới tinh";
            dgvTimBN.Columns["SDT"].HeaderText = "SĐT";
            dgvTimBN.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvTimBN.Columns["SDTNguoiThan"].HeaderText = "SĐT người thân";
            dgvTimBN.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void LichSuDieuTri_Load(object sender, EventArgs e)
        {
        }

        private void txtMaBN_TextChanged(object sender, EventArgs e)
        {
            string maBN = txtMaBN.Text;
            string lichSuDieuTri = "SELECT NgayVao, MaPhong, BenhTrang FROM benhNhan_lichSu WHERE MaBN = '" + maBN + "'";
            dgvInfoLSDT.DataSource = bn.Table(lichSuDieuTri);
        }

        private void dgvTimBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtSDTBN.Text = dgvTimBN.SelectedRows[0].Cells["SDT"].Value.ToString();
                txtMaBN.Text = dgvTimBN.SelectedRows[0].Cells["MaBN"].Value.ToString();
                txtTenBN.Text = dgvTimBN.SelectedRows[0].Cells["TenBN"].Value.ToString();
                txtGT.Text = dgvTimBN.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                txtDiaChi.Text = dgvTimBN.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvInfoLSDT.Columns["NgayVao"].HeaderText = "Ngày vào";
            dgvInfoLSDT.Columns["MaPhong"].HeaderText = "Mã phòng";
            dgvInfoLSDT.Columns["BenhTrang"].HeaderText = "Bệnh trạng";
        }

        private void dgvInfoLSDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNgayVao.Text = dgvInfoLSDT.SelectedRows[0].Cells[0].Value.ToString();
            txtBenhTrang.Text = dgvInfoLSDT.SelectedRows[0].Cells[2].Value.ToString();
            int MaPhong = int.Parse(dgvInfoLSDT.SelectedRows[0].Cells[1].Value.ToString());
            switch (MaPhong)
            {
                case 1:
                    txtPhong.Text = "P101";
                    break;
                case 2:
                    txtPhong.Text = "P102";
                    break;
                case 3:
                    txtPhong.Text = "P103";
                    break;
                case 4:
                    txtPhong.Text = "P104";
                    break;
                case 5:
                    txtPhong.Text = "P105";
                    break;
                case 6:
                    txtPhong.Text = "P106";
                    break;
                case 7:
                    txtPhong.Text = "P107";
                    break;
                case 8:
                    txtPhong.Text = "P108";
                    break;
                case 9:
                    txtPhong.Text = "P109";
                    break;
                case 10:
                    txtPhong.Text = "P110";
                    break;
                default:
                    break;
            } 
        }
    }
}
