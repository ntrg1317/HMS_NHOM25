﻿using System;
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
    public partial class TTCNAdmin : Form
    {
        public TTCNAdmin()
        {
            InitializeComponent();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            SuaTTTK suaTTTK = new SuaTTTK();
            suaTTTK.Show();
        }
    }
}
