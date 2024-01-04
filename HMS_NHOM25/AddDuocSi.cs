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
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class AddDuocSi : Form
    {
        DuocSiParams duocSi;
        BaseModel ds = new BaseModel();
        public AddDuocSi()
        {
            InitializeComponent();
        }

        private void AddDuocSi_Load(object sender, EventArgs e)
        {
            DeleteTextBoxes();
        }
        private void DeleteTextBoxes()
        {
            txtTenDS.Text = "";
            txtTenDNDS.Text = "";
            txtMatKhauDS.Text = "";
            DOBDS.Text = "";
            cobSexDS.SelectedIndex = -1;
            txtSDTDS.Text = "";
            cobDiaChiDS.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if (txtTenDS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (txtTenDNDS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!"); return false;
            }
            if (txtMatKhauDS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!"); return false;
            }
            if (DOBDS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!"); return false;
            }
            if (cobSexDS.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính!"); return false;
            }
            if (txtSDTDS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!"); return false;
            }
            if (cobDiaChiDS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenDS = txtTenDS.Text;
            string _ngaySinh = DOBDS.Text;
            string _gioiTinh = cobSexDS.Text;
            string _sdt = txtSDTDS.Text;
            string _diaChi = cobDiaChiDS.Text;

            string _tenDNBS = txtTenDNDS.Text;
            string _matKhauBS = txtMatKhauDS.Text;
            duocSi = new DuocSiParams(_tenDS, _ngaySinh, _gioiTinh, _sdt, _diaChi, _tenDNBS, _matKhauBS);
        }

        private void btnSaveInfoDS_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
                {
                    sqlConnection.Open();
                    SqlTransaction transaction = sqlConnection.BeginTransaction();

                    GetValuesTextBoxes();

                    string query2 = "INSERT INTO taiKhoan (MaCV, TenDN, MatKhau) VALUES ('4', N'" + duocSi.TenDN + "' ,N'" + duocSi.MatKhau + "')";

                    try
                    {
                        if (MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            ds.Command(query2);
                            int id = ds.getLastInsertID("MaTK", "taiKhoan");

                            string query1 = "INSERT INTO duocSi (MaNV, TenNV, NgaySinh, GioiTinh, SDT, DiaChi) VALUES " +
                                "('" + id + "', N'" + duocSi.TenNV + "' ,N'" + duocSi.NgaySinh + "', N'" + duocSi.GioiTinh + "', N'" + duocSi.Sdt + "' , N'" + duocSi.DiaChi + "')";

                            ds.Command(query1);

                            transaction.Commit();

                            MessageBox.Show("Lưu thông tin thành công!");
                            AddDuocSi_Load(sender, e);
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

        private void btnThoatAddDS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDTDS_KeyPress(object sender, KeyPressEventArgs e)
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
