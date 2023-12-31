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
    public partial class Phong : Form
    {
        BaseModel phong = new BaseModel();
        private string table = "phong";
        public Phong()
        {
            InitializeComponent();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInforPhong.DataSource = phong.all(table);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void txtTKTenPhong_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTKTenPhong.Text.Trim();
            if (timKiem == "")
            {
                Phong_Load(sender, e);
            }
            else
            {
                string query = "Select * from phong where TenPhong like '%" + timKiem + "%'";
                dgvInforPhong.DataSource = phong.Table(query);
            }
        }

        private void dgvInforPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhong.Text = dgvInforPhong.SelectedRows[0].Cells[0].Value.ToString();
            txtTenPhong.Text = dgvInforPhong.SelectedRows[0].Cells[1].Value.ToString();
            txtSoLuongPhong.Text = dgvInforPhong.SelectedRows[0].Cells[2].Value.ToString();
            txtGiaPhong.Text = dgvInforPhong.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
