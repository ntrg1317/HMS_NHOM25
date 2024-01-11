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
    public partial class TTCNAdmin : Form
    {
        DuocSiParams qtv;
        BaseModel info = new BaseModel();
        public TTCNAdmin()
        {
            InitializeComponent();
        }

        public TTCNAdmin(string tenDN)
        {
            InitializeComponent();
            getInfo(tenDN);
        }

        private void getInfo(string tenDN)
        {
            string getRoleQuery = $@"SELECT *  
                             FROM quanTriVien AS qtv 
                             JOIN taiKhoan AS tk 
                             ON tk.MaTK = qtv.MaQL 
                             WHERE tk.TenDN = '{tenDN}'";

            try
            {
                DataTable dt = info.Table(getRoleQuery);

                if (dt.Rows.Count > 0)
                {
                    txtMaQTV.Text = dt.Rows[0]["MaQL"].ToString();
                    txtTenQTV.Text = dt.Rows[0]["TenQL"].ToString();
                    txtSDTQTV.Text = dt.Rows[0]["SDT"].ToString();
                    DOBQTV.Text = dt.Rows[0]["NgaySinh"].ToString();
                    GetSelectedValue(dt.Rows[0]["GioiTinh"].ToString(), cobGioiTinhQTV);
                    GetSelectedValue(dt.Rows[0]["DiaChi"].ToString(), cobDiaChiQTV);
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            SuaTTTK suaTTTK = new SuaTTTK();
            suaTTTK.Show();
        }

        private void GetSelectedValue(string selectedValue, ComboBox cob)
        {
            foreach (object item in cob.Items)
            {
                if (item.ToString() == selectedValue.Trim())
                {
                    cob.SelectedItem = item;
                    break;
                }
            }
        }

        private bool CheckTextBoxes()
        {
            if (txtMaQTV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (DOBQTV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!"); return false;
            }
            if (cobGioiTinhQTV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính!"); return false;
            }
            if (txtSDTQTV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!"); return false;
            }
            if (cobDiaChiQTV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenQL = txtTenQTV.Text;
            string _ngaySinh = DOBQTV.Text;
            string _gioiTinh = cobGioiTinhQTV.Text;
            string _sdt = txtSDTQTV.Text;
            string _diaChi = cobDiaChiQTV.Text;
            qtv = new DuocSiParams(_tenQL, _ngaySinh, _gioiTinh, _sdt, _diaChi);
        }

        private void btnSaveTTCN_Click(object sender, EventArgs e)
        {
            if(CheckTextBoxes())
            {
                try
                {
                    GetValuesTextBoxes();
                    string updateQuery = $@"UPDATE quanTriVien
                                SET TenQL = '{qtv.TenNV}',
                                    SDT = '{qtv.Sdt}',
                                    NgaySinh = '{qtv.NgaySinh}',
                                    GioiTinh = '{qtv.GioiTinh}',
                                    DiaChi = '{qtv.DiaChi}' 
                                FROM quanTriVien 
                                WHERE MaQL = '{txtMaQTV.Text}'";

                    if(MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        info.Command(updateQuery);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        TTCNAdmin_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi: " + ex.Message);
                }
            }    
        }

        private void TTCNAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
