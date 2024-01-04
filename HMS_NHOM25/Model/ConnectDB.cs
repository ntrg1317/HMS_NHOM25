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
        //private static string connectionString = "Data Source=DESKTOP-KMNS09Q\\SQLEXPRESS;Initial Catalog=HMS_N25;Integrated Security=True";
        private static string connectionString = @"Data Source=DESKTOP-QLAEGME\SQLEXPRESS;Initial Catalog=HMS1;Integrated Security=True";
        //private static string connectionString = @"Data Source = VANGNGUYEN\SQLEXPRESS;Initial Catalog = HMS; Integrated Security = True";
>>>>>>> 0808d5fe67621ee487a0fddf7ce954f67509c5c6
        public static SqlConnection getSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
