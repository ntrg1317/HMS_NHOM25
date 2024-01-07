using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
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
    public partial class AddDonThuoc : Form
    {
        BaseModel thuoc = new BaseModel();
        BaseModel benhNhan = new BaseModel();
        ChiTietDTParams chiTietDT;
        DataTable dataTableDTChiTiet;

        public AddDonThuoc()
        {
            InitializeComponent();
        }

        private void AddDonThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                if (dgvInforKeDonThuoc != null)
                {
                    // Initialize dataTableDTChiTiet
                    dataTableDTChiTiet = new DataTable();
                    dataTableDTChiTiet.Columns.Add("MaThuoc");
                    dataTableDTChiTiet.Columns.Add("TenThuoc");
                    dataTableDTChiTiet.Columns.Add("SoLuong");
                    dataTableDTChiTiet.Columns.Add("LieuDung");
                    dataTableDTChiTiet.Columns.Add("LoiDan");

                    // Set the DataTable as the DataSource for the DataGridView
                    dgvInforKeDonThuoc.DataSource = dataTableDTChiTiet;
                }
                else
                {
                    MessageBox.Show("dgvInforKeDonThuoc is null. Check your form designer.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            DeleteTextBoxes();
            showComboBox();
        }

        private void txtSoLuongThuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                try
                {
                    DataRow dr = dataTableDTChiTiet.NewRow();

                    if (int.TryParse(cobTenThuoc.SelectedValue?.ToString(), out int maThuoc))
                    {
                        dr["MaThuoc"] = maThuoc;
                        dr["TenThuoc"] = cobTenThuoc.Text;
                        dr["SoLuong"] = txtSoLuongThuoc.Text;
                        dr["LieuDung"] = richTxtBoxLD.Text;
                        dr["LoiDan"] = richTxtLoiDan.Text;

                        dataTableDTChiTiet.Rows.Add(dr);

                        dgvInforKeDonThuoc.DataSource = null;
                        dgvInforKeDonThuoc.DataSource = dataTableDTChiTiet;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }    
        }

        private void btnSuaKeThuoc_Click(object sender, EventArgs e)
        {
            if (dgvInforKeDonThuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvInforKeDonThuoc.SelectedRows[0];
                
                selectedRow.Cells["TenThuoc"].Value = cobTenThuoc.Text;
                selectedRow.Cells["SoLuong"].Value = txtSoLuongThuoc.Text;
                selectedRow.Cells["LieuDung"].Value = richTxtBoxLD.Text;
                selectedRow.Cells["LoiDan"].Value = richTxtLoiDan.Text;

                dgvInforKeDonThuoc.Refresh();
            }
            else
            {
                MessageBox.Show("Chưa chọn thuốc để cập nhật!");
            }
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInforKeDonThuoc.SelectedRows.Count > 0)
                {
                    dgvInforKeDonThuoc.Rows.Remove(dgvInforKeDonThuoc.SelectedRows[0]);
                }
                else
                {
                    MessageBox.Show("Chưa chọn thuốc để xoá!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveInfoDonThuoc_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
                {
                    sqlConnection.Open();

                    SqlTransaction transaction = sqlConnection.BeginTransaction();
                    GetValuesTextBoxes();

                    string insertToDT = "INSERT INTO donThuoc (MaBN) VALUES ('" + chiTietDT.MaBN + "')";

                    try
                    {
                        if (MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            thuoc.Command(insertToDT);
                            int id = thuoc.getLastInsertID("MaDT", "donThuoc");

                            foreach (DataGridViewRow r in dgvInforKeDonThuoc.Rows)
                            {
                                string MaThuoc = r.Cells[0].Value.ToString();
                                string SoLuong = r.Cells[2].Value.ToString();
                                string LieuDung = r.Cells[3].Value.ToString();
                                string LoiDan = r.Cells[4].Value.ToString();

                                string insertToDTCT = "INSERT INTO donThuocChiTiet (MaDT, MaThuoc, SoLuong, LieuDung, LoiDan) VALUES " +
                                "('" + id + "', '" + MaThuoc + "', '" + SoLuong + "', N'" + LieuDung + "',  N'" + LoiDan + "')";
                                thuoc.Command(insertToDTCT);
                            }

                            transaction.Commit();

                            MessageBox.Show("Lưu thông tin thành công!");
                            AddDonThuoc_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        private void btnThoatAddDonThuoc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvInforDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                cobTenThuoc.Text  = dgvInforKeDonThuoc.SelectedRows[0].Cells["TenThuoc"].Value.ToString();
                txtSoLuongThuoc.Text = dgvInforKeDonThuoc.SelectedRows[0].Cells["SoLuong"].Value.ToString();
                richTxtBoxLD.Text = dgvInforKeDonThuoc.SelectedRows[0].Cells["LieuDung"].Value.ToString();
                richTxtLoiDan.Text = dgvInforKeDonThuoc.SelectedRows[0].Cells["LoiDan"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTextBoxes()
        {
            cobTenThuoc.Text = "";
            txtSoLuongThuoc.Text = "";
            richTxtBoxLD.Text = "";
            richTxtLoiDan.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if (txtSDTBN.Text.Length < 0)
            {
                MessageBox.Show("Bạn chưa chọn bệnh nhân để kê đơn!"); return false;
            }
            if (cobTenThuoc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn tên thuốc!"); return false;
            }
            if (txtSoLuongThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!"); return false;
            }
            if (richTxtBoxLD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập liều dùng!"); return false;
            }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _maBn = txtMaBN.Text;
            object _maThuoc = (cobTenThuoc.SelectedIndex != -1) ? (int)cobTenThuoc.SelectedValue : (object)DBNull.Value;
            string _soLuong = txtSoLuongThuoc.Text;
            string _lieuDung = richTxtBoxLD.Text;
            string _loiDan = richTxtLoiDan.Text;
            chiTietDT = new ChiTietDTParams(_maBn, _maThuoc, _soLuong, _lieuDung, _loiDan);
        }

        private void showComboBox()
        {
            DataTable dt = thuoc.all("khoThuoc");

            cobTenThuoc.DataSource = dt;
            cobTenThuoc.DisplayMember = "TenThuoc";
            cobTenThuoc.ValueMember = "MaThuoc";

            cobTenThuoc.SelectedIndex = -1;
        }

        private void txtSDTBN_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtSDTBN.Text.Trim();

            if (timKiem == "")
            {
                AddDonThuoc_Load(sender, e);
            }
            else
            {
                string query = "Select * from benhNhan where SDT like '%" + timKiem + "%'";

                dgvTimBN.DataSource = benhNhan.Table(query);
            }
        }

        private void dgvTimBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtSDTBN.Text = dgvTimBN.SelectedRows[0].Cells["SDT"].Value.ToString();
                txtMaBN.Text = dgvTimBN.SelectedRows[0].Cells["MaBN"].Value.ToString();
                txtTenBN.Text = dgvTimBN.SelectedRows[0].Cells["TenBN"].Value.ToString();
                txtGT.Text = dgvTimBN.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
                txtBenhTrang.Text = dgvTimBN.SelectedRows[0].Cells["BenhTrang"].Value.ToString();
                txtDiaChi.Text = dgvTimBN.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
