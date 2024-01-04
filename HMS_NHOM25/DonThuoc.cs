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
            cmbTenThuoc.Text = dgvInfoDSDonThuoc.SelectedRows[0].Cells[3].Value.ToString();
            txtSoLuongThuoc.Text = dgvInfoDSDonThuoc.SelectedRows[0].Cells[4].Value.ToString();
            txtLieuDung.Text = dgvInfoDSDonThuoc.SelectedRows[0].Cells[5].Value.ToString();
            txtTienThuoc.Text = dgvInfoDSDonThuoc.SelectedRows[0].Cells[6].Value.ToString();
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

        }
    }
}