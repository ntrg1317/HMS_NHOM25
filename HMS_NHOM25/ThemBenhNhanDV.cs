using HMS_NHOM25.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ThemBenhNhanDV : Form
    {
        BaseModel bn_dv = new BaseModel();
        public ThemBenhNhanDV(string MaBN)
        {
            InitializeComponent();
            txtMaBN.Text = MaBN;
        }

        private void showComboBox()
        {
            DataTable dt = bn_dv.all("dichVu");

            cobTenDV.DataSource = dt;
            cobTenDV.DisplayMember = "TenDV";
            cobTenDV.ValueMember = "MaDV";

            cobTenDV.SelectedIndex = -1;
        }

        private void AddBenhNhanDV_Load(object sender, EventArgs e)
        {
            BenhNhan patients = new BenhNhan();
            showComboBox();
        }

        private void cobTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobTenDV.SelectedIndex != -1)
            {
                if (int.TryParse(cobTenDV.SelectedValue.ToString(), out int madv))
                {
                    string findGiaDV = "SELECT TienDV FROM dichVu WHERE MaDV = '" + madv + "'";
                    txtGiaDV.Text = bn_dv.GetAStringValue(findGiaDV);
                }
            }
            else
            {
                txtGiaDV.Text = string.Empty;
            }
        }

        private bool CheckTextBoxes()
        {
            if (txtMaBN.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại bệnh nhân!"); return false;
            }
            if (cobTenDV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dịch vụ!"); return false;
            }
            if (dateNgayDV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ngày sử dụng!"); return false;
            }
            return true;
        }
        private void btnSaveBNDV_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
                {
                    try
                    {
                        if (MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            string MaBN = txtMaBN.Text;
                            int MaDV = int.Parse(cobTenDV.SelectedValue.ToString());
                            string NgayDung = dateNgayDV.Text;
                            string insertBN_DV = "INSERT INTO benhNhan_dichVu (MaBN, MaDV, NgayDung) " +
                                                 "VALUES ('" + MaBN + "', '" + MaDV + "', '" + NgayDung + "')";

                            bn_dv.Command(insertBN_DV);

                            MessageBox.Show("Lưu thông tin thành công!");
                            AddBenhNhanDV_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void btnThoatAddBNDichVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
