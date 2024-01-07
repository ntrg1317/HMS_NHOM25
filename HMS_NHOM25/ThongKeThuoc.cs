using HMS_NHOM25.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ThongKeThuoc : Form
    {
        public ThongKeThuoc()
        {
            InitializeComponent();
        }

        private void ThongKeThuoc_Load(object sender, System.EventArgs e)
        {
            string querySuDungThuoc = "SELECT TOP 8 kt.TenThuoc, SUM(dtct.SoLuong) AS SoLuong " +
        "FROM donThuocChiTiet dtct " +
        "JOIN khoThuoc kt ON dtct.MaThuoc = kt.MaThuoc " +
        "GROUP BY kt.TenThuoc ORDER BY SoLuong DESC;";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(querySuDungThuoc, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvSuDungThuoc.DataSource = dataTable;

                    chartSuDungThuoc.Series[0].Points.DataBind(dataTable.AsEnumerable(), "TenThuoc", "SoLuong", "");

                    chartSuDungThuoc.Series[0].XValueMember = "TenThuoc";
                    chartSuDungThuoc.Series[0].YValueMembers = "SoLuong";
                }
            }
        }
    }
}
