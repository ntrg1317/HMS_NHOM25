using HMS_NHOM25.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class DonThuoc : Form
    {
        BaseModel basemodel = new BaseModel();
        private string table = "donThuoc";
        public DonThuoc()
        {
            InitializeComponent();
        }

        private void DonThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoDSDonThuoc.DataSource = basemodel.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvInfoDSDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDT.Text = dgvInfoDSDonThuoc.SelectedRows[0].Cells[0].Value.ToString();
            txtMaBN.Text = dgvInfoDSDonThuoc.SelectedRows[0].Cells[1].Value.ToString();
            dateNgayKeDon.Text = dgvInfoDSDonThuoc.SelectedRows[0].Cells[2].Value.ToString();
            txtTrangThaiTT.Text = dgvInfoDSDonThuoc.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void txtTimKiemSDTBN_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiemSDTBN.Text.Trim();
            if (timKiem == "")
            {
                DonThuoc_Load(sender, e);
            }
            else
            {
                string query1 = "SELECT MaBN FROM benhNhan WHERE SDT LIKE '%" + timKiem + "%'";
                DataTable resultTable = basemodel.Table(query1);

                if (resultTable.Rows.Count > 0)
                {
                    string maBenhNhan = resultTable.Rows[0]["MaBN"].ToString();
                    string query2 = "SELECT * FROM donThuoc WHERE MaBN LIKE '%" + maBenhNhan + "%'";
                    dgvInfoDSDonThuoc.DataSource = basemodel.Table(query2);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy số điện thoại nào khớp.");
                }

            }
        }

        private void btnThemDonThuoc_Click(object sender, EventArgs e)
        {
            AddDonThuoc addDonThuoc = new AddDonThuoc();
            addDonThuoc.Show();
        }

        private void btnXoaDonThuoc_Click(object sender, EventArgs e)
        {
            string choose = dgvInfoDSDonThuoc.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "DELETE donThuoc";
            query1 += "Where MaDT ='" + choose + "'";
            string query2 = "DELETE donThuocChiTiet";
            query2 += "Where MaDT ='" + choose + "'";
            if (dgvInfoDSDonThuoc.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        basemodel.Command(query1);
                        basemodel.Command(query2);
                        MessageBox.Show("Xóa thông tin thành công!");
                        DonThuoc_Load(sender, e);
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
            ChiTietDonThuoc chiTietDT = new ChiTietDonThuoc();
            chiTietDT.Show();
        }
    }
}