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
            Application.Run(new AdminControl());
            //Application.Run(new ThongKeDuLieu());
=======
            //Application.Run(new login());
            //Application.Run(new AdminControl());
>>>>>>> ab181c68edcca20d84ddac6793d7556e1efccfcf
            Application.Run(new AdminControl());
            //Application.Run(new login());

        }
    }
}
