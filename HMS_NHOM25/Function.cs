using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    internal class Function
    {
        private Form currentFormChild;
        private Button lastClickedButton;
        public void OpenChildForm(Form childForm, Button clickedButton, Panel panelHienThi)
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
    }
}
