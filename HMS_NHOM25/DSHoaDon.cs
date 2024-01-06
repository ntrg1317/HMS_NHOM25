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

        }

        private void btnCapNhatHD_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
