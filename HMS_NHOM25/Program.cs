using System;
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
            //Application.Run(new AdminControl("string"));
            //Application.Run(new ThongKeDuLieu());
            //Application.Run(new login());
            //Application.Run(new AdminControl());
            Application.Run(new AdminControl("string"));
            //Application.Run(new login());

            //Application.Run(new login());
           // Application.Run(new login());
            //Application.Run(new DSHoaDon());

            //Application.Run(new DVSuDung());
        }
    }
}
