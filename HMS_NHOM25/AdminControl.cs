using HMS_NHOM25.Model;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class AdminControl : Form
    {
        bool isExit;
        private Form currentFormChild;
        private Button lastClickedButton;
        private bool isCollapsed;
        BaseModel info = new BaseModel();

        public AdminControl()
        {
            InitializeComponent();
        }

        string TenDN;
        int MaCV;
        public AdminControl(string tenDN)
        {
            InitializeComponent();
            OpenChildForm(new BaoCaoThongKe(), btnThongKe);

            TenDN = tenDN;
            var userInfo = getInfo(TenDN);

            labTenDN.Text = tenDN;
            txtTen.Text = userInfo.name;
            txtVaiTro.Text = userInfo.role;
        }

        private (string role, string name) getInfo(string userName)
        {
            string getRoleQuery = @"SELECT TenCV 
                        FROM chucVu AS cv 
                        JOIN taiKhoan AS tk 
                        ON tk.MaCV = cv.MaCV 
                        WHERE tk.TenDN = '" + TenDN + "'";

            string getRoleId = @"SELECT cv.MaCV 
                        FROM chucVu AS cv 
                        JOIN taiKhoan AS tk 
                        ON tk.MaCV = cv.MaCV 
                        WHERE tk.TenDN = '" + TenDN + "'";


            string role = info.GetAStringValue(getRoleQuery).Trim();
            int roleId = info.GetAIntValue(getRoleId);
            MaCV = roleId;
            string name = getName(roleId);
            return (role, name);
        }
        private string getName(int roleId)
        {
            string tableName = "";
            string columnName = "";
            string idColumnName = "";
            switch (roleId)
            {
                case 1:
                    tableName = "quanTriVien";
                    columnName = "TenQL";
                    idColumnName = "MaQL";
                    break;
                case 2:
                    tableName = "benhNhan";
                    columnName = "TenBN";
                    idColumnName = "MaBN";
                    break;
                case 3:
                    tableName = "bacSi";
                    columnName = "TenBS";
                    idColumnName = "MaBS";
                    break;
                case 4:
                    tableName = "duocSi";
                    columnName = "TenNV";
                    idColumnName = "MaNV";
                    break;
                case 5:
                    tableName = "nhanVienThuNgan";
                    columnName = "TenNV";
                    idColumnName = "MaNV";
                    break;
            }

            string query = $@"SELECT {columnName} FROM {tableName} AS nv  JOIN taiKhoan AS tk 
                            ON tk.MaTK = nv.{idColumnName} 
                            WHERE tk.TenDN = '{TenDN}'";


            return info.GetAStringValue(query);
        }


        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, Button clickedButton)
        {
            currentFormChild?.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            if (lastClickedButton != null && lastClickedButton != clickedButton)
            {
                lastClickedButton.BackColor = SystemColors.Highlight;
                lastClickedButton.ForeColor = Color.White;
            }

            clickedButton.BackColor = SystemColors.Control;
            clickedButton.ForeColor = SystemColors.Highlight;

            lastClickedButton = clickedButton;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BaoCaoThongKe(), btnThongKe);
        }

        private void btnBN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DanhMuc(), btnDanhMuc);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelUser.Height += 10;
                if (panelUser.Size == panelUser.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                panelUser.Height -= 10;
                if (panelUser.Size == panelUser.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void AdminControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
            isExit = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Close();
            login login = new login();
            login.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Close();
            login login = new login();
            login.Show();
        }

        private void picChangPw_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SuaTTTK(), btnChangePw);
            isCollapsed = false;
            timer1_Tick(sender, e);
        }

        private void btnChangePw_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SuaTTTK(), btnChangePw);
            isCollapsed = false;
            timer1_Tick(sender, e);
        }

        private void btnKhoThuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhoThuoc(), btnHeThong);
        }

        private void btnQly_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLy(), btnQly);
        }

        private void panelBody_Click(object sender, EventArgs e)
        {

        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            switch(MaCV)
            {
                case 1:
                    OpenChildForm(new TTCNAdmin(TenDN), btnHeThong);
                    break;
                case 2:
                    OpenChildForm(new TTCNBacSi(), btnHeThong);
                    break;
                case 3:
                    OpenChildForm(new TTCNBenhNhan(), btnHeThong);
                    break;
                case 4:
                    OpenChildForm(new TTCNDuocSi(), btnHeThong);
                    break;
                case 5:
                    OpenChildForm(new TTCNNhanVienTN(), btnHeThong);
                    break;
            }
            
        }
    }
}
