using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ThemNVTN : Form
    {
        BaseModel basemodel = new BaseModel();
        NVThuNganParams nvtn;
        public ThemNVTN()
        {
            InitializeComponent();
        }

        private void AddNVTN_Load(object sender, EventArgs e)
        {
            DeleteTextBoxes();
        }

        private void btnSaveInfoNVTNM_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
                {
                    sqlConnection.Open();
                    SqlTransaction transaction = sqlConnection.BeginTransaction();

                    GetValuesTextBoxes();

                    string query2 = "INSERT INTO taiKhoan (MaCV, TenDN, MatKhau) VALUES ('5', N'" + nvtn.TenDN + "' ,N'" + nvtn.MatKhau + "')";

                    try
                    {
                        if (MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            basemodel.Command(query2);
                            int id = basemodel.getLastInsertID("MaTK", "taiKhoan");

                            string query1 = query1 = "INSERT INTO nhanVienThuNgan (MaNV, TenNV, NgaySinh, GioiTinh, SDT, DiaChi) VALUES " +
                                "('" + id + "' , N'" + nvtn.TenNV + "' ,N'" + nvtn.NgaySinh + "', N'" + nvtn.GioiTinh + "', N'" + nvtn.Sdt + "', N'" + nvtn.DiaChi + "')";
                            basemodel.Command(query1);

                            transaction.Commit();

                            MessageBox.Show("Lưu thông tin thành công!");
                            AddNVTN_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void DeleteTextBoxes()
        {
            txtTenNVTNM.Text = "";
            DOBNVTNM.Text = "";
            cobSexNVTNM.Text = null;
            txtSDTNVTNM.Text = "";
            cobDiaChiNVTNM.Text = null;
            txtTenDNNVTNM.Text = "";
            txtMatKhauNVTNM.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if (txtTenNVTNM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (DOBNVTNM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!"); return false;
            }
            if (cobSexNVTNM.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính!"); return false;
            }
            if (txtSDTNVTNM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!"); return false;
            }
            if (txtSDTNVTNM.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại có tối đa 10 chữ số!"); return false;
            }
            if (cobDiaChiNVTNM.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!"); return false;
            }
            if (txtTenDNNVTNM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!"); return false;
            }
            if (txtMatKhauNVTNM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenNV = txtTenNVTNM.Text;
            string _ngaySinh = DOBNVTNM.Text;
            string _gioiTinh = cobSexNVTNM.Text;
            string _sdt = txtSDTNVTNM.Text;
            string _diaChi = cobDiaChiNVTNM.Text;

            string _tenDN = txtTenDNNVTNM.Text;
            string _matKhau = txtMatKhauNVTNM.Text;

            nvtn = new NVThuNganParams(_tenNV, _ngaySinh, _gioiTinh, _sdt, _diaChi, null, _tenDN, _matKhau);
        }

        private void btnThoatAddNVTNM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDTNVTNM_KeyPress(object sender, KeyPressEventArgs e)
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
