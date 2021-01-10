using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Proje_Covid19.Modelleme
{
    class Departman : Info
    {
        private int DepartmanID;
        private int HastaneID;

        public Departman(/*int departmanID*/ string ad, int hastaneID, int yoneticiID)
        {
            //this.DepartmanID = departmanID;
            this.Ad = ad;
            this.HastaneID = hastaneID;
            this.YoneticiID = yoneticiID;
        }
        public int departmanID { get => DepartmanID; set => DepartmanID = value; }
        public Departman() { }
        public string ad { get => Ad; set => Ad = value; }
        public int hastaneID { get => HastaneID; set => HastaneID = value; }
        public int yoneticiID { get => YoneticiID; set => YoneticiID = value; }


        DataAccess da = new DataAccess();

        public DataTable Goster()
        {
            try
            {
                string query = "select * from Departmant";
                return dbHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int DepartmanEkle()
        {
            string sqlCommand = "INSERT INTO [smscov].[dbo].[Departmant]([ad],[HastaneID],[yoneticiID]) VALUES('" + Ad + "','" + HastaneID + "','" + YoneticiID + "')";

            int x = da.executenonquery(sqlCommand);
            return x;
        }
        public int DepartmanSil()
        {
            string sqlCommand2 = "DELETE from [smscov].[dbo].[Departmant] WHERE DepartmanID= "+DepartmanID;
            int x = da.executenonquery(sqlCommand2);
            return x;
            
        }
        public int DepartmanGüncelle()
        {
            string command = "UPDATE [smscov].[dbo].[Departmant] SET ad ='" + Ad + "',HastaneID='" + HastaneID + "',yoneticiID ='" + YoneticiID + "' WHERE DepartmanID = " + DepartmanID;
            int x = da.executenonquery(command);
            return x;
            
        }
    }
}
