﻿using System;
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
    public partial class ThongKeBenhNhan : Form
    {
        public ThongKeBenhNhan()
        {
            InitializeComponent();
        }

        private static string connectionString = @"Data Source = VANGNGUYEN\SQLEXPRESS;Initial Catalog = HMS; Integrated Security = True";


        private void ThongKeBenhNhan_Load(object sender, EventArgs e)
        {

            string query1 = "SELECT MONTH(NgayVao) AS Thang, COUNT(*) AS SoLuongBenhNhan FROM BenhNhan WHERE YEAR(NgayVao) = 2024 GROUP BY MONTH(NgayVao) ORDER BY Thang";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query1, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    chartSLBN2024.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Thang", "SoLuongBenhNhan", "");

                    // Cập nhật trục X và trục Y
                    chartSLBN2024.Series[0].XValueMember = "Thang";
                    chartSLBN2024.Series[0].YValueMembers = "SoLuongBenhNhan";
                }
            }

            string query2 = "SELECT YEAR(NgayVao) AS Nam, COUNT(*) AS SoLuongBenhNhan FROM benhNhan GROUP BY YEAR(NgayVao) ORDER BY Nam;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query2, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Thiết lập nguồn dữ liệu cho biểu đồ
                    chartSLBNtheoNam.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Nam", "SoLuongBenhNhan", "");

                    // Cập nhật trục X và trục Y
                    chartSLBNtheoNam.Series[0].XValueMember = "Nam";
                    chartSLBNtheoNam.Series[0].YValueMembers = "SoLuongBenhNhan";
                }

            }
            string query3 = "SELECT MONTH(NgayVao) AS Thang, COUNT(*) AS SoLuongBenhNhan FROM BenhNhan WHERE YEAR(NgayVao) = 2023 GROUP BY MONTH(NgayVao) ORDER BY Thang";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query3, connection))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    chartSLBN2023.Series[0].Points.DataBind(dataTable.AsEnumerable(), "Thang", "SoLuongBenhNhan", "");

                    chartSLBN2023.Series[0].XValueMember = "Thang";
                    chartSLBN2023.Series[0].YValueMembers = "SoLuongBenhNhan";
                }
            }
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
    }
}
