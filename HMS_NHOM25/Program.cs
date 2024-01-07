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

<<<<<<< HEAD
            //Application.Run(new login());
=======
            Application.Run(new AdminControl());
>>>>>>> f3faea4fa332c5d8d1b9563a77a7a480edd64fe8
            //Application.Run(new ThongKeDuLieu());
            Application.Run(new AdminControl());
        }
    }
}
