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

        private void cobTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobTenDV.SelectedIndex != -1)
            {
                if (int.TryParse(cobTenDV.SelectedValue.ToString(), out int madv))
                {
                    string findGiaDV = "SELECT TienDV FROM dichVu WHERE MaDV = '" + madv + "'";
                    txtGiaDV.Text = bn_dv.GetAStringValue(findGiaDV);
                }
            }
            else
            {
                txtGiaDV.Text = string.Empty;
            }
        }


    }
}
