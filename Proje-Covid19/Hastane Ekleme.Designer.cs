namespace Proje_Covid19
{
    partial class Hastane_Ekleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hastane_Ekleme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.comboBox_il = new System.Windows.Forms.ComboBox();
            this.comboBox_ilce = new System.Windows.Forms.ComboBox();
            this.textBox_yonetici = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Message = new System.Windows.Forms.Label();
            this.comboBox_statu = new System.Windows.Forms.ComboBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(47, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hastane Ekleme/Silme/Güncelleme Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(65, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(81, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "İL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(61, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "İLÇE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(18, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "HASTANE \rSTATÜ      :\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(26, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 38);
            this.label6.TabIndex = 1;
            this.label6.Text = "EKLEYEN\r\nKODU     :\r\n";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Location = new System.Drawing.Point(139, 86);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(418, 27);
            this.textBox_ad.TabIndex = 2;
            // 
            // comboBox_il
            // 
            this.comboBox_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_il.FormattingEnabled = true;
            this.comboBox_il.Location = new System.Drawing.Point(139, 126);
            this.comboBox_il.Name = "comboBox_il";
            this.comboBox_il.Size = new System.Drawing.Size(418, 28);
            this.comboBox_il.TabIndex = 4;
            this.comboBox_il.SelectedIndexChanged += new System.EventHandler(this.comboBox_il_SelectedIndexChanged);
            // 
            // comboBox_ilce
            // 
            this.comboBox_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ilce.FormattingEnabled = true;
            this.comboBox_ilce.Location = new System.Drawing.Point(139, 169);
            this.comboBox_ilce.Name = "comboBox_ilce";
            this.comboBox_ilce.Size = new System.Drawing.Size(418, 28);
            this.comboBox_ilce.TabIndex = 4;
            // 
            // textBox_yonetici
            // 
            this.textBox_yonetici.Location = new System.Drawing.Point(139, 291);
            this.textBox_yonetici.Name = "textBox_yonetici";
            this.textBox_yonetici.Size = new System.Drawing.Size(418, 27);
            this.textBox_yonetici.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(596, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 86);
            this.button1.TabIndex = 6;
            this.button1.Text = "EKLE";
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
            this.button2.Location = new System.Drawing.Point(596, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 86);
            this.button2.TabIndex = 6;
            this.button2.Text = "GERİ DÖN";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Message.Location = new System.Drawing.Point(143, 58);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(0, 19);
            this.label_Message.TabIndex = 7;
            // 
            // comboBox_statu
            // 
            this.comboBox_statu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_statu.FormattingEnabled = true;
            this.comboBox_statu.Items.AddRange(new object[] {
            "DEVLET - NORMAL",
            "DEVLET - PANDEMİ",
            "ÖZEL - NORMAL",
            "ÖZEL - PANDEMİ"});
            this.comboBox_statu.Location = new System.Drawing.Point(139, 231);
            this.comboBox_statu.Name = "comboBox_statu";
            this.comboBox_statu.Size = new System.Drawing.Size(418, 28);
            this.comboBox_statu.TabIndex = 8;
            this.comboBox_statu.SelectedIndexChanged += new System.EventHandler(this.comboBox_statu_SelectedIndexChanged);
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(139, 402);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(418, 27);
            this.textBox_ID.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(81, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(143, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(395, 66);
            this.label8.TabIndex = 9;
            this.label8.Text = "Aşağıdaki alanı sadece SİLME ve GÜNCELLEME\r\nişlemleri için kullanınız.\r\nSİLME içi" +
    "n sadece aşağıdaki alan yeterlidir.";
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Firebrick;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(596, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 86);
            this.button3.TabIndex = 10;
            this.button3.Text = "SİL";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Firebrick;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(596, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 86);
            this.button4.TabIndex = 11;
            this.button4.Text = "GÜNCELLE";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Hastane_Ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 447);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.comboBox_statu);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_yonetici);
            this.Controls.Add(this.comboBox_ilce);
            this.Controls.Add(this.comboBox_il);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Hastane_Ekleme";
            this.Text = "Hastane_Ekleme";
            this.Load += new System.EventHandler(this.Hastane_Ekleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.ComboBox comboBox_il;
        private System.Windows.Forms.ComboBox comboBox_ilce;
        private System.Windows.Forms.TextBox textBox_yonetici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.ComboBox comboBox_statu;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}