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
            try
            {
                dgvInforDichVu.DataSource = dv.all(table);
                showComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenDV = cobTenDV.Text;
            string _tienDV = txtGiaDV.Text;

            dvp =  new DichVuParams(_tenDV, _tienDV, null) ;
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
            string choose = dgvInforDichVu.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "DELETE dichVu";
            query1 += "Where MaDT ='" + choose + "'";
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

        private void dgvInforDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaDV.Text = dgvInforDichVu.SelectedRows[0].Cells[0].Value.ToString();
                GetSelectedValue(dgvInforDichVu.SelectedRows[0].Cells[1].Value.ToString(), cobTenDV);
                txtGiaDV.Text = dgvInforDichVu.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showComboBox()
        {
            DataTable dt = dv.all("dichVu");

            cobTenDV.DataSource = dt;
            cobTenDV.DisplayMember = "TenDV";
            cobTenDV.ValueMember = "MaDV";

            cobTenDV.SelectedIndex = -1;
        }
    }
}
