using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class SuaTTTK : Form
    {
        BaseModel model = new BaseModel();
        TaiKhoanParams tkp;
        public SuaTTTK(string id)
        {
            InitializeComponent();
            txtMaQL.Text = id;
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                bool kiemTra = CheckTenDN(txtTenDNM.Text);

                if (kiemTra)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại! Mời bạn nhập tên đăng nhập khác!");
                }
                else
                {
                    GetValuesTextBoxes();
                    string query1 = "UPDATE taiKhoan SET " +
                            $"TenDN = N'{tkp.TenDN}', " +
                            $"MatKhau = '{tkp.MatKhau}' " +
                            $"WHERE MaTK = '{txtMaQL.Text}'";
                    try
                    {
                        if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            model.Command(query1);
                            MessageBox.Show("Cập nhật thông tin thành công!");
                            SuaTTTK_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void SuaTTTK_Load(object sender, EventArgs e)
        {
            txtTenDN.Text = tkp.TenDN;
            txtMK.Text = tkp.MatKhau;
        }

        private bool CheckTextBoxes()
        {
            if (txtTenDNM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!"); return false;
            }
            if (txtMKM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenDN = txtTenDNM.Text;
            string _matKhau = txtMKM.Text;

            tkp = new TaiKhoanParams(_tenDN, _matKhau);
        }

        public bool CheckTenDN(string tenDNM)
        {
            string query = "SELECT COUNT(*) FROM taiKhoan WHERE TenDN = @TenDN";

            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@TenDN", tenDNM);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }
    }
}
