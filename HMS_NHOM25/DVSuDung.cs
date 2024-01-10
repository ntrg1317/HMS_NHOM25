using HMS_NHOM25.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class DVSuDung : Form
    {
        BaseModel dv = new BaseModel();
        public DVSuDung()
        {
            InitializeComponent();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            string MaBN = txtMaBN.Text;
            AddBenhNhanDV bn_dv = new AddBenhNhanDV(MaBN);
            bn_dv.FormClosed += (s, args) => DVSuDung_Load(sender, e);
            bn_dv.Show();
        }

        private void txtSDTBN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string timKiem = txtSDTBN.Text;
                if (timKiem == "")
                {
                    DVSuDung_Load(sender, e);
                }
                else
                {
                    string timKiemBN = "SELECT * FROM benhNhan WHERE SDT LIKE '%" + timKiem + "%'";
                    dgvTimBN.DataSource = dv.Table(timKiemBN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DVSuDung_Load(object sender, EventArgs e)
        {

        }

        private void txtMaBN_TextChanged(object sender, EventArgs e)
        {
            string maBN = txtMaBN.Text;
            if (maBN == "")
            {
                DVSuDung_Load(sender, e);
            }
            else
            {
                string query = "SELECT dv.MaDV, TenDV, dv.TienDV, NgayDung " +
                        "FROM dichVu AS dv " +
                        "JOIN benhNhan_dichVu AS bn_dv " +
                        "ON dv.MaDV = bn_dv.MaDV " +
                        "JOIN benhNhan AS bn " +
                        "ON bn_dv.MaBN = bn.MaBN " +
                        "WHERE bn.MaBN = '" + maBN + "'";
                dgvInfoDVSD.DataSource = dv.Table(query);
            }
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
                int trangThai = int.Parse(dgvTimBN.SelectedRows[0].Cells["TrangThai"].Value.ToString());
                if (trangThai == 1)
                {
                    txtTrangThai.Text = "Hoạt động";
                    btnThemDV.Enabled = true;
                }    
                else
                {
                    txtTrangThai.Text = "Ngừng hoạt động";
                    btnThemDV.Enabled = false;
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInfoDVSD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDV.Text = dgvInfoDVSD.SelectedRows[0].Cells["MADV"].Value.ToString();
            txtTenDV.Text = dgvInfoDVSD.SelectedRows[0].Cells["TenDV"].Value.ToString();
            txtTienDV.Text = dgvInfoDVSD.SelectedRows[0].Cells["TienDV"].Value.ToString();
            txtNgayDung.Text = dgvInfoDVSD.SelectedRows[0].Cells["NgayDung"].Value.ToString();
        }
    }
}
