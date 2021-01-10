using Proje_Covid19.Modelleme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proje_Covid19
{
    public partial class Hastane_Ekleme : Form
    {
        string ad, il, ilce, hastaneStatu; int yoneticiID,id;
        public Hastane_Ekleme()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server = DESKTOP-L4DKVAR; Database = smscov; Trusted_Connection = True;");
        SqlDataAdapter adaptor;
        DataTable tablo;
        private void button2_Click(object sender, EventArgs e)
        {
          this.Close();
        }
        private void button1_Click(object sender, EventArgs e) //Kayıt İçin
        {
            try
            {
                label_Message.Text = "";
                //connection.Open();
                ad = textBox_ad.Text.Trim();
                il = /*comboBox_il.SelectedItem.ToString();*/ comboBox_il.Text;
                ilce = /*comboBox_ilce.SelectedItem.ToString();*/ comboBox_ilce.Text;
                hastaneStatu = comboBox_statu.SelectedItem.ToString();
                yoneticiID = int.Parse(textBox_yonetici.Text.Trim());
                //id = int.Parse(textBox_ID.Text.Trim());
                if (string.IsNullOrWhiteSpace(ad))
                {
                    textBox_ad.Focus(); throw new Exception("Hastane adı boş bırakılamaz.");
                }
                Hastane obj = new Hastane(ad, il, ilce, hastaneStatu, yoneticiID);
                //obj.Ad = ad; obj.Il = il; obj.Ilce = ilce; obj.HastaneStatu = hastaneStatu; obj.YoneticiID = yoneticiID;
                int result = obj.HastaneEkle();
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

        private void button4_Click(object sender, EventArgs e) //GUNCELLEME
        {
            label_Message.Text = "";
            ad = textBox_ad.Text.Trim();
            il = /*comboBox_il.SelectedItem.ToString()*/comboBox_il.Text; ;
            ilce = /*comboBox_ilce.SelectedItem.ToString()*/ comboBox_ilce.Text;
            hastaneStatu = comboBox_statu.SelectedItem.ToString();
            yoneticiID = int.Parse(textBox_yonetici.Text.Trim());
            id = int.Parse(textBox_ID.Text.Trim());

            Hastane obj = new Hastane(ad, il, ilce, hastaneStatu, yoneticiID);
            obj.hastaneID = id;
            int A = obj.HastaneGüncelle();
            if (A > 0)
            {
                label_Message.Text = "Güncelleme başarılı."; label_Message.ForeColor = Color.Green;
            }
            else
            {
                MessageBox.Show("İşleminizi gerçekleştirirken bir hata oluştu. Lütfen tekrar deneyiniz", "Hata");
            }
        }

        private void button3_Click(object sender, EventArgs e) //SILME
        {
            DialogResult dialogResult = MessageBox.Show("Bu HASTANE yi sistemden silmek istediğinizden emin misiniz ?",
             "HASTANE Sil", MessageBoxButtons.YesNo);
            Hastane h = new Hastane();
            h.hastaneID = id;

            label_Message.Text = "";
            //connection.Open();
            id = int.Parse(textBox_ID.Text.Trim());
            int x = h.HastaneSil(/*id*/);
            if (x > 0)
            {
                MessageBox.Show("HASTANE, sistemimizden başarıyla kaldırılmıştır.", "Başarılı");
            }
            else
            {
                MessageBox.Show("İşleminizi gerçekleştirirken bir hata oluştu. Lütfen tekrar deneyiniz", "Hata");
            }  
        }

        private void Hastane_Ekleme_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from [smscov].[dbo].[iller] ORDER BY il_no ASC ", connection);
            DataTable tablo2 = new DataTable();
            adaptor.Fill(tablo2);
            comboBox_il.ValueMember = "il_no";
            comboBox_il.DisplayMember = "isim";
            comboBox_il.DataSource = tablo2;
            connection.Close();
        }

        private void comboBox_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox_ilce.Items.Clear();
            //connection.Open();
            if (comboBox_il.SelectedIndex != -1)
            {
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from [smscov].[dbo].[ilceler] where il_no = " +comboBox_il.SelectedValue , connection);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                comboBox_ilce.ValueMember = "ilce_no";
                comboBox_ilce.DisplayMember = "isim";
                comboBox_ilce.DataSource = tablo;
            }
            //connection.Close();
        }

        private void comboBox_statu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string statu = comboBox_statu.SelectedItem.ToString();
        }
    }
}
