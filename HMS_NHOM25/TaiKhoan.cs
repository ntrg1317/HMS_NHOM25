using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class TaiKhoan : Form
    {
        BaseModel tk = new BaseModel();
        TaiKhoanParams tkp;

        private string table = "taiKhoan";
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void txtTKMaTK_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTKMaTK.Text.Trim();
            if (timKiem == "")
            {
                TaiKhoan_Load(sender, e);
            }
            else
            {
                string query = "Select * from taiKhoan where MaTK like '%" + timKiem + "%'";
                dgvInforTaiKhoan.DataSource = tk.Table(query);
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInforTaiKhoan.DataSource = tk.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE taiKhoan SET " +
                        $"TenDN = N'{tkp.TenDN}', " +
                        $"MatKhau = '{tkp.MatKhau}' " +
                        $"WHERE MaTK = '{txtMaTK.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        tk.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        TaiKhoan_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgvInforTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaTK.Text = dgvInforTaiKhoan.SelectedRows[0].Cells[0].Value.ToString();
                txtTMaCV.Text = dgvInforTaiKhoan.SelectedRows[0].Cells[1].Value.ToString();
                txtTenDN.Text = dgvInforTaiKhoan.SelectedRows[0].Cells[2].Value.ToString();
                txtMatKhau.Text = dgvInforTaiKhoan.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            string choose = dgvInforTaiKhoan.SelectedRows[0].Cells[0].Value.ToString();
            int id = int.Parse(choose);
            string query1 = "DELETE taiKhoan ";
            query1 += "Where MaTK ='" + choose + "'";
            string query3 = "DELETE bacSi " + "Where MaBS = '" + choose + "'";
            string query5 = "DELETE nhanVienThuNgan " + "Where MaNV = '" + choose + "'";
            string query4 = "DELETE duocSi " + "Where MaNV = '" + choose + "'";
            string query2 = "DELETE benhNhan " + "Where MaBN = '" + choose + "'";
            if (dgvInforTaiKhoan.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (id != 1)
                        {
                            switch (id)
                            {
                                case 2:
                                    {
                                        tk.Command(query2);
                                        break;
                                    }
                                case 3:
                                    {
                                        tk.Command(query3);
                                        break;
                                    }
                                case 4:
                                    {
                                        tk.Command(query4);
                                        break;
                                    }
                                case 5:
                                    {
                                        tk.Command(query5);
                                        break;
                                    }
                                default: { break; }
                            }
                            tk.Command(query1);
                            MessageBox.Show("Xóa thông tin thành công!");
                            TaiKhoan_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Không được phép xóa tài khoản quản trị viên!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private bool CheckTextBoxes()
        {
            if (txtTenDN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!"); return false;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenDN = txtTenDN.Text;
            string _matKhau = txtMatKhau.Text;

            tkp = new TaiKhoanParams(_tenDN, _matKhau);
        }
    }
}
