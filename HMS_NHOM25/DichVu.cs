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

        private void dgvInforDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDV.Text = dgvInforDichVu.SelectedRows[0].Cells[0].Value.ToString();
            txtTenDV.Text = dgvInforDichVu.SelectedRows[0].Cells[1].Value.ToString();
            txtGiaDV.Text = dgvInforDichVu.SelectedRows[0].Cells[2].Value.ToString();
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
            txtTenDV.Text = "";
            txtGiaDV.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if (txtTenDV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if(txtGiaDV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenDV = txtTenDV.Text;
            string _tienDV = txtGiaDV.Text;

            dvp = new DichVuParams(_tenDV, _tienDV);
        }
    }
}
