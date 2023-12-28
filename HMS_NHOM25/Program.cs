using System;
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

            //Application.Run(new login());
            //Application.Run(new AddThuoc());
            //Application.Run(new Doctors());
            //Application.Run(new Admin());
            //Application.Run(new NVYTe());
            //Application.Run(new NVThuNgan());
            Application.Run(new AddDonThuoc());
            //Application.Run(new AdminControl());
        }
    }
}
