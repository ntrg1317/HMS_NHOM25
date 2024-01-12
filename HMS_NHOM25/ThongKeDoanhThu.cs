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

                string queryDoanhThu = @"SELECT DAY(NgayTT) AS Ngay, SUM(TongTien) AS DoanhThu
                                        FROM hoaDon
                                        WHERE YEAR(NgayTT) = 2024
                                        GROUP BY MONTH(NgayTT), DAY(NgayTT)
                                        ORDER BY MONTH(NgayTT), Ngay;";

                SqlDataAdapter adapter = new SqlDataAdapter(queryDoanhThu, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvDoanhThu.DataSource = dataTable;

                chartDoanhThu.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Ngay", "DoanhThu", "");

                chartDoanhThu.Series[0].XValueMember = "Ngay";
                chartDoanhThu.Series[0].YValueMembers = "DoanhThu";
            }
            dgvDoanhThu.Columns["Ngay"].HeaderText = "Ngày";
            dgvDoanhThu.Columns["DoanhThu"].HeaderText = "Doanh Thu";

            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                string queryTyLeTangTruong = "WITH DoanhThuTheoNgay AS (SELECT " +
                                             "NgayTT, SUM(TongTien) AS DoanhThu " +
                                             "FROM hoaDon WHERE YEAR(NgayTT) = 2024 " +
                                             "GROUP BY NgayTT) " +
                                             "SELECT NgayTT, " +
                                             "(DoanhThu - LAG(DoanhThu) OVER(ORDER BY NgayTT)) / CAST(LAG(DoanhThu) OVER(ORDER BY NgayTT) AS FLOAT) * 100 AS TyLeTangTruong " +
                                             "FROM DoanhThuTheoNgay;";


                SqlDataAdapter adapter = new SqlDataAdapter(queryTyLeTangTruong, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvTyLeTangTruong.DataSource = dataTable;

                chartTyLeTangTruong.Series[0].Points.DataBind(dataTable.AsEnumerable(), "NgayTT", "TyLeTangTruong", "");

                chartTyLeTangTruong.Series[0].XValueMember = "NgayTT";
                chartTyLeTangTruong.Series[0].YValueMembers = "TyLeTangTruong";
            }
            dgvTyLeTangTruong.Columns["NgayTT"].HeaderText = "Ngày";
            dgvTyLeTangTruong.Columns["TyLeTangTruong"].HeaderText = "Tỷ lệ tăng trưởng";
        }
    }
}
