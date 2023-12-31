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
    public partial class AddDoctor : Form
    {
        TestBacSi qlBacSi;
        BaseModel Doctor = new BaseModel();
        BaseModel taiKhoan = new BaseModel();
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            DeleteTextBoxes();
        }
        private void DeleteTextBoxes()
        {
            txtTenBSM.Text = "";
            txtTenDNBSM.Text = "";
            txtMatKhauBSM.Text = "";
            DOBBSM.Text = "";
            cobSexBSM.SelectedIndex = -1;
            txtSDTBSM.Text = "";
            txtDiaChiBSM.Text = "";
            cobChuyenMonBSM.SelectedIndex = -1;
            txtBangCapBSM.Text = "";
            cobTrangThaiBSM.SelectedIndex = -1;

        }
        private bool CheckTextBoxes()
        {
            if(txtTenBSM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!");return false;
            }
            if (txtTenDNBSM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!"); return false;
            }
            if (txtMatKhauBSM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!"); return false;
            }
            if (DOBBSM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!"); return false;
            }
            if (cobSexBSM.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính!"); return false;
            }
            if (txtSDTBSM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!"); return false;
            }
            if (txtDiaChiBSM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!"); return false;
            }
            if (cobChuyenMonBSM.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn chuyên môn!"); return false;
            }
            if (txtBangCapBSM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bằng cấp!"); return false;
            }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _tenBS = txtTenBSM.Text;
            string _ngaySinh = DOBBSM.Text;
            string _gioiTinh = cobSexBSM.Text;
            string _sdt = txtSDTBSM.Text;
            string _diaChi = txtDiaChiBSM.Text;
            string _chuyenMon = cobChuyenMonBSM.Text;
            string _bangCap = txtBangCapBSM.Text;
            string _tenDNBS = txtTenDNBSM.Text;
            string _matKhauBS = txtMatKhauBSM.Text;
            int _trangThai = int.Parse(cobTrangThaiBSM.Text);
            qlBacSi = new TestBacSi(_tenBS, _ngaySinh, _gioiTinh, _sdt, _diaChi, _chuyenMon, _bangCap, _tenDNBS, _matKhauBS, _trangThai);

        }

        private void btnSaveInfoBS_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "INSERT INTO bacSi VALUES (N'" + qlBacSi.TenBS + "' ,N'" + qlBacSi.NgaySinh + "', N'" + qlBacSi.GioiTinh + "', N'" + qlBacSi.DiaChi + "', N'" + qlBacSi.ChuyenMon + "', N'" + qlBacSi.BangCap + "', '" + qlBacSi.TrangThai + "')";
                string query2 = "INSERT INTO taiKhoan VALUES (2, N'" + qlBacSi.TenDNBS + "' ,N'" + qlBacSi.MatKhauBS + "') SELECT SCOPE_IDENTITY()";
                try
                {
                    if (MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        int id = taiKhoan.getLastInsertID(query2);
                        Console.WriteLine(id);
                        MessageBox.Show("Lưu thông tin thành công!");
                        AddDoctor_Load(sender, e);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
