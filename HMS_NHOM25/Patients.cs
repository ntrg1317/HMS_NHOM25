using HMS_NHOM25.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class Patients : Form
    {
        BaseModel benhNhan = new BaseModel();
        private string table = "benhNhan";
        public Patients()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoBN.DataSource = benhNhan.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtTimKiemBN_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiemBN.Text.Trim();

            if (timKiem == "")
            {
                Patients_Load(sender, e);
            }
            else
            {
                string query = "Select * from benhNhan where TenBN like '%" + timKiem + "%'";

                dgvInfoBN.DataSource = benhNhan.Table(query);
            }
        }

        private void dgvInfoBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBN.Text = dgvInfoBN.SelectedRows[0].Cells[0].Value.ToString();
            txtMaPhongBN.Text = dgvInfoBN.SelectedRows[0].Cells[1].Value.ToString();
            txtTenBN.Text = dgvInfoBN.SelectedRows[0].Cells[2].Value.ToString();
            DOBBN.Text = dgvInfoBN.SelectedRows[0].Cells[3].Value.ToString();
            DateVaoVienBN.Text = dgvInfoBN.SelectedRows[0].Cells[4].Value.ToString();
            cobGioiTinhBN.Text = dgvInfoBN.SelectedRows[0].Cells[5].Value.ToString();
            txtBenhTrangBN.Text = dgvInfoBN.SelectedRows[0].Cells[6].Value.ToString();
            txtSDTBN.Text = dgvInfoBN.SelectedRows[0].Cells[7].Value.ToString();
            cobDiaChiBN.Text = dgvInfoBN.SelectedRows[0].Cells[8].Value.ToString();
            txtSDTNguoiThan.Text = dgvInfoBN.SelectedRows[0].Cells[9].Value.ToString();
            cobTrangThaiBN.Text = dgvInfoBN.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void btnThemBN_Click(object sender, EventArgs e)
        {
            AddPatients addBn = new AddPatients();
            addBn.Show();
        }
    }
}
