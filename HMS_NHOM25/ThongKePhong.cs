using GMap.NET.MapProviders;
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
    public partial class ThongKePhong : Form
    {
        public ThongKePhong()
        {
            InitializeComponent();
        }

        private void ThongKePhong_Load(object sender, EventArgs e)
        {
            string queryLuotSDPhong = "SELECT " +
                "DATEADD(day, (DATEPART(day, NgayVao) - 1) / 3 * 3, CAST(NgayVao AS DATE)) AS Ngay, " +
                "COUNT(DISTINCT MaBN) AS Luotsudung " +
                "FROM benhNhan_lichSu " +
                "WHERE MONTH(NgayVao) = 12 " +
                "AND YEAR(NgayVao) = 2023 " +
                "GROUP BY " +
                "DATEADD(day, (DATEPART(day, NgayVao) - 1) / 3 * 3, CAST(NgayVao AS DATE)) " +
                "ORDER BY Ngay; ";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryLuotSDPhong, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvLuotSDPhong.DataSource = dataTable;

                    chartLuotSDPhong.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Ngay", "Luotsudung", "");

                    chartLuotSDPhong.Series[0].XValueMember = "Ngay";
                    chartLuotSDPhong.Series[0].YValueMembers = "Luotsudung";
                }
            }
        }
    }
}
