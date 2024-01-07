using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class login : Form
    {
        TaiKhoanParams taiKhoan;
        readonly BaseModel tk = new BaseModel();
        public login()
        {
            InitializeComponent();
            
        }
        
        private bool CheckTextBoxes()
        {
            if(txtTenDN.Text == "")
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
                int tk_count = tk.GetAIntValue(query1);

                if (tk_count == 1)
                {
                    Close();
                    new AdminControl().Show();
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
    }
}
