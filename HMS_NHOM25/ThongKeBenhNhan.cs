using HMS_NHOM25.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ThongKeBenhNhan : Form
    {
        public ThongKeBenhNhan()
        {
            InitializeComponent();
        }

        private void ThongKeBenhNhan_Load(object sender, EventArgs e)
        {

            string querySLBN2024 = "SELECT MONTH(ls.NgayVao) AS Thang, " +
                "COUNT(DISTINCT bn.MaBN) AS SoLuong " +
                "FROM benhNhan_lichSu ls " +
                "JOIN benhNhan bn ON ls.MaBN = bn.MaBN " +
                "WHERE YEAR(ls.NgayVao) = 2022 " +
                "GROUP BY MONTH(ls.NgayVao) " +
                "ORDER BY Thang;";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(querySLBN2024, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvSLBN2024.DataSource = dataTable;

                    chartSLBN2024.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Thang", "SoLuong", "");

                    // Cập nhật trục X và trục Y
                    chartSLBN2024.Series[0].XValueMember = "Thang";
                    chartSLBN2024.Series[0].YValueMembers = "SoLuong";
                }
            }
            dgvSLBN2024.Columns["Thang"].HeaderText = "Tháng";
            dgvSLBN2024.Columns["SoLuong"].HeaderText = "Số lượng";

            string querySLBNNam = "SELECT YEAR(ls.NgayVao) AS Nam, " +
                "COUNT(DISTINCT bn.MaBN) AS SoLuong " +
                "FROM benhNhan_lichSu ls " +
                "JOIN benhNhan bn ON ls.MaBN = bn.MaBN " +
                "GROUP BY YEAR(ls.NgayVao) " +
                "ORDER BY Nam;";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(querySLBNNam, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvSLBNtheoNam.DataSource = dataTable;

                    // Thiết lập nguồn dữ liệu cho biểu đồ
                    chartSLBNtheoNam.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Nam", "SoLuong", "");

                    // Cập nhật trục X và trục Y
                    chartSLBNtheoNam.Series[0].XValueMember = "Nam";
                    chartSLBNtheoNam.Series[0].YValueMembers = "SoLuong";
                }
            }
            dgvSLBNtheoNam.Columns["Nam"].HeaderText = "Năm";
            dgvSLBNtheoNam.Columns["SoLuong"].HeaderText = "Số lượng";

            string querySLBN2023 = "SELECT MONTH(ls.NgayVao) AS Thang, " +
                "COUNT(DISTINCT bn.MaBN) AS SoLuong " +
                "FROM benhNhan_lichSu ls " +
                "JOIN benhNhan bn ON ls.MaBN = bn.MaBN " +
                "WHERE YEAR(ls.NgayVao) = 2023 " +
                "GROUP BY MONTH(ls.NgayVao) " +
                "ORDER BY Thang;";
            using (SqlConnection connection = ConnectDB.getSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(querySLBN2023, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvSLBN2023.DataSource = dataTable;

                    chartSLBN2023.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Thang", "SoLuong", "");

                    chartSLBN2023.Series[0].XValueMember = "Thang";
                    chartSLBN2023.Series[0].YValueMembers = "SoLuong";
                }
            }
            dgvSLBN2023.Columns["Thang"].HeaderText = "Tháng";
            dgvSLBN2023.Columns["SoLuong"].HeaderText = "Số lượng";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartSLBNtheoNam_Click(object sender, EventArgs e)
        {

        }

        private void benhNhanBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void benhNhanBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void hMSDataSet2BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void soLuongBNtheoNamBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labTKBenhNhan_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chartSLBN2024_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartSLBN2023_Click(object sender, EventArgs e)
        {

        }

        private void labSLBN2023_Click(object sender, EventArgs e)
        {

        }

        private void dgvSLBNtheoNam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvSLBN2023_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
