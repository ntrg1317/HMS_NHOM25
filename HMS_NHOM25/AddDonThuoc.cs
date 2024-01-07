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
    public partial class AddDonThuoc : Form
    {
        BaseModel basemodel = new BaseModel();
        ChiTietDTParams chiTietDT;

        public AddDonThuoc()
        {
            InitializeComponent();
        }

        private void txtTienThuoc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaKeThuoc_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveInfoDonThuoc_Click(object sender, EventArgs e)
        {

        }

        private void btnThoatAddDonThuoc_Click(object sender, EventArgs e)
        {

        }

        private void dgvInforDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddDonThuoc_Load(object sender, EventArgs e)
        {
            DeleteTextBoxes();
            showComboBox();
        }

        private void DeleteTextBoxes()
        {
            cobTenThuoc.Text = null;
            txtLieuDung.Text = "";
            txtSoLuongThuoc.Text = "";
            txtTienThuoc.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (cobTenThuoc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn tên thuốc!"); return false;
            }
            if (txtSoLuongThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!"); return false;
            }
            if (txtLieuDung.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập liều dùng!"); return false;
            }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            object _maThuoc = (cobTenThuoc.SelectedIndex != -1) ? (int)cobTenThuoc.SelectedValue : (object)DBNull.Value;
            string _soLuong = txtSoLuongThuoc.Text;
            string _lieuDung = txtLieuDung.Text;

        }

        private void showComboBox()
        {
            DataTable dt = basemodel.all("khoThuoc");

            cobTenThuoc.DataSource = dt;
            cobTenThuoc.DisplayMember = "TenThuoc";
            cobTenThuoc.ValueMember = "MaThuoc";

            cobTenThuoc.SelectedIndex = -1;
        }
    }
}
