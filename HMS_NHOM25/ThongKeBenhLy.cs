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
            string queryCacLoaiBenh = "SELECT benhTrang, COUNT(*) AS SoLuong FROM benhNhan GROUP BY benhTrang";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryCacLoaiBenh, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvCacLoaiBenh.DataSource = dataTable;

                    chartTKLoaiBenh.Series[0].Points.DataBind(dataTable.AsEnumerable(), "benhTrang", "SoLuong", "");

                    chartTKLoaiBenh.Series[0].XValueMember = "benhTrang";
                    chartTKLoaiBenh.Series[0].YValueMembers = "SoLuong";
                }
            }


            string queryDauDauNam = "SELECT YEAR(NgayVao) AS Nam, COUNT(*) AS SoLuong  FROM benhNhan WHERE benhTrang = N'Đau đầu' AND YEAR(NgayVao) BETWEEN 2020 AND 2024 " +
                            " GROUP BY YEAR(NgayVao)";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryDauDauNam, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvDauDauNam.DataSource = dataTable;

                    chartTKDauDau.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Nam", "SoLuong", "");

                    chartTKDauDau.Series[0].XValueMember = "Nam";
                    chartTKDauDau.Series[0].YValueMembers = "SoLuong";
                }
            }

            string queryDauCo2023 = "SELECT MONTH(NgayVao) AS Thang, COUNT(*) AS SoLuong FROM benhNhan WHERE benhTrang = N'Đau Cơ'" +
                            "GROUP BY MONTH(NgayVao)";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryDauCo2023, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvDauCo2023.DataSource = dataTable;

                    chartTKDauCo.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Thang", "SoLuong", "");

                    chartTKDauCo.Series[0].XValueMember = "Thang";
                    chartTKDauCo.Series[0].YValueMembers = "SoLuong";
                }
            }
        }
    }

}
