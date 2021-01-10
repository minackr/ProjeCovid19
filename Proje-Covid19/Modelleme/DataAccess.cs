using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Covid19
{
    class DataAccess
    {
        static string conString = "Server = DESKTOP-L4DKVAR; Database = smscov; Trusted_Connection = True;";
        SqlConnection con = new SqlConnection(conString);

        public int executenonquery(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            int x = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return x;
        }

        public DataTable Executequery(string query)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            con.Close();
            return dt;
        }

        public string reader(string query, string aranan)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader read = cmd.ExecuteReader();
            string astext = "";
            while (read.Read()) { astext = read[aranan].ToString(); }
            con.Close();
            return astext;
        }

        public ArrayList ExecuteReader(string command, ArrayList columnsNames)
        {
            ArrayList list = new ArrayList();
            con.ConnectionString = conString;
            con.Open();
            SqlCommand comm = new SqlCommand();
            comm.CommandText = command;
            comm.Connection = con;
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                ArrayList result = new ArrayList();

                for (int i = 0; i < columnsNames.Count; i++)
                {

                    result.Add(reader[(string)columnsNames[i]].ToString());
                }


                list.Add(result);
            }

            reader.Close();
            con.Close();
            return list;
        }
    }
}