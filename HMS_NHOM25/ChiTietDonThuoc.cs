using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class ChiTietDonThuoc : Form
    {
        BaseModel basemodel = new BaseModel();
        ChiTietDTParams chiTietDT;

        public ChiTietDonThuoc(string maDT, string maBN, string trangThaiTT)
        {
            InitializeComponent();
            txtMaBN.Text = maBN;
            txtMaDT.Text = maDT;
            txtTrangThaiTT.Text = trangThaiTT;
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

        private void txtTimKiemTenThuoc_TextChanged(object sender, System.EventArgs e)
        {
            string name = txtTimKiemTenThuoc.Text.Trim();
            if (name == "")
            {
                ChiTietDonThuoc_Load(sender, e);
            }
            else
            {
                try
                {
                    string tenThuoc = txtTimKiemTenThuoc.Text;

                    string query = @"
                                        SELECT dtct.MaThuoc, kthuoc.TenThuoc, dtct.SoLuong, dtct.LieuDung, dtct.LoiDan
                                        FROM donThuocChiTiet dtct
                                        JOIN khoThuoc kthuoc ON dtct.MaThuoc = kthuoc.MaThuoc
                                        WHERE kthuoc.TenThuoc LIKE @TenThuoc;";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "@TenThuoc", "%" + tenThuoc + "%" }
                    };

                    dgvInforDonThuoc.DataSource = basemodel.Table(query, parameters);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DeleteTextBoxes();
                showComboBox();
            }
        }

        private void dgvInforDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbTenThuoc.Text = dgvInforDonThuoc.SelectedRows[0].Cells[1].Value.ToString();
            txtSoLuongThuoc.Text = dgvInforDonThuoc.SelectedRows[0].Cells[2].Value.ToString();
            richTxtLieuDung.Text = dgvInforDonThuoc.SelectedRows[0].Cells[3].Value.ToString();
            richTxtLoiDan.Text = dgvInforDonThuoc.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
                {
                    sqlConnection.Open();
                    SqlTransaction transaction = sqlConnection.BeginTransaction();

                    GetValuesTextBoxes();

                    try
                    {
                        if (MessageBox.Show("Bạn có muốn lưu thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            int id = basemodel.getLastInsertID("MaDT", "donThuoc");
                            string query1 = "INSERT INTO donThuocChiTiet (MaDT, MaThuoc, SoLuong, LieuDung, LoiDan) VALUES " +
                                "('" + id + "', '" + chiTietDT.MaThuoc + "', '" + chiTietDT.SoLuong + "', N'" + chiTietDT.LieuDung + "',  N'" + chiTietDT.LoiDan + "')";
                            basemodel.Command(query1);

                            transaction.Commit();

                            MessageBox.Show("Lưu thông tin thành công!");
                            ChiTietDonThuoc_Load(sender, e);
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


        private void btnCapNhatCTDonThuoc_Click(object sender, System.EventArgs e)
        {
            if (dgvInforDonThuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvInforDonThuoc.SelectedRows[0];

                selectedRow.Cells["TenThuoc"].Value = cmbTenThuoc.Text;
                selectedRow.Cells["SoLuong"].Value = txtSoLuongThuoc.Text;
                selectedRow.Cells["LieuDung"].Value = richTxtLieuDung.Text;
                selectedRow.Cells["LoiDan"].Value = richTxtLoiDan.Text;

                dgvInforDonThuoc.Refresh();
            }
            else
            {
                MessageBox.Show("Chưa chọn thuốc để cập nhật!");
            }
        }

        private void btnXoaThuoc_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (dgvInforDonThuoc.SelectedRows.Count > 0)
                {
                    dgvInforDonThuoc.Rows.Remove(dgvInforDonThuoc.SelectedRows[0]);
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

        private void ChiTietDonThuoc_Load(object sender, EventArgs e)
        {
            if(int.Parse(txtTrangThaiTT.Text) == 0)
            {
                btnCapNhatCTDonThuoc.Enabled = true;
                btnThemThuoc.Enabled = true;
                btnXoaThuoc.Enabled = true;
            }
            try
            {
                string query = @"
                                SELECT dtct.MaThuoc, kthuoc.TenThuoc, dtct.SoLuong, dtct.LieuDung, dtct.LoiDan
                                FROM donThuocChiTiet dtct
                                JOIN khoThuoc kthuoc ON dtct.MaThuoc = kthuoc.MaThuoc;";

                DataTable resultTable = basemodel.Table(query);
                dgvInforDonThuoc.DataSource = resultTable;

                dgvInforDonThuoc.Columns["MaDT"].HeaderText = "Mã đơn thuốc";
                dgvInforDonThuoc.Columns["TenThuoc"].HeaderText = "Tên thuốc";
                dgvInforDonThuoc.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvInforDonThuoc.Columns["LieuDung"].HeaderText = "Liều dùng";
                dgvInforDonThuoc.Columns["LoiDan"].HeaderText = "Lời dặn";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DeleteTextBoxes();
            showComboBox();
        }


        private void showComboBox()
        {
            DataTable dt = basemodel.all("khoThuoc");

            cmbTenThuoc.DataSource = dt;
            cmbTenThuoc.DisplayMember = "TenThuoc";
            cmbTenThuoc.ValueMember = "MaThuoc";

            cmbTenThuoc.SelectedIndex = -1;
        }

        private void DeleteTextBoxes()
        {
            cmbTenThuoc.Text = "";
            txtSoLuongThuoc.Text = "";
            richTxtLieuDung.Text = "";
            richTxtLoiDan.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if (cmbTenThuoc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn tên thuốc!"); return false;
            }
            if (txtSoLuongThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!"); return false;
            }
            if (richTxtLieuDung.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập liều dùng!"); return false;
            }
            if (richTxtLoiDan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lời dẫn!"); return false;
            }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _maBn = txtMaBN.Text;
            object _maThuoc = (cmbTenThuoc.SelectedIndex != -1) ? (int)cmbTenThuoc.SelectedValue : (object)DBNull.Value;
            string _soLuong = txtSoLuongThuoc.Text;
            string _lieuDung = richTxtLieuDung.Text;
            string _loiDan = richTxtLoiDan.Text;
            chiTietDT = new ChiTietDTParams(_maBn, _maThuoc, _soLuong, _lieuDung, _loiDan);
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
                            basemodel.Command(insertToDT);
                            int id = basemodel.getLastInsertID("MaDT", "donThuoc");

                            foreach (DataGridViewRow r in dgvInforDonThuoc.Rows)
                            {
                                string MaThuoc = r.Cells[0].Value.ToString();
                                string SoLuong = r.Cells[2].Value.ToString();
                                string LieuDung = r.Cells[3].Value.ToString();
                                string LoiDan = r.Cells[4].Value.ToString();

                                string insertToDTCT = "INSERT INTO donThuocChiTiet (MaDT, MaThuoc, SoLuong, LieuDung, LoiDan) VALUES " +
                                "('" + id + "', '" + MaThuoc + "', '" + chiTietDT.SoLuong + "', N'" + LieuDung + "',  N'" + LoiDan + "')";
                                basemodel.Command(insertToDTCT);
                            }

                            transaction.Commit();

                            MessageBox.Show("Lưu thông tin thành công!");
                            ChiTietDonThuoc_Load(sender, e);
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
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DeleteTextBoxes();
        }
    }
}
