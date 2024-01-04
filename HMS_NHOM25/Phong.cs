using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class Phong : Form
    {
        BaseModel phong = new BaseModel();
        PhongParams phongP;

        private string table = "phong";
        public Phong()
        {
            InitializeComponent();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInforPhong.DataSource = phong.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void txtTKTenPhong_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txtTKTenPhong.Text.Trim();
            if (timKiem == "")
            {
                Phong_Load(sender, e);
            }
            else
            {
                string query = "Select * from phong where TenPhong like '%" + timKiem + "%'";
                dgvInforPhong.DataSource = phong.Table(query);
            }
        }

        private void dgvInforPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaPhong.Text = dgvInforPhong.SelectedRows[0].Cells[0].Value.ToString();
                GetSelectedValue(dgvInforPhong.SelectedRows[0].Cells[1].Value.ToString(), cobTenPhong);
                txtSoLuongPhong.Text = dgvInforPhong.SelectedRows[0].Cells[2].Value.ToString();
                txtGiaPhong.Text = dgvInforPhong.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            AddPhong addPhong = new AddPhong();
            addPhong.Show();
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE phong SET " +
                        $"TenPhong = N'{phongP.TenPhong}', " +
                        $"SLGiuong = N'{phongP.SoLuong}', " +
                        $"TienPhong = '{phongP.TienPhong}' " +
                        $"WHERE MaPhong = '{txtMaPhong.Text}'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        phong.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        Phong_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {

        }

        private void GetSelectedValue(string selectedValue, ComboBox cob)
        {
            foreach (object item in cob.Items)
            {
                if (item.ToString() == selectedValue.Trim())
                {
                    cob.SelectedItem = item;
                    break;
                }
            }
        }

        private bool CheckTextBoxes()
        {
            if (cobTenPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn tên phòng!"); return false;
            }
            if (txtSoLuongPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!"); return false;
            }
            if (txtGiaPhong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá!"); return false;
            }
            return true;
        }

        private void GetValuesTextBoxes()
        {
            string _tenPhong = cobTenPhong.Text;
            string _soLuong = txtSoLuongPhong.Text;
            string _tienPhong = txtGiaPhong.Text;

            phongP = new PhongParams(_tenPhong, _soLuong, _tienPhong);
        }
    }
}
