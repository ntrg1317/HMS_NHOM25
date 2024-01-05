﻿using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class KhoThuoc : Form
    {
        BaseModel basemodel = new BaseModel();
        KhoThuocParams ktp;

        private string table = "khoThuoc";
        public KhoThuoc()
        {
            InitializeComponent();
        }

        private void KhoThuoc_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoKhoThuoc.DataSource = basemodel.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            AddThuoc addThuoc = new AddThuoc();
            addThuoc.Show();
        }

        private void btnCapNhatThuoc_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE khoThuoc SET " +
                        $"TenThuoc = N'{ktp.TenThuoc}', " +
                        $"SoLuong = N'{ktp.SoLuong}', " +
                        $"NSX = N'{ktp.NSX}', " +
                        $"HSD = N'{ktp.HSD}'" +
                        $"WHERE MaThuoc = '{txtMaThuoc.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        basemodel.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        KhoThuoc_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            string choose = dgvInfoKhoThuoc.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "DELETE KhoThuoc";
            query1 += "Where MaThuoc ='" + choose + "'";
            if (dgvInfoKhoThuoc.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        basemodel.Command(query1);
                        MessageBox.Show("Xóa thông tin thành công!");
                        KhoThuoc_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void txtTimKiemThuoc_TextChanged(object sender, EventArgs e)
        {
            string name = txtTimKiemThuoc.Text.Trim();
            if (name == "")
            {
                KhoThuoc_Load(sender, e);
            }
            else
            {
                string query = "Select * from bacSi where TenBS like '%" + name + "%'";
                dgvInfoKhoThuoc.DataSource = basemodel.Table(query);
            }
        }

        private void dgvInfoKhoThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaThuoc.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[0].Value.ToString();
                txtTenThuoc.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[1].Value.ToString();
                txtSoLuongThuoc.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[2].Value.ToString();
                dateNSX.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[3].Value.ToString();
                dateHSD.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[4].Value.ToString();
                txtGiaThuoc.Text = dgvInfoKhoThuoc.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckTextBoxes()
        {
            if (txtTenThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên thuốc!"); return false;
            }
            if (txtSoLuongThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!"); return false;
            }
            if (dateNSX.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sản xuất!"); return false;
            }
            if (dateHSD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hạn sử dụng!"); return false;
            }
            if (txtGiaThuoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá thuốc!"); return false;
            }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _tenThuoc = txtTenThuoc.Text;
            string _soLuong = txtSoLuongThuoc.Text;
            string _nsx = dateNSX.Text;
            string _hsd = dateHSD.Text;
            string _tienThuoc = txtGiaThuoc.Text;
            ktp = new KhoThuocParams(_tenThuoc, _soLuong, _nsx, _hsd, _tienThuoc);
        }

        private void txtGiaThuoc_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
