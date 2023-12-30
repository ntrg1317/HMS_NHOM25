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
    public partial class Doctors : Form
    {
        BaseModel bacSi = new BaseModel();
        private string table = "bacSi";
        public Doctors()
        {
            InitializeComponent();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            try
            {
                dgvInfoBS.DataSource = bacSi.all(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
        }
    }
}
