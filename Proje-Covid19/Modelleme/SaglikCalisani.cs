using Proje_Covid19.Modelleme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Proje_Covid19
{
    class SaglikCalisani:Person
    {
        private int SaglikCalisaniID;
        private DateTime GoreveBasTarihi;
        private int DepartmanID;
        private int HastaneID;
        private int yoneticiID;

        public SaglikCalisani(/*int saglikCalisaniID, */string ad, string soyad, string tc, string email, string sifre, string cinsiyet, DateTime goreveBasTarihi, int hastaneID,
             int departmanID,int yoneticiID)
        {
            //this.SaglikCalisaniID = saglikCalisaniID;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Email = email;
            this.Sifre = sifre;
            this.Cinsiyet = cinsiyet;
            this.TC = tc;
            this.GoreveBasTarihi = goreveBasTarihi;
            this.HastaneID = hastaneID;
            this.DepartmanID = departmanID;
            this.yoneticiID = yoneticiID;
        }

        public int saglikCalisaniID { get => SaglikCalisaniID; set => SaglikCalisaniID = value; }
        public DateTime goreveBasTarihi { get => GoreveBasTarihi; set => GoreveBasTarihi = value; }
        public int departmanID { get => DepartmanID; set => DepartmanID = value; }
        public int hastaneID { get => HastaneID; set => HastaneID = value; }
        public int YoneticiID { get => yoneticiID; set => yoneticiID = value; }

        DataAccess da = new DataAccess();
        public SaglikCalisani() { }

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
                    string query = $"select * from [smscov].[dbo].[saglikCalisani] where email = '{email}' AND sifre = '{sifre}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        SaglikCalisani y = new SaglikCalisani();
                        y.saglikCalisaniID = int.Parse(dt.Rows[0]["saglikCalisaniID"].ToString());
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
        public DataTable Goster()
        {
            try 
            {
                string query = "select * from saglikCalisani";
                return dbHelper.ExecuteQuery(query);
             }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //SAGLIK CALISANI EKLEME
        public int PersonelEkle(/*SaglikCalisani s*/)
        {
            string sqlCommand1 = "INSERT INTO [smscov].[dbo].[saglikCalisani]([ad],[soyad],[tc],[email],[sifre],[cinsiyet],[goreveBasTarihi],[HastaneID],[DepartmanID],[yoneticiID]) VALUES('" + Ad + "','" + Soyad + "','" + TC + "','" + Email + "','" + Sifre + "','"+Cinsiyet+"','"+goreveBasTarihi+"','"+HastaneID+"','"+DepartmanID+"','"+YoneticiID+"')";

            int x = da.executenonquery(sqlCommand1);
            return x;
            
        }
        public int PersonelSil()
        {
            string sqlCommand2 = "DELETE from [smscov].[dbo].[saglikCalisani] WHERE saglikCalisaniID= " + saglikCalisaniID;
            int x = da.executenonquery(sqlCommand2);
            return x;
            
        }
        public int PersonelGüncelle()
        {
            string command = "UPDATE [smscov].[dbo].[saglikCalisani] SET ad ='" + Ad + "', soyad='" + Soyad + "',tc='" + TC + "',email ='"+Email+"',sifre = '"+Sifre+"',cinsiyet='" + Cinsiyet + "',goreveBasTarihi ='" + goreveBasTarihi + "',HastaneID = '"+HastaneID+"',DepartmanID='"+departmanID+"',yoneticiID  = '"+YoneticiID+"' WHERE HastaneID = " + saglikCalisaniID;
            int x = da.executenonquery(command);
            return x;
            
        }
       
    }

}
