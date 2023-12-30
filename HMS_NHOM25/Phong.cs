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
    public partial class Phong : Form
    {
        BaseModel phong = new BaseModel();
        private string table = "phong";
        public Phong()
        {
            InitializeComponent();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDanhMucPhong.DataSource = phong.all(table);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

    }
}
