using System.Data.SqlClient;

namespace HMS_NHOM25.Model
{
    class ConnectDB
    { 
        private static string connectionString = @"Data Source=DESKTOP-QLAEGME\SQLEXPRESS;Initial Catalog=dbo2;Integrated Security=True";
        public static SqlConnection getSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
