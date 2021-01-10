//using Proje_Covid19.Modelleme;
using Proje_Covid19.Modelleme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proje_Covid19
{
    public partial class Bilgi_İslem_Ana_Sayfa : Form
    {
        public Person Person { get; set; }
        public Bilgi_İslem_Ana_Sayfa(Person p)
        {
            InitializeComponent();
            Person = p;
        }

        private void label4_Click(object sender, EventArgs e){ } //Hatalı çift tıklamadan dolayı oluşmuş bir void fonksiyondur.

        private void button_cikis_Click(object sender, EventArgs e)
        {
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                var result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Sistem Mesajı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide(); Giris_Ekrani form = new Giris_Ekrani(); form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Bilgi_İslem_Ana_Sayfa_Load(object sender, EventArgs e)
        {
            try
            {
                if (Person != null)
                {
                    labelHosgeldiniz.Text = Person.Ad + " " + Person.Soyad + " " + "//" + Person.TC;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackGroundIslemleri(string name)
        {
            try
            {
                foreach(var control in panelSecim.Controls)
                {
                    if(control is Button)
                    {
                        var btn = (Button)control;
                        if(btn.Name == name)
                        {
                            btn.BackColor = Color.LightCoral;
                        }
                        else
                        {
                            btn.BackColor = Color.Firebrick;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button_profil_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Profil Bilgileri";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                yonetici yo = new yonetici();
                dgvData.DataSource = yo.Goster(Person.Email);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_personelEkle_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Personel Güncelleme";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Saglik_Calisani_Ekle form = new Saglik_Calisani_Ekle();
            form.ShowDialog();
        }

        private void button_personelSil_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Personel Güncelleme";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Saglik_Calisani_Ekle form = new Saglik_Calisani_Ekle();
            form.ShowDialog();
        }

        private void button_personelleriListele_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Personel Listesi";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                SaglikCalisani s = new SaglikCalisani();
                dgvData.DataSource = s.Goster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_hastaneEkle_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Hastane Ekleme Ekranı";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Hastane_Ekleme form = new Hastane_Ekleme();
            form.ShowDialog();
        }

        private void button_hastaneSil_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Hastane Silme Ekranı";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Hastane_Ekleme form = new Hastane_Ekleme();
            form.ShowDialog();
        }

        private void button_hastaneleriListele_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Hastaneleri Listele";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                Hastane h = new Hastane();
                dgvData.DataSource = h.Goster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_depEkle_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Departman Ekleme";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Departman_Ekle form = new Departman_Ekle();
            form.ShowDialog();
        }

        private void button_depSil_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Departman Silme";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Departman_Ekle form = new Departman_Ekle();
            form.ShowDialog();
        }

        private void button_depList_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Departmanları Listele";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                Departman d = new Departman();
                dgvData.DataSource = d.Goster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_HGuncelle_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Hastane Güncelleme";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Hastane_Ekleme form = new Hastane_Ekleme();
            form.ShowDialog();
        }

        private void button_DGuncelle_Click(object sender, EventArgs e)
        {
            lblBaslik.Text = "Departman Güncelleme";
            try
            {
                BackGroundIslemleri(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Departman_Ekle form = new Departman_Ekle();
            form.ShowDialog();
        }
    }
}

