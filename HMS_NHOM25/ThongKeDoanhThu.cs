using HMS_NHOM25.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ThongKeDoanhThu : Form
    {
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                string queryDoanhThu = "SELECT MONTH(NgayTT) AS Thang," +
                    "SUM(TongTien) AS DoanhThu," +
                    "100 * (SUM(TongTien) - LAG(SUM(TongTien), 1, 0) OVER (ORDER BY MONTH(NgayTT))) / NULLIF(LAG(SUM(TongTien), 1, 0) OVER (ORDER BY MONTH(NgayTT)), 0) " +
                    "AS TyLeTangTruong FROM hoaDon" +
                    "WHERE YEAR(NgayTT) = 2023 " +
                    "GROUP BY MONTH(NgayTT) ORDER BY Thang;";

                SqlDataAdapter adapter = new SqlDataAdapter(queryDoanhThu, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvDoanhThu.DataSource = dataTable;

                chartDoanhThu.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Thang", "DoanhThu", "TyLeTangTruong");

                chartDoanhThu.Series[0].XValueMember = "Thang";
                chartDoanhThu.Series[0].YValueMembers = "DoanhThu";
                chartDoanhThu.Series[0].YValueMembers = "TyLeTangTruong";
            }
        }
    }
}
