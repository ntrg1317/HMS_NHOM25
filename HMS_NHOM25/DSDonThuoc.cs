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
    public partial class DSDonThuoc : Form
    {
        BaseModel basemodel = new BaseModel();
        DSDonThuocParams dsDT;

        private string table = "donThuoc";
        public DSDonThuoc()
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

        private void btnThemDonThuoc_Click(object sender, EventArgs e)
        {
            ThemDonThuoc addDonThuoc = new ThemDonThuoc();
            addDonThuoc.Show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE donThuoc SET " +
                        $"NgayKeDon = N'{dsDT.NgayKeDon}' " +
                        $"WHERE MaDT = '{txtMaDT.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        basemodel.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        DSDonThuoc_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
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
                        DSDonThuoc_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgvDSDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    btnCapNhat.Enabled = true;
                    DataGridViewRow selectedRow = dgvDSDonThuoc.Rows[e.RowIndex];

                    txtMaDT.Text = selectedRow.Cells["MaDT"].Value.ToString();
                    txtMaBN.Text = selectedRow.Cells["MaBN"].Value.ToString();
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

        private void DSDonThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDSDonThuoc.DataSource = basemodel.all(table);

                dgvDSDonThuoc.Columns["MaDT"].HeaderText = "Mã đơn thuốc";
                dgvDSDonThuoc.Columns["MaBN"].HeaderText = "Mã bệnh nhân";
                dgvDSDonThuoc.Columns["NgayKeDon"].HeaderText = "Ngày kê đơn";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtTimKiemSDTBN_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiemSDTBN.Text.Trim();
            if (timKiem == "")
            {
                DSDonThuoc_Load(sender, e);
            }
            else
            {
                try
                {
                    string query1 = "SELECT MaBN FROM benhNhan WHERE SDT LIKE '%" + timKiem + "%'";
                    DataTable resultTable = basemodel.Table(query1);

                    if (resultTable.Rows.Count > 0)
                    {
                        string maBenhNhan = resultTable.Rows[0]["MaBN"].ToString();
                        string query2 = "SELECT * FROM donThuoc WHERE MaBN LIKE '%" + maBenhNhan + "%'";
                        dgvDSDonThuoc.DataSource = basemodel.Table(query2);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy số điện thoại nào khớp.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: ", ex.Message);
                }

            }
        }

        private bool CheckTextBoxes()
        {
            if (txtMaDT.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đơn thuốc cần cập nhật!"); return false;
            }
            if (txtMaBN.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đơn thuốc cần cập nhật!"); return false;
            }
            if (dateNgayKeDon.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày kê đơn!"); return false;
            }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _maDT = txtMaDT.Text;
            string _maBN = txtMaBN.Text;
            string _ngayKeDon = dateNgayKeDon.Text;
            dsDT = new DSDonThuocParams(_maDT, _maBN, _ngayKeDon);
        }
    }
}
