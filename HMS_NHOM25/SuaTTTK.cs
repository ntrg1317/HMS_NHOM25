using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class SuaTTTK : Form
    {
        TaiKhoanParams tkCu, tkMoi;
        BaseModel tk = new BaseModel();
        public SuaTTTK()
        {
            InitializeComponent();
        }
        public SuaTTTK(string tenDN)
        {
            InitializeComponent();
            txtTenDN.Text = tenDN;
        }
        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            if(CheckTextBoxes())
            {
                GetValuesTextBoxes();

                string checkTK = "SELECT MatKhau FROM taiKhoan WHERE TenDN = '" + txtTenDN.Text + "'";
                string getId = "SELECT MaTK FROM taiKhoan WHERE TenDN = '" + txtTenDN.Text + "'";
                int id = tk.GetAIntValue(getId);

                if (tkCu.MatKhau == tk.GetAStringValue(checkTK))
                {
                    string doiMK = $@"UPDATE taiKhoan 
                                    SET TenDN = N'{tkMoi.TenDN}', 
                                        MatKhau = N'{tkMoi.MatKhau}' 
                                    FROM taiKhoan 
                                    WHERE MaTK = '{id}'";

                    tk.Command(doiMK);
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Mật Khẩu hoặc Tên đăng nhập không đúng!!");
                    SuaTTTK_Load(sender, new EventArgs());
                } 
                    
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckTextBoxes()
        {
            if (txtMK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!"); return false;
            }
            if (txtTenDNmoi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập mới!"); return false;
            }
            if (txtMK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới!"); return false;
            }
            if (txtCfMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu xác nhận!"); return false;
            }
            if (txtCfMatKhau.Text != txtMKmoi.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng!"); return false;
            }
            return true;
        }

        private void SuaTTTK_Load(object sender, EventArgs e)
        {
            DeleteTextBoxes();
        }

        private void GetValuesTextBoxes()
        {
            string _tenDN = txtTenDN.Text;
            string _matKhau = txtMK.Text;
            string _tenDNM = txtTenDNmoi.Text;
            string _matKhauM = txtMKmoi.Text;

            tkCu = new TaiKhoanParams(_tenDN, _matKhau);
            tkMoi = new TaiKhoanParams(_tenDNM, _matKhauM);
        }

        private void DeleteTextBoxes()
        {
            txtMK.Text = "";
            txtMKmoi.Text = "";
            txtCfMatKhau.Text = "";
        }
    }
}
