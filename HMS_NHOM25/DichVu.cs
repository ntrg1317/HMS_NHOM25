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
    }
}
