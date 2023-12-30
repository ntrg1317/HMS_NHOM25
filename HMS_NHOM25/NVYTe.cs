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
    public partial class NVYTe : Form
    {
        BaseModel nhanVienYTe = new BaseModel();
        private string table = "nhanVienYTe";
        public NVYTe()
        {
            InitializeComponent();
        }

        private void btnThemNVYTe_Click(object sender, EventArgs e)
        {
            AddNVYTe addNVYTe = new AddNVYTe();
            addNVYTe.Show();
        }

        private void NVYTe_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoNVYTe.DataSource = nhanVienYTe.all(table);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " +  ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
