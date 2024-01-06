using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class AddPhong : Form
    {
        BaseModel phong = new BaseModel();
        PhongParams phongP;

        public AddPhong()
        {
            InitializeComponent();
        }

        private void AddPhong_Load(object sender, EventArgs e)
        {
            showComboBox();
        }

        private void btnSaveInfoPhong_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
                {
                    sqlConnection.Open();
                    SqlTransaction transaction = sqlConnection.BeginTransaction();

                    GetValuesTextBoxes();

                    try
                    {
                        if (System.Windows.Forms.MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            string query1 = "INSERT INTO phong (TenPhong, SLGiuong, TienPhong) VALUES " + "(N'" + phongP.TenPhong + "', N'" + phongP.SoLuong + "', N'" + phongP.TienPhong + "')";
                            phong.Command(query1);

                            transaction.Commit();

                            System.Windows.Forms.MessageBox.Show("Lưu thông tin thành công!");
                            AddPhong_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        System.Windows.Forms.MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void btnThoatAddPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showComboBox()
        {
            DataTable dt = phong.all("phong");

            cobTenPhong.DataSource = dt;
            cobTenPhong.DisplayMember = "TenPhong";
            cobTenPhong.ValueMember = "MaPhong";

            cobTenPhong.SelectedIndex = -1;
        }

        private void cobTenPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobTenPhong.SelectedIndex != -1)
            {
                if (int.TryParse(cobTenPhong.SelectedValue.ToString(), out int maphong))
                {
                    string findGiaDV = "SELECT TienPhong FROM phong WHERE MaPhong = '" + maphong + "'";
                    txtGiaPhong.Text = phong.GetAStringValue(findGiaDV);
                }
            }
            else
            {
                txtGiaPhong.Text = string.Empty;
            }
        }
        private void DeleteTextBoxes()
        {
            cobTenPhong.Text = null;
            txtSoLuongPhong.Text = "";
            txtGiaPhong.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (cobTenPhong.SelectedIndex == -1)
            {
                System.Windows.Forms.MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (txtSoLuongPhong.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Bạn chưa nhập số lượng!"); return false;
            }
            if (txtGiaPhong.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Bạn chưa nhập giá!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenPhong = cobTenPhong.Text;
            string _soLuong = txtSoLuongPhong.Text;
            string _tienPhong = txtGiaPhong.Text;
            phongP = new PhongParams(_tenPhong, _soLuong, _tienPhong);

        }
    }
}
