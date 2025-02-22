﻿using HMS_NHOM25.Model;
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
                string query = "SELECT 'BacSi' AS NhanVien, COUNT(*) AS SoLuong FROM bacSi " +
                               "UNION ALL " +
                               "SELECT 'DuocSi' AS NhanVien, COUNT(*) AS SoLuong FROM duocSi " +
                               "UNION ALL " +
                               "SELECT 'NhanVienThuNgan' AS NhanVien, COUNT(*) AS SoLuong FROM nhanVienThuNgan";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (var point in chart1.Series[0].Points)
                {
                    point.Label = point.YValues[0].ToString();

                    switch (point.AxisLabel)
                    {
                        case "BacSi":
                            point.LegendText = "Bác sĩ";
                            break;
                        case "DuocSi":
                            point.LegendText = "Dược sĩ";
                            break;
                        case "NhanVienThuNgan":
                            point.LegendText = "Nhân viên thu ngân";
                            break;
                        default:
                            break;
                    }
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["NhanVien"].ToString() == "BacSi")
                    {
                        row["NhanVien"] = "Bác sĩ";
                    }
                    if (row["NhanVien"].ToString() == "DuocSi")
                    {
                        row["NhanVien"] = "Dược sĩ";
                    }
                    if (row["NhanVien"].ToString() == "NhanVienThuNgan")
                    {
                        row["NhanVien"] = "Nhân viên thu ngân";
                    }
                }
                dgvSLNhanSu.DataSource = dataTable;

                chart1.Series[0].Points.DataBind(dataTable.AsEnumerable(), "NhanVien", "SoLuong", "");

                chart1.Series[0].Name = "NhanVien";

                

            }
            dgvSLNhanSu.Columns["NhanVien"].HeaderText = "Nhân viên";
            dgvSLNhanSu.Columns["SoLuong"].HeaderText = "Số lượng";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
