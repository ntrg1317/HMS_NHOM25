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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class TTCNAdmin : Form
    {
        public TTCNAdmin(string TenDN)
        {
            InitializeComponent();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string id = txtMaQTV.Text;
            SuaTTTK suaTTTK = new SuaTTTK(id);
            suaTTTK.Show();
        }

        private void TTCNAdmin_Load(object sender, EventArgs e)
        {
            
            string query = "SELECT MaTK FROM taiKhoan WHERE TenDN = 'TenDN'";
            int id = GetID(query);
            
            txtMaQTV.Text = id.ToString();
            DataTable quanTriVienInfo = GetQuanTriVienInfo(id);

            if (quanTriVienInfo.Rows.Count > 0)
            {
                txtMaQTV.Text = quanTriVienInfo.Rows[0]["MaQL"].ToString();
                txtTenQTV.Text = quanTriVienInfo.Rows[0]["TenQL"].ToString();
                DOBQTV.Text = quanTriVienInfo.Rows[0]["NgaySinh"].ToString();
                cobGioiTinhQTV.Text = quanTriVienInfo.Rows[0]["GioiTinh"].ToString();
                txtSDTQTV.Text = quanTriVienInfo.Rows[0]["SDT"].ToString();
                cobDiaChiQTV.Text = quanTriVienInfo.Rows[0]["DiaChi"].ToString();
            }

        }

        private int GetID(string query, SqlTransaction transaction = null)
        {
            int result = -1;

            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection, transaction))
                {
                    var scalarResult = command.ExecuteScalar();

                    if (scalarResult != null && scalarResult != DBNull.Value)
                    {
                        result = Convert.ToInt32(scalarResult);
                    }
                }

                sqlConnection.Close();
            }

            return result;
        }

        private DataTable GetQuanTriVienInfo(int id)
        {
            string query = "SELECT id, Ten FROM quanTriVien WHERE id = @id";

            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}
