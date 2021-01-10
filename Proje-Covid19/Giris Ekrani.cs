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
    public partial class Giris_Ekrani : Form
    {
        public Giris_Ekrani()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = tbEmail.Text; string sifre = tbSifre.Text;
            if (email.Trim() != "" || sifre.Trim() != "")
            {
                yonetici y = new yonetici();
                SaglikCalisani s = new SaglikCalisani();
                var yonetici = y.Login(email, sifre);
                var saglikCalisani = s.Login(email,sifre);
               
                if(yonetici != null)
                {
                    Bilgi_İslem_Ana_Sayfa form = new Bilgi_İslem_Ana_Sayfa(yonetici);
                    form.ShowDialog(); this.Hide();
                }
                if(saglikCalisani != null)
                {
                    Personel_Ana_Sayfa form = new Personel_Ana_Sayfa(saglikCalisani);
                    form.ShowDialog(); this.Hide();
                }
                else { label4.ForeColor = Color.White; label4.Text = "Giriş Başarısız! Bilgileriniz hatalıdır!!!"; }

            }
            else
            {
                label4.ForeColor = Color.White; label4.Text = "Giriş Başarısız! Lütfen email ve sifrenizi giriniz.";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            labelUyari.Text = tbSifre.Text = tbEmail.Text = "";
            tbEmail.Focus();
            checkBox1.Checked = false;
            return;
        }
    }
}
