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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

                string queryDoanhThu = "WITH DoanhThuThang AS (SELECT MONTH(NgayTT) AS Thang, SUM(TongTien) AS DoanhThu" +
                    "FROM hoaDon WITH(NOLOCK)" +
                    "WHERE YEAR(NgayTT) = 2023" +
                    "GROUP BY MONTH(NgayTT))" +
                    "SELECT t1.Thang, t1.DoanhThu," +
                    "ISNULL((t1.DoanhThu - t2.DoanhThu) / NULLIF(t2.DoanhThu, 0) * 100, 0) AS TyLeTangTruong" +
                    "FROM DoanhThuThang t1 LEFT JOIN DoanhThuThang t2 ON t1.Thang = t2.Thang + 1" +
                    "ORDER BY t1.Thang;";

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
