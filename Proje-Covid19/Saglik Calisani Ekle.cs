using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proje_Covid19
{
    public partial class Saglik_Calisani_Ekle : Form
    {
        string ad, soyad, tc, cinsiyet,email,sifre; int yoneticiID, departmanID, hastaneID, id; DateTime goreveBaslamaTarihi;

        private void button2_Click(object sender, EventArgs e) //GUNCELLEME ISLEMİ
        {
            ad = tbad.Text.Trim();
            soyad = tbsoyad.Text.Trim();
            tc = tbTC.Text.Trim();
            cinsiyet = comboBox_cinsiyet.SelectedItem.ToString();
            goreveBaslamaTarihi = date_gorev.Value;
            email = tbEmail.Text.Trim();
            sifre = tbSifre.Text.Trim();
            hastaneID = int.Parse(textBox1.Text.Trim());
            departmanID = int.Parse(tbDepID.Text.Trim());
            yoneticiID = int.Parse(tbYoneticiID.Text.Trim());
            id = int.Parse(tbID.Text.Trim());
            SaglikCalisani s = new SaglikCalisani(ad, soyad, tc, email, sifre, cinsiyet, goreveBaslamaTarihi, hastaneID, departmanID, yoneticiID);
            s.saglikCalisaniID = id;
            int RESULT = s.PersonelGüncelle();
            if(RESULT > 0)
            {
                label_Message.Text = "Güncelleme başarılı."; label_Message.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("İşleminizi gerçekleştirirken bir hata oluştu. Lütfen tekrar deneyiniz", "Hata");
            }
        }

        private void button1_Click(object sender, EventArgs e) //SILME ISLEMI
        {
            id = int.Parse(tbID.Text.Trim());
            SaglikCalisani s = new SaglikCalisani();
            s.saglikCalisaniID = id;

            int x = s.PersonelSil();
            if (x > 0)
            {
                MessageBox.Show("İşleminiz başarılı", "Başarılı");
            }
            else
            {
                MessageBox.Show("Hata oluştu", "Hata");
            }
        }

        
        public Saglik_Calisani_Ekle()
        {
            InitializeComponent();
        }

        private void button_Geri_Don_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ekleme_Click(object sender, EventArgs e)
        {
            try
            {
                ad = tbad.Text.Trim();
                soyad = tbsoyad.Text.Trim();
                tc = tbTC.Text.Trim();
                cinsiyet = comboBox_cinsiyet.SelectedItem.ToString();
                goreveBaslamaTarihi = date_gorev.Value;
                email = tbEmail.Text.Trim();
                sifre = tbSifre.Text.Trim();
                hastaneID = int.Parse(textBox1.Text.Trim());
                departmanID = int.Parse(tbDepID.Text.Trim());
                yoneticiID = int.Parse(tbYoneticiID.Text.Trim());

                SaglikCalisani s = new SaglikCalisani(ad, soyad, tc, email, sifre, cinsiyet, goreveBaslamaTarihi, hastaneID, departmanID, yoneticiID);
                int x = s.PersonelEkle();
                if (x > 0)
                {
                    label_Mesaj.Text = "Kayıt başarıyla gerçekleşti."; label_Mesaj.ForeColor = Color.Green;
                    //MessageBox.Show("İşleminiz başarılı gerçekleştirilmiştir.", "Başarılı");
                }
            }
            catch (Exception ex)
            {
                label_Mesaj.Text = ex.Message;
                label_Mesaj.ForeColor = Color.Red;
                //MessageBox.Show("Hata oluştu", "Hata");
            }
        }
    }
}
