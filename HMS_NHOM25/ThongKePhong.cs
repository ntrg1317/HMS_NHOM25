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
            string queryLuotSDPhong = "SELECT  " +
                "FORMAT(DATEADD(day, (DATEDIFF(day, 0, bnl.NgayVao) / 5) * 5, 0), 'yyyy-MM-dd') AS Ngay, " +
                "COUNT(*) AS Luotsudung " +
                "FROM benhNhan bn " +
                "INNER JOIN benhNhan_lichSu bnl ON bn.MaBN = bnl.MaBN " +
                "WHERE bn.TrangThai = 1 " +
                "AND MONTH(bnl.NgayVao) = 1 " +
                "AND YEAR(bnl.NgayVao) = 2024 " +
                "GROUP BY FORMAT(DATEADD(day, (DATEDIFF(day, 0, bnl.NgayVao) / 5) * 5, 0), 'yyyy-MM-dd') " +
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
            dgvLuotSDPhong.Columns["Ngay"].HeaderText = "Ngày";
            dgvLuotSDPhong.Columns["Luotsudung"].HeaderText = "Số lượt sử dụng";
        }
    }
}
