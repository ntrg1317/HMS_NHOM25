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
        public AdminControl()
        {
            InitializeComponent();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

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
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            // Revert the appearance of the last clicked button
            if (lastClickedButton != null && lastClickedButton != clickedButton)
            {
                lastClickedButton.BackColor = SystemColors.Highlight;
                lastClickedButton.ForeColor = Color.White;
            }

            // Highlight the selected button
            clickedButton.BackColor = SystemColors.Control;
            clickedButton.ForeColor = SystemColors.Highlight;

            // Update the last clicked button
            lastClickedButton = clickedButton;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnBN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Patients(), btnBN);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Danh_sách_bác_sĩ(), btnBS);
        }

        private void btnTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NVThuNgan(), btnTN);
        }

        private void btnYT_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new NVYTe(), btnYT);
        }
    }
}
