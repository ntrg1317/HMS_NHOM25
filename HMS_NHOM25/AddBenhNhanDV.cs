using HMS_NHOM25.Model;
using HMS_NHOM25.Params;
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
    public partial class AddBenhNhanDV : Form
    {
        BaseModel bn_dv = new BaseModel();
        public AddBenhNhanDV()
        {
            InitializeComponent();
        }

        private void showComboBox()
        {
            DataTable dt = bn_dv.all("dichVu");

            cobTenDV.DataSource = dt;
            cobTenDV.DisplayMember = "TenDV";
            cobTenDV.ValueMember = "MaDV";

            cobTenDV.SelectedIndex = -1;
        }

        private void AddBenhNhanDV_Load(object sender, EventArgs e)
        {
            showComboBox();
        }
    }
}
