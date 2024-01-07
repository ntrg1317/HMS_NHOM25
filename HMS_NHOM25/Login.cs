using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class login : Form
    {
        TaiKhoanParams taiKhoan;
        BaseModel tk = new BaseModel();
        public login()
        {
            InitializeComponent();
            
        }
        
        private bool CheckTextBoxes()
        {
            if (txtTenDN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập"); return false;
            }
            if (txtPasswd.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenDN = txtTenDN.Text;
            string _matKhau = txtPasswd.Text;

            taiKhoan = new TaiKhoanParams(_tenDN, _matKhau);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "SELECT COUNT(*) FROM taiKhoan WHERE TenDN = '" + taiKhoan.TenDN + "' AND MatKhau = '" + taiKhoan.MatKhau + "'";
                int count = tk.GetAIntValue(query1);
                string tenDN = taiKhoan.TenDN;

                if (count == 1)
                {
                    string query = "SELECT MaTK FROM taiKhoan WHERE TenDN = '" + taiKhoan.TenDN + "' AND MatKhau = '" + taiKhoan.MatKhau + "'";
                    int MaTK = tk.GetAIntValue(query);
                    string vaiTro = getUserRole(MaTK);
                    this.Hide();
                    AdminControl module = new AdminControl(tenDN);
                    module.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ!");
                }

            }
        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                txtPasswd.Focus();
            }
        }

        private void txtPasswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private string getUserRole(int MaTK)
        {
            string getRole = "SELECT TenCV " +
                             "FROM chucVu AS cv " +
                             "JOIN taiKhoan AS tk " +
                             "ON tk.MaCV = cv.MaCV " +
                             "WHERE MaTK = '" + MaTK + "'";
            string role = tk.GetAStringValue(getRole);
            return role;
        }
    }
}
