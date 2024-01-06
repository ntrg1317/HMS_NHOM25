using HMS_NHOM25.Model;
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
    public partial class HoaDon : Form
    {
        BaseModel basemodel = new BaseModel();
        public HoaDon()
        {
            InitializeComponent();
        }

        private void txtTimKiemSDTBN_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTimKiemSDTBN_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTimKiemSDTBN.Text.Trim();
            if (timKiem == "")
            {
                HoaDon_Load(sender, e);
            }
            else
            {
                string query1 = "SELECT MaBN FROM benhNhan WHERE SDT = '%" + timKiem + "%'";
                DataTable resultTable = basemodel.Table(query1);

                if (resultTable.Rows.Count > 0)
                {
                    string tenBN = resultTable.Rows[0]["TenBN"].ToString();
                    string ngaySinh = resultTable.Rows[0]["NgaySinh"].ToString();
                    string gioiTinh = resultTable.Rows[0]["GioiTinh"].ToString();
                    string diaChi = resultTable.Rows[0]["DiaChi"].ToString();
                    string benhTrang = resultTable.Rows[0]["BenhTrang"].ToString();
                    string ngayVao = resultTable.Rows[0]["NgayVao"].ToString();

                    txtHoTen.Text = tenBN;
                    dateNgaySinh.Text = ngaySinh;
                    dateNgayVao.Text = ngayVao;
                    txtSexBN.Text = gioiTinh;
                    txtDiaChiBN.Text = diaChi;
                    txtBenhTrang.Text = benhTrang;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy số điện thoại nào khớp.");
                }

            }
        }

        private void btnSaveTT_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            DeleteTextBoxes();
        }

        private void DeleteTextBoxes()
        {
            txtBenhTrang.Text = "";
            txtHoTen.Text = "";
            txtSexBN.Text = "";
            txtTimKiemSDTBN.Text = "";
            txtTongTien.Text = "";
            dateNgayVao.Text = "";
            dateNgayTT.Text = "";
            dateNgaySinh.Text = "";
            txtDiaChiBN.Text = "";
        }
    }
}
