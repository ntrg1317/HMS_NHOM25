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
    public partial class AddThuoc : Form
    {
        BaseModel basemodel = new BaseModel();
        KhoThuocParams ktp;

        public AddThuoc()
        {
            InitializeComponent();
        }

        private void AddThuoc_Load(object sender, EventArgs e)
        {
            DeleteTextBoxes();
        }

        private void txtGiaThuocM_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSoLuongThuocM_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSaveInfoThuoc_Click(object sender, EventArgs e)
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
                        if (MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            string query1 = "INSERT INTO khoThuoc (TenThuoc, SoLuong, NSX, HSD, TienThuoc) VALUES " + "(N'" + ktp.TenThuoc + "', N'" + ktp.SoLuong + "', N'" + ktp.NSX + "', N'" + ktp.HSD + "', N'" + ktp.TienThuoc + "')";
                            basemodel.Command(query1);

                            transaction.Commit();

                            MessageBox.Show("Lưu thông tin thành công!");
                            AddThuoc_Load(sender, e);
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

        private void btnThoatAddThuoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteTextBoxes()
        {
            txtTenThuocM.Text = "";
            txtSoLuongThuocM.Text = "";
            dateNSX.Text = "";
            dateHSD.Text = "";
            txtGiaThuocM.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if (txtTenThuocM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên thuốc!"); return false;
            }
            if (txtSoLuongThuocM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!"); return false;
            }
            if (dateNSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sản xuất!"); return false;
            }
            if (dateHSD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hạn sử dụng!"); return false;
            }
            if (txtGiaThuocM.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá thuốc!"); return false;
            }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _tenThuoc = txtTenThuocM.Text;
            string _soLuong = txtSoLuongThuocM.Text;
            string _nsx = dateNSX.Text;
            string _hsd = dateHSD.Text;
            string _tienThuoc = txtGiaThuocM.Text;
            ktp = new KhoThuocParams(_tenThuoc, _soLuong, _nsx, _hsd, _tienThuoc);
        }

    }
}
