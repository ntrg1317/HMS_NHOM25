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
            //dgvDoanhThu.Columns["Thang"].HeaderText = "Tháng";
            //dgvDoanhThu.Columns["DoanhThu"].HeaderText = "Doanh thu";
            //dgvTyLeTangTruong.Columns["TyLeTangTruong"].HeaderText = "Tỷ lệ tăng trưởng";
            //dgvTyLeTangTruong.Columns["Thang"].HeaderText = "Tháng";



            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                string queryDoanhThu = "SELECT MONTH(NgayTT) AS Thang, SUM(TongTien) AS DoanhThu " +
                    "FROM hoaDon WHERE YEAR(NgayTT) = 2023 " +
                    "GROUP BY MONTH(NgayTT) ORDER BY Thang;";

                SqlDataAdapter adapter = new SqlDataAdapter(queryDoanhThu, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvDoanhThu.DataSource = dataTable;

                chartDoanhThu.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Thang", "DoanhThu", "");

                chartDoanhThu.Series[0].XValueMember = "Thang";
                chartDoanhThu.Series[0].YValueMembers = "DoanhThu";
            }

            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                string queryTyLeTangTruong = "WITH DoanhThuTheoThang AS (SELECT " +
                    "MONTH(NgayTT) AS Thang, SUM(TongTien) AS DoanhThu " +
                    "FROM hoaDon WHERE YEAR(NgayTT) = 2023 " +
<<<<<<< HEAD

=======
>>>>>>> 794794a8f89a1a563275d6571c3ca0da7c91e4ae
                    "GROUP BY MONTH(NgayTT)) " +
                    "SELECT Thang, (DoanhThu - LAG(DoanhThu) OVER(ORDER BY Thang)) / LAG(DoanhThu) OVER(ORDER BY Thang) * 100 AS TyLeTangTruong " +
                    "FROM DoanhThuTheoThang;";

                SqlDataAdapter adapter = new SqlDataAdapter(queryTyLeTangTruong, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvTyLeTangTruong.DataSource = dataTable;

                chartTyLeTangTruong.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Thang", "TyLeTangTruong", "");

                chartTyLeTangTruong.Series[0].XValueMember = "Thang";
                chartTyLeTangTruong.Series[0].YValueMembers = "TyLeTangTruong";
            }
        }
    }
}
