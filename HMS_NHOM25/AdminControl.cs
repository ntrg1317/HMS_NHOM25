using HMS_NHOM25.Model;
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
    public partial class AdminControl : Form
    {

        private Form currentFormChild;
        private Button lastClickedButton;
        private bool isCollapsed;
       
        public AdminControl()
        {
            InitializeComponent();
            OpenChildForm(new BaoCaoThongKe(), btnThongKe);
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
            OpenChildForm(new Patients(), btnBN);

        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Doctors(), btnBS);
        }

        private void btnTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NVThuNgan(), btnTN);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Phong(), btnPhong);
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DonThuoc(), btnDT);
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DSHoaDon(), btnHD);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DichVu(), btnDvu);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TaiKhoan(), btnTK);
        }

        private void btnDS_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new DuocSi(), btnDS);
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
    }
}
