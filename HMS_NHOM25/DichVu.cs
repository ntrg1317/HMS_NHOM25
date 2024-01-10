using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Data;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class DichVu : Form
    {
        BaseModel dv = new BaseModel();
        DichVuParams dvp;

        private string table = "dichVu";
        public DichVu()
        {
            InitializeComponent();
        }
        private void DichVu_Load(object sender, EventArgs e)
        {
            showComboBox();
            try
            {
                dgvInforDichVu.DataSource = dv.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            dgvInforDichVu.Columns["MaDV"].HeaderText = "Mã dịch vụ";
            dgvInforDichVu.Columns["TenDV"].HeaderText = "Tên dịch vụ";
            dgvInforDichVu.Columns["TienDV"].HeaderText = "Giá";
        }

        private void txtTKTenDV_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTKTenDV.Text.Trim();
            if (timKiem == "")
            {
                DichVu_Load(sender, e);
            }
            else
            {
                string query = "Select * from dichVu where TenDV like '%" + timKiem + "%'";
                dgvInforDichVu.DataSource = dv.Table(query);
            }
        }

        private void dgvInforDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDV.Text = dgvInforDichVu.SelectedRows[0].Cells[0].Value.ToString();
            GetSelectedValue(dgvInforDichVu.SelectedRows[0].Cells[1].Value.ToString(), cobTenDV);
            txtGiaDV.Text = dgvInforDichVu.SelectedRows[0].Cells[2].Value.ToString();
            if (txtSDTBN.Text != "")
            {
                dateNgayDung.Text = dgvInforDichVu.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            AddDichVu addDV = new AddDichVu();
            addDV.Show();
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE dichVu SET " +
                        $"TenDV = N'{dvp.TenDV}', " +
                        $"TienDV = N'{dvp.TienDV}' " +
                        $"WHERE MaDV = '{txtMaDV.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        dv.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        DichVu_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            string choose = dgvInforDichVu.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "DELETE dichVu ";
            query1 += "Where MaDV = '" + choose + "'";
            if (dgvInforDichVu.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        dv.Command(query1);
                        MessageBox.Show("Xóa thông tin thành công!");
                        DichVu_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void DeleteTextBoxes()
        {
            txtMaDV.Text = "";
            cobTenDV.Text = "";
            txtGiaDV.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if (cobTenDV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (txtGiaDV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá!"); return false;
            }
            if (dateNgayDung.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ngày sử dụng dịch vụ!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenDV = cobTenDV.Text;
            string _tienDV = txtGiaDV.Text;
            string _ngayDung = dateNgayDung.Text;

            dvp = txtSDTBN.Text == "" ? new DichVuParams(_tenDV, _tienDV) : new DichVuParams(_tenDV, _tienDV, _ngayDung);
        }

        private void txtSDTBN_TextChanged(object sender, EventArgs e)
        {
            DeleteTextBoxes();
            if (txtSDTBN.Text != "")
            {
                btnThemDV.Enabled = false;
                lablNgayDung.Visible = true;
                dateNgayDung.Visible = true;
                btnXoaBNDV.Visible = true;
                btnSuaBNDV.Visible = true;
                btnXoaDV.Visible = false;
                btnSuaDV.Visible = false;
            }
            else
            {
                btnThemDV.Enabled = true;
                lablNgayDung.Visible = false;
                dateNgayDung.Visible = false;
                btnSuaBNDV.Visible = false;
                btnXoaBNDV.Visible = false;
                btnXoaDV.Visible = true;
                btnSuaDV.Visible = true;
            }

            string timKiem = txtSDTBN.Text.Trim();
            if (timKiem == "")
            {
                DichVu_Load(sender, e);
            }
            else
            {
                string query = "SELECT dv.MaDV, TenDV, dv.TienDV, bn.TenBN, bn.SDT, bn.NgayVao, NgayDung " +
                        "FROM dichVu AS dv " +
                        "JOIN benhNhan_dichVu AS bn_dv " +
                        "ON dv.MaDV = bn_dv.MaDV " +
                        "JOIN benhNhan AS bn " +
                        "ON bn_dv.MaBN = bn.MaBN " +
                        "WHERE bn.SDT LIKE '%" + timKiem + "%'";
                dgvInforDichVu.DataSource = dv.Table(query);
            }
        }

        private void btnSuaBNDV_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE dichVu SET " +
                        $"TenDV = N'{dvp.TenDV}', " +
                        $"TienDV = N'{dvp.TienDV}' " +
                        $"WHERE MaDV = '{txtMaDV.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        dv.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        DichVu_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaBNDV_Click(object sender, EventArgs e)
        {

        }

        private void showComboBox()
        {
            DataTable dt = dv.all("dichVu");

            cobTenDV.DataSource = dt;
            cobTenDV.DisplayMember = "TenDV";
            cobTenDV.ValueMember = "MaDV";

            cobTenDV.SelectedIndex = -1;
        }

        private void GetSelectedValue(string selectedValue, ComboBox cob)
        {
            foreach (object item in cob.Items)
            {
                if (item.ToString() == selectedValue.Trim())
                {
                    cob.SelectedItem = item;
                    break;
                }
            }
        }

        private void txtGiaDV_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSDTBN_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvInforDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
