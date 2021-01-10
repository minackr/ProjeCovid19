using Proje_Covid19.Modelleme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proje_Covid19
{
    public partial class Departman_Ekle : Form
    {
        string ad; int hastaneID; int yoneticiID; int id;
        public Departman_Ekle()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server = DESKTOP-L4DKVAR; Database = smscov; Trusted_Connection = True;");
        SqlDataAdapter adaptor;
        DataTable tablo;
        private void label3_Click(object sender, EventArgs e){} //Yanlislikla 2 kez tiklama sonucu olusmus bir fonksiyon

        private void Departman_Ekle_Load(object sender, EventArgs e) { } //Yanlislikla 2 kez tiklama sonucu olusmus bir fonksiyon

        private void button_EKLEME_Click(object sender, EventArgs e)
        {
            try
            {
                label_Message.Text = "";
                //connection.Open();
                ad = textBox_ad.Text.Trim();
                hastaneID = int.Parse(textBox_HastaneID.Text.Trim());
                yoneticiID = int.Parse(textBox_YoneticiID.Text.Trim());
                
                if (string.IsNullOrWhiteSpace(ad))
                {
                    textBox_ad.Focus(); throw new Exception("Departman adı boş bırakılamaz.");
                }
                Departman obj = new Departman(ad, hastaneID, yoneticiID);
               
                int result = obj.DepartmanEkle();
                if (result > 0)
                {
                    label_Message.Text = "Kayıt başarıyla gerçekleşti."; label_Message.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                label_Message.Text = ex.Message;
                label_Message.ForeColor = Color.Red;
            }
            //connection.Close();
        }

        private void button_SILME_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bu DEPARTMAN ı sistemden silmek istediğinizden emin misiniz ?",
             "DEPARTMAN Sil", MessageBoxButtons.YesNo);
            Departman h = new Departman();
            h.departmanID = id;

            label_Message.Text = "";
            //connection.Open();
            id = int.Parse(textBox_depID.Text.Trim());
            int x = h.DepartmanSil();
            if (x > 0)
            {
                MessageBox.Show("DEPARTMAN, sistemimizden başarıyla kaldırılmıştır.", "Başarılı");
            }
            else
            {
                MessageBox.Show("İşleminizi gerçekleştirirken bir hata oluştu. Lütfen tekrar deneyiniz", "Hata");
            }
        }

        private void button1_Click(object sender, EventArgs e) //guncelleme icin
        {
            label_Message.Text = "";
            ad = textBox_ad.Text.Trim();
            yoneticiID = int.Parse(textBox_YoneticiID.Text.Trim());
            hastaneID = int.Parse(textBox_HastaneID.Text.Trim());
            id = int.Parse(textBox_depID.Text.Trim());

            Departman obj = new Departman(ad, hastaneID, yoneticiID);
            obj.departmanID = id;
            int A = obj.DepartmanGüncelle();
            if (A > 0)
            {
                label_Message.Text = "Güncelleme başarılı."; label_Message.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("İşleminizi gerçekleştirirken bir hata oluştu. Lütfen tekrar deneyiniz", "Hata");
            }
        }

        private void _GERIDON_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
