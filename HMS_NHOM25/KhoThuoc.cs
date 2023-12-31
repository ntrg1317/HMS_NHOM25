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
    public partial class KhoThuoc : Form
    {
        public KhoThuoc()
        {
            InitializeComponent();
        }

        private void KhoThuoc_Load(object sender, EventArgs e)
        {

        }
        private void btnThemBS_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.Show();
        }
    }
}
