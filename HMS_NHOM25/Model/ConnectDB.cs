using System.Data.SqlClient;

namespace HMS_NHOM25.Model
{
    class ConnectDB
    { 
        private static string connectionString = @"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;Initial Catalog=dboHMS;Integrated Security=True;";
        public static SqlConnection getSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
