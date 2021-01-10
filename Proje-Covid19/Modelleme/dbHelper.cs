using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Proje_Covid19.Modelleme
{
    public static class dbHelper
    {
        public static DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = null;
            try
            {
                string conString = "Server = DESKTOP-L4DKVAR; Database = smscov; Trusted_Connection = True;";
                connection = new SqlConnection(conString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static int ExecuteNonQuery(string query)
        {
            SqlConnection connection = null;
            try 
            { 
                string conString = "Server = DESKTOP-L4DKVAR; Database = smscov; Trusted_Connection = True;";
                connection = new SqlConnection(conString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                SqlCommand command = new SqlCommand(query,connection);
                return command.ExecuteNonQuery();
                }
                else
                {
                throw new Exception("Unable to execute query");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
