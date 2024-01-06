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
            DeleteTextBoxes();
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

        private void DeleteTextBoxes()
        {
            txtTenPhong.Text = null;
            txtSoLuongPhong.Text = "";
            txtGiaPhong.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (txtTenPhong.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Bạn chưa nhập tên phòng!"); return false;
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
            string _tenPhong = txtTenPhong.Text;
            string _soLuong = txtSoLuongPhong.Text;
            string _tienPhong = txtGiaPhong.Text;
            phongP = new PhongParams(_tenPhong, _soLuong, _tienPhong);

        }

        private void txtSoLuongPhong_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGiaPhong_KeyPress(object sender, KeyPressEventArgs e)
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
