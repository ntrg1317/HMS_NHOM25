using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ThemDichVu : Form
    {
        BaseModel basemodel = new BaseModel();
        DichVuParams dvp;
        public ThemDichVu()
        {
            InitializeComponent();
        }

        private void btnThoatAddDichVu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDichVu_Load(object sender, EventArgs e)
        {
            DeleteTextBoxes();
        }

        private void btnSaveInfoDV_Click(object sender, EventArgs e)
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
                            string query1 = "INSERT INTO dichVu (TenDV, TienDV) VALUES " + "(N'" + dvp.TenDV + "', N'" + dvp.TienDV + "')";
                            basemodel.Command(query1);

                            transaction.Commit();

                            MessageBox.Show("Lưu thông tin thành công!");
                            AddDichVu_Load(sender, e);
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

        private void DeleteTextBoxes()
        {
            txtTenDV.Text = "";
            txtGiaDV.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if (txtTenDV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (txtGiaDV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenDV = txtTenDV.Text;
            string _tienDV = txtGiaDV.Text;

            dvp = new DichVuParams(_tenDV, _tienDV);
        }

        private void txtGiaDV_KeyPress(object sender, KeyPressEventArgs e)
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
