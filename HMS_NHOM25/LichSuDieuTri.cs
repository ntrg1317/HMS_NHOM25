using HMS_NHOM25.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    public partial class LichSuDieuTri : Form
    {
        BaseModel bn;
        public LichSuDieuTri()
        {
            InitializeComponent();
        }

        private void txtSDTBN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string timKiem = txtSDTBN.Text;
                if (timKiem == "")
                {
                    LichSuDieuTri_Load(sender, e);
                }
                else
                {
                    string timKiemBN = "SELECT * FROM benhNhanh WHERE SDT LIKE %" + "'timKiem'" + "%";
                    dgvTimBN.DataSource = bn.Table(timKiemBN);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LichSuDieuTri_Load(object sender, EventArgs e)
        {

        }

        private void txtMaBN_TextChanged(object sender, EventArgs e)
        {
            string maBN = txtMaBN.Text;
            string lichSuDieuTri = "SELECT NgayVao, MaPhong, BenhTrang FROM benhNhan_lichSu";
            dgvInfoLSDT.DataSource = bn.Table(lichSuDieuTri);
        }
    }
}
