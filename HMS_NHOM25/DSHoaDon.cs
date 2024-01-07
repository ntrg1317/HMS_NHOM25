using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class DSHoaDon : Form
    {
        BaseModel basemodel = new BaseModel();
        HoaDonParams hdp;

        private string table = "hoaDon";
        public DSHoaDon()
        {
            InitializeComponent();
        }

        private void DSHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoDSHoaDon.DataSource = basemodel.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex.Message);
            }
        }

        private void txtTimKiemSDTBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvInfoDSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaHD.Text = dgvInfoDSHoaDon.SelectedRows[0].Cells[0].Value.ToString();
                txtMaBN.Text = dgvInfoDSHoaDon.SelectedRows[0].Cells[1].Value.ToString();
                dateNgayTT.Text = dgvInfoDSHoaDon.SelectedRows[0].Cells[2].Value.ToString();
                txtTongTien.Text = dgvInfoDSHoaDon.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhatHD_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE hoaDon SET " +
                        $"NgayTT = N'{hdp.NgayTT}', " +
                        $"TongTien = N'{hdp.TongTien}' " +
                        $"WHERE MaHD = '{txtMaHD.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        basemodel.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        DSHoaDon_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            string choose = dgvInfoDSHoaDon.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "DELETE hoaDon";
            query1 += "Where MaHD ='" + choose + "'";
            if (dgvInfoDSHoaDon.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        basemodel.Command(query1);
                        MessageBox.Show("Xóa thông tin thành công!");
                        DSHoaDon_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Show();
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
    }
}
