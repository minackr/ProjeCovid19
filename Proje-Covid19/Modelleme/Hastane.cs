using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Proje_Covid19.Modelleme
{
    public class Hastane:Info
    {
        int HastaneID;
        public string HastaneStatu;

        //DataAccess da = new DataAccess();
        public Hastane(/*int hastaneID*/ string ad, string il, string ilce, string hastaneStatu, int yoneticiID)
        {
            this.Ad = ad;
            this.Il = il;
            this.Ilce = ilce;
            //this.HastaneID = hastaneID;
            this.HastaneStatu = hastaneStatu;
            this.YoneticiID = yoneticiID;
        }
        SqlConnection connection = new SqlConnection("Server = DESKTOP-L4DKVAR; Database = smscov; Trusted_Connection = True;");
        public Hastane() { }
        public string ad { get => Ad; set => Ad = value; }
        public string il { get => Il; set => Il = value; }
        public string ilce { get => Ilce; set => Ilce = value; }
        public string hastaneStatu { get => HastaneStatu; set => HastaneStatu = value; }
        public int yoneticiID { get => YoneticiID; set => YoneticiID = value; }
        public int hastaneID { get => HastaneID; set => HastaneID = value; }

        DataAccess da = new DataAccess();

        public DataTable Goster()
        {
            try
            {
                string query = "select * from Hastane";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int HastaneEkle()
        {
            string sqlCommand1 = "INSERT INTO [smscov].[dbo].[Hastane]([HastaneAdi],[Il],[Ilce],[HastaneStatu],[yoneticiID]) VALUES('"+Ad+"','"+Il+"',',"+Ilce+"','"+HastaneStatu+"','"+YoneticiID+"')";

            int x = da.executenonquery(sqlCommand1);
            return x;
            /*try
            {
                //if (HastaneBulma(h.Ad,h.Il,h.Ilce))
                //{
                    //throw new Exception("Bu hastane, zaten kayıtlıdır!");
                //}
                string query = $"INSERT INTO [smscov].[dbo].[Hastane](HastaneAdi,Il,Ilce,HastaneStatu,yoneticiID) VALUES('{Ad},{Il},{Ilce},{HastaneStatu},{YoneticiID}')";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }*/
            
        }
        public int HastaneSil(/*int hID*/)
        {
            string sqlCommand2 = "DELETE from [smscov].[dbo].[Hastane] WHERE HastaneID= " +HastaneID;
            int x = da.executenonquery(sqlCommand2);
            return x;
            /*try
            {
                string query = $"DELETE Hastane WHERE HastaneID='{hID}'";
                return dbHelper.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }*/

        }
        public int HastaneGüncelle()
        {
            string command = "UPDATE [smscov].[dbo].[Hastane] SET HastaneAdi ='"+Ad+"', Il='"+Il+"',Ilce='"+Ilce+"',HastaneStatu='"+HastaneStatu+"',yoneticiID ='"+yoneticiID+"' WHERE HastaneID = "+HastaneID;
            int x = da.executenonquery(command);
            return x;

        }
        /*private static bool HastaneBulma(string ad,string il,string ilce)
        {
            
            try
            {
                string query = $"select * from Hastane WHERE ad='{ad}' AND il='{il}' AND ilce ='{ilce}'";
                return dbHelper.ExecuteQuery(query).Rows.Count >= 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/
    }
}
