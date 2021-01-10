using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proje_Covid19
{
    public partial class Personel_Ana_Sayfa : Form
    {
        public Person Person { get; set; }
        public Personel_Ana_Sayfa(Person p)
        {
            InitializeComponent();
            Person = p;
        }

        private void Personel_Ana_Sayfa_Load(object sender, EventArgs e)
        {
            try
            {
                if (Person != null)
                {
                    //labelHosgeldiniz.Text = Person.Ad + " " + Person.Soyad + " " + "//" + Person.TC;
                    label_adSoyad.Text = Person.Ad + " " + Person.Soyad;
                    label_tc.Text = Person.TC;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) //Vakaları Listelemek İcin
        {
            try
            {
                Vaka d = new Vaka();
                dataGridView.DataSource = d.Goster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) //VAKA İSLEMLERİ SECENEGINE TIKLANMIS.
        {
            Vaka_Ekleme form = new Vaka_Ekleme();
            form.ShowDialog();
        }
    }
}
