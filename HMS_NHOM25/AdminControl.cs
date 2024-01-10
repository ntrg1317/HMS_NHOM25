using System;
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

        public AdminControl(string TenDN)
        {
            InitializeComponent();
            OpenChildForm(new BaoCaoThongKe(), btnThongKe);

            labTenDN.Text = TenDN;
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

        private void btnPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Phong(), btnQly);
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
    }
}
