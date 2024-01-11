using System;
using System.Collections.Generic;
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

        public void Command(string query, SqlTransaction transaction = null)
        {
            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();

                if (transaction != null)
                {
                    command = new SqlCommand(query, sqlConnection, transaction);
                }
                else
                {
                    command = new SqlCommand(query, sqlConnection);
                }

                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public DataTable Table(string query, Dictionary<string, object> parameters = null)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    using (adapter = new SqlDataAdapter(sqlCommand))
                    {
                        adapter.Fill(datatable);
                    }
                }

                sqlConnection.Close();
            }
            return datatable;
        }


        public int getLastInsertID(string pk, string table)
        {
            string query = "SELECT TOP(1) " + pk + " FROM " + table + " ORDER BY 1 DESC";
            int id;

            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();
                id = Convert.ToInt32(command.ExecuteScalar());
                sqlConnection.Close();
            }
            return id;
        }

        public string GetAStringValue(string query)
        {
            string result;
            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();
                result = command.ExecuteScalar().ToString();
                sqlConnection.Close();
            }
            return result;
        }

        public int GetAIntValue(string query)
        {
            int result;
            using (SqlConnection sqlConnection = ConnectDB.getSqlConnection())
            {
                sqlConnection.Open();
                command = new SqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();
                result = Convert.ToInt32(command.ExecuteScalar());
                sqlConnection.Close();
            }
            return result;
        }
    }
}
