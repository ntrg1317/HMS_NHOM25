using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HMS_NHOM25.Model
{
    class ConnectDB
    {
<<<<<<< HEAD
       // private static string connectionString = "Data Source=DESKTOP-KMNS09Q\\SQLEXPRESS;Initial Catalog=HMS_N25;Integrated Security=True";
        //private static string connectionString = @"Data Source=DESKTOP-QLAEGME\SQLEXPRESS;Initial Catalog=HMS1;Integrated Security=True";
        private static string connectionString = @"Data Source = VANGNGUYEN\SQLEXPRESS;Initial Catalog = HMS; Integrated Security = True";

        //private static string connectionString = "Data Source=DESKTOP-KMNS09Q\\SQLEXPRESS;Initial Catalog=HMS_N25;Integrated Security=True";
        //private static string connectionString = @"Data Source=DESKTOP-QLAEGME\SQLEXPRESS;Initial Catalog=HMS1;Integrated Security=True";
=======
        private static string connectionString = "Data Source=DESKTOP-KMNS09Q\\SQLEXPRESS;Initial Catalog=HMS_N25;Integrated Security=True";
        //private static string connectionString = @"Data Source=DESKTOP-QLAEGME\SQLEXPRESS;Initial Catalog=DBO;Integrated Security=True";\
>>>>>>> ea7b1618e636e711068df24cd37e0f485051a2bd
        //private static string connectionString = @"Data Source = VANGNGUYEN\SQLEXPRESS;Initial Catalog = HMS; Integrated Security = True";
        public static SqlConnection getSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
