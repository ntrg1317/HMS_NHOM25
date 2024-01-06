using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ChiTietDonThuoc : Form
    {
        public ChiTietDonThuoc()
        {
            InitializeComponent();
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
