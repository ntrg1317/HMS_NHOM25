using System;
using System.Drawing;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class BaoCaoThongKe : Form
    {
        public BaoCaoThongKe()
        {
            InitializeComponent();
            OpenChildForm(new ThongKeBenhNhan(), btnTKBenhNhan);
        }
        private Form currentFormChild;
        private Button lastClickedButton;

        private void OpenChildForm(Form childForm, Button clickedButton)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHienThi.Controls.Add(childForm);
            panelHienThi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            if (lastClickedButton != null && lastClickedButton != clickedButton)
            {
                lastClickedButton.BackColor = Color.Lavender;
                lastClickedButton.ForeColor = SystemColors.HotTrack;
            }

            clickedButton.BackColor = SystemColors.Highlight;
            clickedButton.ForeColor = Color.Lavender;

            lastClickedButton = clickedButton;
        }
        private void panelDanhMuc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTKDoanhthu_Resize(object sender, EventArgs e)
        {
        }

        private void btnTKBenhNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeBenhNhan(), btnTKBenhNhan);
        }

        private void btnTKBenhly_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeBenhLy(), btnTKBenhly);
        }

        private void btnTKNhansu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeNhanSu(), btnTKNhansu);
        }

        private void btnTKThuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeThuoc(), btnTKThuoc);
        }

        private void btnTKPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKePhong(), btnTKPhong);
        }

        private void btnTKHoaDonThanhToan_Click(object sender, EventArgs e)
        {
        }

        private void btnTKDoanhthu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeDoanhThu(), btnTKDoanhthu);
        }
    }
}
