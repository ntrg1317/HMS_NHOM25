using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class KhoThuoc : Form
    {
        BaseModel basemodel = new BaseModel();
        KhoThuocParams ktp;

        private string table = "khoThuoc";
        public KhoThuoc()
        {
            InitializeComponent();
            dgvInfoKhoThuoc.DataSource = basemodel.all(table);
        }

        private void KhoThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoKhoThuoc.DataSource = basemodel.all(table);

                dgvInfoKhoThuoc.Columns["MaThuoc"].HeaderText = "Mã thuốc";
                dgvInfoKhoThuoc.Columns["TenThuoc"].HeaderText = "Tên thuốc";
                dgvInfoKhoThuoc.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvInfoKhoThuoc.Columns["NSX"].HeaderText = "NSX";
                dgvInfoKhoThuoc.Columns["HSD"].HeaderText = "HSD";
                dgvInfoKhoThuoc.Columns["TienThuoc"].HeaderText = "Tiền thuốc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }

            dgvInfoKhoThuoc.Columns["MaThuoc"].HeaderText = "Mã thuốc";
            dgvInfoKhoThuoc.Columns["TenThuoc"].HeaderText = "Tên thuốc";
            dgvInfoKhoThuoc.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvInfoKhoThuoc.Columns["NSX"].HeaderText = "NSX";
            dgvInfoKhoThuoc.Columns["HSD"].HeaderText = "HSD";
            dgvInfoKhoThuoc.Columns["TienThuoc"].HeaderText = "Tiền thuốc";
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            ThemThuoc addThuoc = new ThemThuoc();
            addThuoc.Show();
        }

        private void btnCapNhatThuoc_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE khoThuoc SET " +
                        $"TenThuoc = N'{ktp.TenThuoc}', " +
                        $"SoLuong = N'{ktp.SoLuong}', " +
                        $"NSX = N'{ktp.NSX}', " +
                        $"HSD = N'{ktp.HSD}'" +
                        $"WHERE MaThuoc = '{txtMaThuoc.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        basemodel.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        KhoThuoc_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            string choose = dgvInfoKhoThuoc.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "DELETE KhoThuoc";
            query1 += "Where MaThuoc ='" + choose + "'";
            if (dgvInfoKhoThuoc.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        basemodel.Command(query1);
                        MessageBox.Show("Xóa thông tin thành công!");
                        KhoThuoc_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void txtTimKiemThuoc_TextChanged(object sender, EventArgs e)
        {
            string name = txtTimKiemThuoc.Text.Trim();
            if (name == "")
            {
                KhoThuoc_Load(sender, e);
            }
            else
            {
                string query = "Select * from khoThuoc where TenThuoc like '%" + name + "%'";
                dgvInfoKhoThuoc.DataSource = basemodel.Table(query);
            }
        }

        private void dgvInfoKhoThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaThuoc.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[0].Value.ToString();
                txtTenThuoc.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[1].Value.ToString();
                txtSoLuongThuoc.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[2].Value.ToString();
                dateNSX.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[3].Value.ToString();
                dateHSD.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[4].Value.ToString();
                txtGiaThuoc.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckTextBoxes()
        {
            if (txtTenThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên thuốc!"); return false;
            }
            if (txtSoLuongThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!"); return false;
            }
            if (dateNSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sản xuất!"); return false;
            }
            if (dateHSD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hạn sử dụng!"); return false;
            }
            if (txtGiaThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá thuốc!"); return false;
            }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _tenThuoc = txtTenThuoc.Text;
            string _soLuong = txtSoLuongThuoc.Text;
            string _nsx = dateNSX.Text;
            string _hsd = dateHSD.Text;
            string _tienThuoc = txtGiaThuoc.Text;
            ktp = new KhoThuocParams(_tenThuoc, _soLuong, _nsx, _hsd, _tienThuoc);
        }

        private void txtGiaThuoc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoLuongThuoc_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
