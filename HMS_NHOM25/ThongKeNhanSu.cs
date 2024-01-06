using HMS_NHOM25.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ThongKeNhanSu : Form
    {
        public ThongKeNhanSu()
        {
            InitializeComponent();
        }

        private void ThongKeNhanSu_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                // Query to get individual counts
                string query = "SELECT 'BacSi' AS LoaiNhanVien, COUNT(*) AS SoLuong FROM bacSi " +
                               "UNION ALL " +
                               "SELECT 'NhanVienYTe' AS LoaiNhanVien, COUNT(*) AS SoLuong FROM duocSi " +
                               "UNION ALL " +
                               "SELECT 'NhanVienThuNgan' AS LoaiNhanVien, COUNT(*) AS SoLuong FROM nhanVienThuNgan";

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
