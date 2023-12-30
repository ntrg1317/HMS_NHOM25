using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace HMS_NHOM25.Model
{
    class BaseModel
    { 
        SqlDataAdapter adapter;
        public DataTable all(string table)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM " + table;
            using(SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(dt); 
                sqlConnection.Close();
            }
            return dt;
        }
    }
}
