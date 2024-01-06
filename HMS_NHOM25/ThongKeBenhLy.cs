using HMS_NHOM25.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ThongKeBenhLy : Form
    {
        public ThongKeBenhLy()
        {
            InitializeComponent();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ThongKeBenhLy_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT benhTrang, COUNT(*) AS SoLuongBenhNhan FROM benhNhan GROUP BY benhTrang";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query1, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    chartTKLoaiBenh.Series[0].Points.DataBind(dataTable.AsEnumerable(), "benhTrang", "SoLuongBenhNhan", "");

                    chartTKLoaiBenh.Series[0].XValueMember = "benhTrang";
                    chartTKLoaiBenh.Series[0].YValueMembers = "SoLuongBenhNhan";
                }
            }


            string query2 = "SELECT YEAR(NgayVao) AS Nam, COUNT(*) AS SoLuongBenhNhan  FROM benhNhan WHERE benhTrang = N'Đau đầu'" +
                            " GROUP BY YEAR(NgayVao)";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    chartTKDauDau.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Nam", "SoLuongBenhNhan", "");

                    chartTKDauDau.Series[0].XValueMember = "Nam";
                    chartTKDauDau.Series[0].YValueMembers = "SoLuongBenhNhan";
                }
            }

            string query3 = "SELECT MONTH(NgayVao) AS Thang, COUNT(*) AS SoLuongBenhNhan FROM benhNhan WHERE benhTrang = N'Đau Cơ'" +
                            "GROUP BY MONTH(NgayVao)";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query3, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    chartTKDauCo.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Thang", "SoLuongBenhNhan", "");

                    chartTKDauCo.Series[0].XValueMember = "Thang";
                    chartTKDauCo.Series[0].YValueMembers = "SoLuongBenhNhan";
                }
            }
        }
    }

}
