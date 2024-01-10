using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class AddPatients : Form
    {
        BenhNhan bn = new BenhNhan();
        BaseModel bn_tk = new BaseModel();
        public AddPatients()
        {
            InitializeComponent();
        }

        private void AddPatients_Load(object sender, EventArgs e)
        {
            DeleteTextBoxes();
        }

        private void DeleteTextBoxes()
        {
            txtTenBNM.Text = "";
            dateDobBn.Text = "";
            cobSexBNM.SelectedValue = -1;
            txtSDTBNM.Text = "";
            cobDiaChiBNM.SelectedValue = -1;
            txtSDTNguoiThanM.Text = "";
            txtTenDNBNM.Text = "";
            txtMatKhauBNM.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if (txtTenBNM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (dateDobBn.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!"); return false;
            }
            if (cobSexBNM.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính!"); return false;
            }
            if (txtSDTBNM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!"); return false;
            }
            if (txtSDTBNM.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại có tối đa 10 chữ số!"); return false;
            }
            if (txtSDTNguoiThanM.Text != "" && txtSDTNguoiThanM.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại có tối đa 10 chữ số!"); return false;
            }
            if (cobDiaChiBNM.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!"); return false;
            }
            if (txtTenDNBNM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!"); return false;
            }
            if (txtMatKhauBNM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenBN = txtTenBNM.Text;
            string _ngaySinh = dateDobBn.Text;
            string _gioiTinh = cobSexBNM.Text;
            string _sdt = txtSDTBNM.Text;
            string _diaChi = cobDiaChiBNM.Text;
            string _sdtNguoiThan = txtSDTNguoiThanM.Text;

            string _tenDN = txtTenDNBNM.Text;
            string _matKhau = txtMatKhauBNM.Text;

            bn = new BenhNhan(_tenBN, _ngaySinh, _gioiTinh, _sdt, _diaChi, _sdtNguoiThan, null, _tenDN, _matKhau);
        }

        private void btnSaveInfoBNM_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
                {
                    sqlConnection.Open();
                    SqlTransaction transaction = sqlConnection.BeginTransaction();

                    GetValuesTextBoxes();

                    string query2 = "INSERT INTO taiKhoan (MaCV, TenDN, MatKhau) VALUES ('3', N'" + bn.TenDN + "' ,N'" + bn.MatKhau + "')";

                    try
                    {
                        if (MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            bn_tk.Command(query2);
                            int id = bn_tk.getLastInsertID("MaTK", "taiKhoan");

                            string query1;
                            
                            query1 = "INSERT INTO benhNhan (MaBN, TenBN, NgaySinh, GioiTinh, SDT, DiaChi, SDTNguoiThan) VALUES " +
                                "('" + id + "', N'" + bn.TenBN + "' ,N'" + bn.NgaySinh + "', N'" + bn.GioiTinh + "', N'" + bn.Sdt + "', N'" + bn.DiaChi + "', N'" + bn.SdtNguoiThan + "')";

                            bn_tk.Command(query1);

                            transaction.Commit();

                            MessageBox.Show("Lưu thông tin thành công!");
                            AddPatients_Load(sender, e);
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

        private void txtSDTBNM_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnThoatAddBNM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDTNguoiThanM_KeyPress(object sender, KeyPressEventArgs e)
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
