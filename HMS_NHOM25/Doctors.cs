using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
using System;
using System.Collections;
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
    public partial class Doctors : Form
    {
        BaseModel bacSi = new BaseModel();
        InforBS qlBacSi;

        private string table = "bacSi";
        public Doctors()
        {
            InitializeComponent();
        }

        public void Doctors_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoBS.DataSource = bacSi.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }

        private void txtTimKiemBS_TextChanged(object sender, EventArgs e)
        {
            string nameBS = txtTimKiemBS.Text.Trim();
            if(nameBS == "")
            {
                Doctors_Load(sender, e);
            }
            else
            {
                string query = "Select * from bacSi where TenBS like '%"+nameBS+"%'";
                dgvInfoBS.DataSource = bacSi.Table(query);
            }
        }
        private void DeleteTextBoxes()
        {
            txtTenBS.Text = "";
            DOBBS.Text = "";
            cobSexBS.SelectedIndex = -1;
            txtSDTBS.Text = "";
            cobDiaChiBS.Text = "";
            cobChuyenMonBS.SelectedIndex = -1;
            txtBangCapBS.Text = "";
            cobTrangThaiBS.SelectedIndex = -1;

        }
        private bool CheckTextBoxes()
        {
            if (txtTenBS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên!"); return false;
            }
            if (DOBBS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!"); return false;
            }
            if (cobSexBS.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giới tính!"); return false;
            }
            if (txtSDTBS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!"); return false;
            }
            if (cobDiaChiBS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!"); return false;
            }
            if (cobChuyenMonBS.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn chuyên môn!"); return false;
            }
            if (txtBangCapBS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập bằng cấp!"); return false;
            }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            int _maBS = int.Parse(txtMaBS.Text);
            string _tenBS = txtTenBS.Text;
            string _ngaySinh = DOBBS.Text;
            string _gioiTinh = cobSexBS.Text;
            string _sdt = txtSDTBS.Text;
            string _diaChi = cobDiaChiBS.Text;
            string _chuyenMon = cobChuyenMonBS.Text;
            string _bangCap = txtBangCapBS.Text;
            int _trangThai = int.Parse(cobTrangThaiBS.Text);
            qlBacSi = new InforBS(_maBS, _tenBS, _ngaySinh, _gioiTinh, _sdt, _diaChi, _chuyenMon, _bangCap, _trangThai);

        }
        private void btnSuaBS_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "UPDATE bacSi SET TenBS = N'" + qlBacSi.TenBS + "' ,NgaySinh = N'" + qlBacSi.NgaySinh + "',GioiTinh = N'" + qlBacSi.GioiTinh + "',DiaChi = N'" + qlBacSi.DiaChi + "',ChuyenMon = N'" + qlBacSi.ChuyenMon + "',BangCap = N'" + qlBacSi.BangCap + "',TrangThai =  '" + qlBacSi.TrangThai + "'";
                query1 += "Where MaBS = '" + qlBacSi.MaBS + "'";
                try
                {
                    if (MessageBox.Show("Bạn có muốn cập nhật thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        bacSi.Command(query1);
                        MessageBox.Show("Cập nhật thông tin thành công!");
                        Doctors_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaBS_Click(object sender, EventArgs e)
        {
            string choose = dgvInfoBS.SelectedRows[0].Cells[0].Value.ToString();
            string query1 = "DELETE bacSi";
            query1 += "Where MaBS ='" + choose + "'";
            string query2 = "DELETE taiKhoan";
            query2 += "Where MaTK ='" + choose + "'";
            if (dgvInfoBS.Rows.Count > 1)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        bacSi.Command(query1);
                        bacSi.Command(query2);
                        MessageBox.Show("Xóa thông tin thành công!");
                        Doctors_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgvInfoBS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBS.Text = dgvInfoBS.SelectedRows[0].Cells[0].Value.ToString();
            txtTenBS.Text = dgvInfoBS.SelectedRows[0].Cells[1].Value.ToString();
            DOBBS.Text = dgvInfoBS.SelectedRows[0].Cells[2].Value.ToString();
            cobSexBS.Text = dgvInfoBS.SelectedRows[0].Cells[3].Value.ToString();
            txtSDTBS.Text = dgvInfoBS.SelectedRows[0].Cells[4].Value.ToString();
            cobDiaChiBS.Text = dgvInfoBS.SelectedRows[0].Cells[5].Value.ToString();
            cobChuyenMonBS.Text = dgvInfoBS.SelectedRows[0].Cells[6].Value.ToString();
            txtBangCapBS.Text = dgvInfoBS.SelectedRows[0].Cells[7].Value.ToString();
            cobTrangThaiBS.Text = dgvInfoBS.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnThemBS_Click(object sender, EventArgs e)
        {
            AddDoctor doctor = new AddDoctor();
            doctor.Show();
        }
    }
}
