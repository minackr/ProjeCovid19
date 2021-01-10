using Proje_Covid19.Modelleme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Proje_Covid19
{
    class Vaka:Person
    {
        private int VakaID;
        private DateTime DogumTarihi;
        private DateTime KayitTarihi;
        private string VakaRiskDurumu;
        private string TestIzni;
        private int HastaneID;
        private int SaglikCalisaniID;

        public Vaka(/*int vakaID,*/ string ad, string soyad, string tc, string email, string sifre, string cinsiyet, DateTime dogumTarihi, DateTime kayitTarihi, string vakaRiskDurumu, string testIzni, int hastaneID,
            int saglikCalisaniID)
        {
            //this.VakaID = vakaID;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Email = email;
            this.Sifre = sifre;
            this.Cinsiyet = cinsiyet;
            this.TC = tc;
            this.DogumTarihi = dogumTarihi;
            this.KayitTarihi = kayitTarihi;
            this.VakaRiskDurumu = vakaRiskDurumu;
            this.TestIzni = testIzni;
            this.HastaneID = hastaneID;
            this.SaglikCalisaniID = saglikCalisaniID;
        }
        //SqlConnection connection = new SqlConnection("Server = DESKTOP-L4DKVAR; Database = smscov; Trusted_Connection = True;");
        public int vakaID { get => VakaID; set => VakaID = value; }
        public DateTime dogumTarihi { get => DogumTarihi; set => DogumTarihi = value; }
        public DateTime kayitTarihi { get => KayitTarihi; set => KayitTarihi = value; }
        public string vakaRiskDurumu { get => VakaRiskDurumu; set => VakaRiskDurumu = value; }
        public string testIzni { get => TestIzni; set => TestIzni = value; }
        public int hastaneID { get => HastaneID; set => HastaneID = value; }
        public int saglikCalisaniID { get => SaglikCalisaniID; set => SaglikCalisaniID = value; }
        
        DataAccess da = new DataAccess();
        public Vaka() { }
        public DataTable Goster()
        {
            try
            {
                string query = "select * from Vaka";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int VakaEkle()
        {
            string sqlCommand1 = "INSERT INTO [smscov].[dbo].[Vaka]([ad],[soyad],[email],[sifre],[cinsiyet],[tc],[dogumTarihi],[kayitTarihi],[VakaRiskDurumu],[TestIzni],[HastaneID],[saglikCalisaniID]) VALUES('" + Ad + "','" + Soyad + "','" + Email + "','" + Sifre + "','" + Cinsiyet + "','"+TC+"','" + dogumTarihi + "','"+kayitTarihi+"','"+VakaRiskDurumu+"','"+testIzni+"','" + HastaneID + "','" + SaglikCalisaniID + "')";

            int x = da.executenonquery(sqlCommand1);
            return x;
        }
        
        public int VakaSil()
        {
            string sqlCommand2 = "DELETE from [smscov].[dbo].[Vaka] WHERE VakaID= " + vakaID; 
            int x = da.executenonquery(sqlCommand2);
            return x;
        }

        public int VakaGuncelle()
        {
            string command = "UPDATE [smscov].[dbo].[Vaka] SET ad ='" + Ad + "', soyad='" + Soyad + "',email ='" + Email + "',sifre = '" + Sifre + "',cinsiyet='" + Cinsiyet + "',tc='" + TC + "',dogumTarihi ='" + dogumTarihi + "',kayitTarihi = '"+kayitTarihi+"',VakaRiskDurumu = '"+VakaRiskDurumu+"',testIzni = '"+testIzni+"',HastaneID = '" + HastaneID + "',saglikCalisaniID  = '" + SaglikCalisaniID + "' WHERE VakaID = " + vakaID;
            int x = da.executenonquery(command);
            return x;
        }

        
    }

}
