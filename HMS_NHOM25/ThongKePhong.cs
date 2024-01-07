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
            string queryLuotSDPhong = "SELECT DATEADD(day, (DATEPART(day, NgayVao) - 1) / 3 * 3, CAST(NgayVao AS DATE)) AS Ngay," +
                "COUNT(*) AS LuotSuDung FROM BenhNhan WHERE TrangThai = 1 AND MONTH(NgayVao) = 1 AND YEAR(NgayVao) = 2024" +
                "GROUP BY DATEADD(day, (DATEPART(day, NgayVao) - 1) / 3 * 3, CAST(NgayVao AS DATE));";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(queryLuotSDPhong, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvLuotSDPhong.DataSource = dataTable;

                    chartLuotSDPhong.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Ngay", "LuotSuDung", "");

                    chartLuotSDPhong.Series[0].XValueMember = "Ngay";
                    chartLuotSDPhong.Series[0].YValueMembers = "LuotSuDung";
                }
            }
        }
    }
}
