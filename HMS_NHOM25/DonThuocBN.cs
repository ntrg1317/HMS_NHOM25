using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
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
    public partial class DonThuocBN : Form
    {
        BaseModel basemodel = new BaseModel();

        public DonThuocBN()
        {
            InitializeComponent();
        }

        private void txtTimKiemSDTBN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string timKiem = txtTimKiemSDTBN.Text;
                if (timKiem == "")
                {
                    DonThuocBN_Load(sender, e);
                }
                else
                {
                    string timKiemBN = "SELECT * FROM benhNhan WHERE SDT LIKE '%" + timKiem + "%'";
                    dgvTimBN.DataSource = basemodel.Table(timKiemBN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemDonThuoc_Click(object sender, EventArgs e)
        {
            ThemDonThuoc addDonThuoc = new ThemDonThuoc();
            addDonThuoc.Show();
        }

        private void btnXoaDonThuoc_Click(object sender, EventArgs e)
        {
            string choose = dgvDSDonThuoc.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "DELETE donThuoc";
            query1 += "Where MaDT ='" + choose + "'";
            string query2 = "DELETE donThuocChiTiet";
            query2 += "Where MaDT ='" + choose + "'";
            if (dgvDSDonThuoc.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        basemodel.Command(query1);
                        basemodel.Command(query2);
                        MessageBox.Show("Xóa thông tin thành công!");
                        DonThuocBN_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
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

        private void btnCapNhatDonThuoc_Click(object sender, EventArgs e)
        {
            string maDT = dgvDSDonThuoc.SelectedRows[0].Cells[0].Value.ToString();
            string maBN = dgvDSDonThuoc.SelectedRows[0].Cells[1].Value.ToString();
            string trangThaiTT = txtTrangThaiTT.Text;
            ChiTietDonThuoc chiTietDT = new ChiTietDonThuoc(maDT, maBN, trangThaiTT);
            chiTietDT.Show();
        }

        private void dgvDSDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    btnChiTietDonThuoc.Enabled = true;
                    DataGridViewRow selectedRow = dgvDSDonThuoc.Rows[e.RowIndex];

                    txtMaDT.Text = selectedRow.Cells["MaDT"].Value.ToString();
                    dateNgayKeDon.Text = selectedRow.Cells["NgayKeDon"].Value.ToString();

                    string maBN = selectedRow.Cells["MaBN"].Value.ToString();
                    DateTime ngayKeDon = Convert.ToDateTime(selectedRow.Cells["NgayKeDon"].Value);

                    string query = "SELECT COUNT(*) FROM hoaDon WHERE MaBN = @MaBN AND (NgayTT IS NOT NULL AND NgayTT >= @NgayKeDon)";

                    DataTable resultTable = basemodel.Table(query, new Dictionary<string, object>
                    {
                        { "@MaBN", maBN },
                        { "@NgayKeDon", ngayKeDon }
                    });

                    int count = Convert.ToInt32(resultTable.Rows[0][0]);
                    txtTrangThaiTT.Text = count > 0 ? "1" : "0";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DonThuocBN_Load(object sender, EventArgs e)
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
                        DonThuocBN_Load(sender, e);
                    }
                    else
                    {
                        string timKiemBN = "SELECT * FROM donThuoc WHERE MaBN LIKE '%" + timKiem + "%'";
                        dgvDSDonThuoc.DataSource = basemodel.Table(timKiemBN);
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
    }
}