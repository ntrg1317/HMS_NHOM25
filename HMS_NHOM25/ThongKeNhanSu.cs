using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ThongKeNhanSu : Form
    {
        private static string connectionString = @"Data Source=VANGNGUYEN\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True";

        public ThongKeNhanSu()
        {
            InitializeComponent();
        }

        private void ThongKeNhanSu_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to get individual counts
                string query = "SELECT 'BacSi' AS LoaiNhanVien, COUNT(*) AS SoLuong FROM BacSi " +
                               "UNION ALL " +
                               "SELECT 'NhanVienYTe' AS LoaiNhanVien, COUNT(*) AS SoLuong FROM NhanVienYTe " +
                               "UNION ALL " +
                               "SELECT 'NhanVienThuNgan' AS LoaiNhanVien, COUNT(*) AS SoLuong FROM NhanVienThuNgan";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                chart1.Series[0].Points.DataBind(dataTable.AsEnumerable(), "LoaiNhanVien", "SoLuong", "");

                chart1.Series[0].Name = "NhanVien";


                foreach (var point in chart1.Series[0].Points)
                {
                    point.Label = point.YValues[0].ToString();

                    switch (point.AxisLabel)
                    {
                        case "BacSi":
                            point.LegendText = "Bác sĩ";
                            break;
                        case "NhanVienYTe":
                            point.LegendText = "Nhân viên y tế";
                            break;
                        case "NhanVienThuNgan":
                            point.LegendText = "Nhân viên thu ngân";
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
