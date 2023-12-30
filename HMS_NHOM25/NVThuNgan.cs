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
    public partial class NVThuNgan : Form
    {
        BaseModel nvtn = new BaseModel();
        private string table = "nhanVienThuNgan";
        public NVThuNgan()
        {
            InitializeComponent();
        }

        private void btnThemNVTN_Click(object sender, EventArgs e)
        {
            AddNVTN addNVTN = new AddNVTN();
            addNVTN.Show();
        }

        private void NVThuNgan_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoNVTN.DataSource = nvtn.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
