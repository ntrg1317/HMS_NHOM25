﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_NHOM25
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            //Application.Run(new login());
            Application.Run(new SuaTTTK());
=======

            //Application.Run(new login());
            //Application.Run(new Patients());
            //Application.Run(new Danh_sách_bác_sĩ());
            //Application.Run(new Admin());
            //Application.Run(new NVYTe());
            //Application.Run(new NVThuNgan());
            //Application.Run(new AddDoctor());
            Application.Run(new AdminControl());
>>>>>>> 2f3424125f6142f65cee9fced2ca7395c0147d97
        }
    }
}
