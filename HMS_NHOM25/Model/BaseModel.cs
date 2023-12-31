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
        SqlCommand command;
        public BaseModel() { }
        public DataTable all(string table)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM " + table;
            Console.WriteLine("SQL Query: " + query);  // Print the SQL query to the console
            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(dt);
                sqlConnection.Close();
            }
            return dt;
        }

        public DataTable Table(string query)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(datatable);
                sqlConnection.Close();
            }
            return datatable;
        }

        public void Command(string query)
        {
            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }    
        }

        public int getLastInsertID(string query)
        {
            int pk;
            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();
                pk = Convert.ToInt32(command.ExecuteScalar());
                sqlConnection.Close();
            }
            return pk;
        }
    }
}
