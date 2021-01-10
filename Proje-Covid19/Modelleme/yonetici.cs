using Proje_Covid19.Modelleme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Proje_Covid19
{
    class yonetici:Person
    {
        int yoneticiID;

        public yonetici(int yoneticiID, string ad, string soyad, string tc, string email, string sifre, string cinsiyet)
        {
            this.yoneticiID = yoneticiID;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Email = email;
            this.Sifre = sifre;
            this.Cinsiyet = cinsiyet;
            this.TC = tc;
        }

        public yonetici() { }

        public override Person Login(string email, string sifre)
        {
            SqlConnection connection = null;
            try
            {
                string conString = "Server = DESKTOP-L4DKVAR; Database = smscov; Trusted_Connection = True;";
                connection = new SqlConnection(conString);
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string query = $"select * from yonetici where email = '{email}' AND sifre = '{sifre}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        yonetici y = new yonetici();
                        y.yoneticiID = int.Parse(dt.Rows[0]["yoneticiID"].ToString());
                        y.Ad = dt.Rows[0]["ad"].ToString();
                        y.Soyad = dt.Rows[0]["soyad"].ToString();
                        y.Email = dt.Rows[0]["email"].ToString();
                        y.Sifre = dt.Rows[0]["sifre"].ToString();
                        y.Cinsiyet = dt.Rows[0]["cinsiyet"].ToString();
                        y.TC = dt.Rows[0]["tc"].ToString();
                        return y;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Giriş başarısız!");
            }
        }

        public DataTable Goster(string email)
        {
            try
            {
                string query = $"select * from yonetici where email = '{email}'";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
