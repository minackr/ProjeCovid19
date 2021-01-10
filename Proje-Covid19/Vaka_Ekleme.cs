using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proje_Covid19
{
    public partial class Vaka_Ekleme : Form
    {
        string ad, soyad, tc, cinsiyet, email, sifre, VakaRiskDurumu,TestIzni;

        private void button_GERI_DON_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int saglikCalisaniID, hastaneID, id; DateTime dogumTarihi, kayitTarihi;

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            ad = textBox_ad.Text.Trim();
            soyad = textBox_soyad.Text.Trim();
            email = textBox_email.Text.Trim();
            sifre = textBox_sifre.Text.Trim();
            cinsiyet = comboBox_cinsiyet.SelectedItem.ToString();
            tc = textBox_tc.Text.Trim();
            dogumTarihi = dateTimePicker_DogumTarihi.Value;
            kayitTarihi = dateTimePicker_kayıtTarihi.Value;
            VakaRiskDurumu = comboBox_VakaRiskDurumu.SelectedItem.ToString();
            TestIzni = comboBox_TestIzni.SelectedItem.ToString();
            hastaneID = int.Parse(textBox_HastaneID.Text.Trim());
            saglikCalisaniID = int.Parse(textBox_Saglikci.Text.Trim());
            id = int.Parse(textBox_ID.Text.Trim());
            Vaka v = new Vaka(ad, soyad, tc, email, sifre, cinsiyet, dogumTarihi, kayitTarihi, VakaRiskDurumu, TestIzni, hastaneID, saglikCalisaniID);
            v.vakaID = id;
            int RESULT = v.VakaGuncelle();
            if (RESULT > 0)
            {
                label_Mesaj.Text = "Güncelleme başarılı."; label_Mesaj.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("İşleminizi gerçekleştirirken bir hata oluştu. Lütfen tekrar deneyiniz", "Hata");
            }
            
        }

        private void button_SIL_Click(object sender, EventArgs e)
        {
            id = int.Parse(textBox_ID.Text.Trim());
            Vaka v = new Vaka();
            v.vakaID = id;
            int a = v.VakaSil();
            if (a > 0)
            {
                MessageBox.Show("İşleminiz başarılı", "Başarılı");
            }
            else
            {
                MessageBox.Show("Hata oluştu", "Hata");
            }
            
        }

        
        public Vaka_Ekleme()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e){}// YANLISLIKLA CIFT TIKLAMA SONUCU OLUSMUS BİR FONKSİYONDUR.

        private void button_Ekleme_Click(object sender, EventArgs e)
        {

            try
            {
                ad = textBox_ad.Text.Trim();
                soyad = textBox_soyad.Text.Trim();
                email = textBox_email.Text.Trim();
                sifre = textBox_sifre.Text.Trim();
                cinsiyet = comboBox_cinsiyet.SelectedItem.ToString();
                tc = textBox_tc.Text.Trim();
                dogumTarihi = dateTimePicker_DogumTarihi.Value;
                kayitTarihi = dateTimePicker_kayıtTarihi.Value;
                VakaRiskDurumu = comboBox_VakaRiskDurumu.SelectedItem.ToString();
                TestIzni = comboBox_TestIzni.SelectedItem.ToString();
                hastaneID = int.Parse(textBox_HastaneID.Text.Trim());
                saglikCalisaniID = int.Parse(textBox_Saglikci.Text.Trim());

                Vaka v = new Vaka(ad, soyad, tc, email, sifre, cinsiyet, dogumTarihi, kayitTarihi, VakaRiskDurumu, TestIzni, hastaneID, saglikCalisaniID);
                int x = v.VakaEkle();
                if (x > 0)
                {
                    label_Mesaj.Text = "Kayıt başarıyla gerçekleşti."; label_Mesaj.ForeColor = Color.Green;
                    //MessageBox.Show("İşleminiz başarılı gerçekleştirilmiştir.", "Başarılı");
                }
            }
            catch(Exception ex)
            {
                label_Mesaj.Text = ex.Message;
                label_Mesaj.ForeColor = Color.Red;
                //MessageBox.Show("Hata oluştu", "Hata");
            }
            
        }
    }
}
