namespace Proje_Covid19
{
    partial class Saglik_Calisani_Ekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saglik_Calisani_Ekle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTC = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date_gorev = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDepID = new System.Windows.Forms.TextBox();
            this.button_Ekleme = new System.Windows.Forms.Button();
            this.button_Geri_Don = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbYoneticiID = new System.Windows.Forms.TextBox();
            this.label_Message = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Mesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(880, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sağlık Çalışanı Ekleme/Silme/Güncelleme Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(72, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADI:";
            // 
            // tbad
            // 
            this.tbad.Location = new System.Drawing.Point(144, 93);
            this.tbad.Name = "tbad";
            this.tbad.Size = new System.Drawing.Size(418, 27);
            this.tbad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(40, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "SOYADI:";
            // 
            // tbsoyad
            // 
            this.tbsoyad.Location = new System.Drawing.Point(144, 136);
            this.tbsoyad.Name = "tbsoyad";
            this.tbsoyad.Size = new System.Drawing.Size(418, 27);
            this.tbsoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(74, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "T.C.:";
            // 
            // tbTC
            // 
            this.tbTC.Location = new System.Drawing.Point(144, 181);
            this.tbTC.Name = "tbTC";
            this.tbTC.Size = new System.Drawing.Size(417, 27);
            this.tbTC.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(29, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "CİNSİYET:";
            // 
            // comboBox_cinsiyet
            // 
            this.comboBox_cinsiyet.AutoCompleteCustomSource.AddRange(new string[] {
            "ERKEK",
            "KADIN"});
            this.comboBox_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cinsiyet.FormattingEnabled = true;
            this.comboBox_cinsiyet.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.comboBox_cinsiyet.Location = new System.Drawing.Point(144, 218);
            this.comboBox_cinsiyet.Name = "comboBox_cinsiyet";
            this.comboBox_cinsiyet.Size = new System.Drawing.Size(418, 28);
            this.comboBox_cinsiyet.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(22, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 38);
            this.label6.TabIndex = 1;
            this.label6.Text = "GÖREVE B.\r\nTARİHİ     :";
            // 
            // date_gorev
            // 
            this.date_gorev.Location = new System.Drawing.Point(144, 274);
            this.date_gorev.Name = "date_gorev";
            this.date_gorev.Size = new System.Drawing.Size(418, 27);
            this.date_gorev.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(52, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "EMAİL:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(144, 324);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(418, 27);
            this.tbEmail.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(60, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "ŞİFRE:";
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(144, 366);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(418, 27);
            this.tbSifre.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(64, 700);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "ID     :\r\n";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(144, 696);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(418, 27);
            this.tbID.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(50, 455);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 38);
            this.label10.TabIndex = 1;
            this.label10.Text = "DEP. \r\nKODU     :\r\n";
            // 
            // tbDepID
            // 
            this.tbDepID.Location = new System.Drawing.Point(144, 466);
            this.tbDepID.Name = "tbDepID";
            this.tbDepID.Size = new System.Drawing.Size(418, 27);
            this.tbDepID.TabIndex = 2;
            // 
            // button_Ekleme
            // 
            this.button_Ekleme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Ekleme.BackColor = System.Drawing.Color.White;
            this.button_Ekleme.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Ekleme.ForeColor = System.Drawing.Color.Firebrick;
            this.button_Ekleme.Image = ((System.Drawing.Image)(resources.GetObject("button_Ekleme.Image")));
            this.button_Ekleme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Ekleme.Location = new System.Drawing.Point(632, 106);
            this.button_Ekleme.Name = "button_Ekleme";
            this.button_Ekleme.Size = new System.Drawing.Size(178, 86);
            this.button_Ekleme.TabIndex = 6;
            this.button_Ekleme.Text = "EKLE";
            this.button_Ekleme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Ekleme.UseVisualStyleBackColor = false;
            this.button_Ekleme.Click += new System.EventHandler(this.button_Ekleme_Click);
            // 
            // button_Geri_Don
            // 
            this.button_Geri_Don.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Geri_Don.BackColor = System.Drawing.Color.White;
            this.button_Geri_Don.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Geri_Don.ForeColor = System.Drawing.Color.Firebrick;
            this.button_Geri_Don.Image = ((System.Drawing.Image)(resources.GetObject("button_Geri_Don.Image")));
            this.button_Geri_Don.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Geri_Don.Location = new System.Drawing.Point(632, 436);
            this.button_Geri_Don.Name = "button_Geri_Don";
            this.button_Geri_Don.Size = new System.Drawing.Size(178, 86);
            this.button_Geri_Don.TabIndex = 6;
            this.button_Geri_Don.Text = "GERİ DÖN";
            this.button_Geri_Don.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Geri_Don.UseVisualStyleBackColor = false;
            this.button_Geri_Don.Click += new System.EventHandler(this.button_Geri_Don_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(40, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 38);
            this.label11.TabIndex = 1;
            this.label11.Text = "EKLEYEN\r\nKODU     :\r\n";
            // 
            // tbYoneticiID
            // 
            this.tbYoneticiID.Location = new System.Drawing.Point(144, 524);
            this.tbYoneticiID.Name = "tbYoneticiID";
            this.tbYoneticiID.Size = new System.Drawing.Size(413, 27);
            this.tbYoneticiID.TabIndex = 2;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Book Antiqua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_Message.ForeColor = System.Drawing.Color.Firebrick;
            this.label_Message.Location = new System.Drawing.Point(144, 59);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(0, 18);
            this.label_Message.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(162, 595);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(395, 66);
            this.label12.TabIndex = 9;
            this.label12.Text = "Aşağıdaki alanı sadece SİLME ve GÜNCELLEME\r\nişlemleri için kullanınız.\r\nSİLME içi" +
    "n sadece aşağıdaki alan yeterlidir.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 420);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 27);
            this.textBox1.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Firebrick;
            this.label13.Location = new System.Drawing.Point(50, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 38);
            this.label13.TabIndex = 1;
            this.label13.Text = "HAST. \r\nKODU     :\r\n";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(632, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 86);
            this.button1.TabIndex = 10;
            this.button1.Text = "SİL";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(632, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 86);
            this.button2.TabIndex = 11;
            this.button2.Text = "GÜNCELLE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_Mesaj
            // 
            this.label_Mesaj.AutoSize = true;
            this.label_Mesaj.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Mesaj.ForeColor = System.Drawing.Color.Firebrick;
            this.label_Mesaj.Location = new System.Drawing.Point(72, 58);
            this.label_Mesaj.Name = "label_Mesaj";
            this.label_Mesaj.Size = new System.Drawing.Size(0, 19);
            this.label_Mesaj.TabIndex = 1;
            // 
            // Saglik_Calisani_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 768);
            this.Controls.Add(this.label_Mesaj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.tbYoneticiID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_Geri_Don);
            this.Controls.Add(this.button_Ekleme);
            this.Controls.Add(this.tbDepID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date_gorev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_cinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Saglik_Calisani_Ekle";
            this.Text = "Sağlık Çalışanı Kayıt Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_cinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_gorev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDepID;
        private System.Windows.Forms.Button button_Ekleme;
        private System.Windows.Forms.Button button_Geri_Don;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbYoneticiID;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Mesaj;
    }
}