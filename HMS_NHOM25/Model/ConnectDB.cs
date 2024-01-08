using System.Data.SqlClient;

namespace HMS_NHOM25.Model
{
    class ConnectDB
    {
<<<<<<< HEAD
        //private static string connectionString = "Data Source=DESKTOP-KMNS09Q\\SQLEXPRESS;Initial Catalog=HMS_N25;Integrated Security=True;";
        private static string connectionString = @"Data Source=VANGNGUYEN\SQLEXPRESS;Initial Catalog=dboHMS;Integrated Security=True";
        //private static string connectionString = @"Data Source=DESKTOP-QLAEGME\SQLEXPRESS;Initial Catalog=DBO;Integrated Security=True";
=======
        private static string connectionString = "Data Source=DESKTOP-KMNS09Q\\SQLEXPRESS;Initial Catalog=HMS_N25;Integrated Security=True;";
        //private static string connectionString = @"Data Source = VANGNGUYEN\SQLEXPRESS;Initial Catalog = HMS; Integrated Security = True";
        //private static string connectionString = @"Data Source=DESKTOP-QLAEGME\SQLEXPRESS;Initial Catalog=DBO1;Integrated Security=True";

>>>>>>> 7c3fcae40dda752e00d974146709275fe465b86d
        public static SqlConnection getSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
