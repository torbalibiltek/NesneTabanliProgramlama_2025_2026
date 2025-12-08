namespace OgrenciNotSistemi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ogrenciOlustur = new System.Windows.Forms.Button();
            this.textBox_ogrenciNumarasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ogrenciSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ogrenciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_ogrenciListesi = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.textBox_devamsizlik = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ders5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ders4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ders3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ders2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ders1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Sonucgoster = new System.Windows.Forms.Button();
            this.label_gecmeSonucu = new System.Windows.Forms.Label();
            this.label_belgeSonucu = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_ortalamaSonucu = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ogrenciOlustur);
            this.groupBox1.Controls.Add(this.textBox_ogrenciNumarasi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_ogrenciSoyadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_ogrenciAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgi Giriş Alanı";
            // 
            // button_ogrenciOlustur
            // 
            this.button_ogrenciOlustur.Location = new System.Drawing.Point(21, 362);
            this.button_ogrenciOlustur.Name = "button_ogrenciOlustur";
            this.button_ogrenciOlustur.Size = new System.Drawing.Size(235, 23);
            this.button_ogrenciOlustur.TabIndex = 2;
            this.button_ogrenciOlustur.Text = "Öğrenci Oluştur";
            this.button_ogrenciOlustur.UseVisualStyleBackColor = true;
            this.button_ogrenciOlustur.Click += new System.EventHandler(this.button_ogrenciOlustur_Click);
            // 
            // textBox_ogrenciNumarasi
            // 
            this.textBox_ogrenciNumarasi.Location = new System.Drawing.Point(21, 281);
            this.textBox_ogrenciNumarasi.Name = "textBox_ogrenciNumarasi";
            this.textBox_ogrenciNumarasi.Size = new System.Drawing.Size(235, 22);
            this.textBox_ogrenciNumarasi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numarası";
            // 
            // textBox_ogrenciSoyadi
            // 
            this.textBox_ogrenciSoyadi.Location = new System.Drawing.Point(21, 184);
            this.textBox_ogrenciSoyadi.Name = "textBox_ogrenciSoyadi";
            this.textBox_ogrenciSoyadi.Size = new System.Drawing.Size(235, 22);
            this.textBox_ogrenciSoyadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı";
            // 
            // textBox_ogrenciAdi
            // 
            this.textBox_ogrenciAdi.Location = new System.Drawing.Point(21, 88);
            this.textBox_ogrenciAdi.Name = "textBox_ogrenciAdi";
            this.textBox_ogrenciAdi.Size = new System.Drawing.Size(235, 22);
            this.textBox_ogrenciAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(263, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 8);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // listBox_ogrenciListesi
            // 
            this.listBox_ogrenciListesi.FormattingEnabled = true;
            this.listBox_ogrenciListesi.ItemHeight = 16;
            this.listBox_ogrenciListesi.Location = new System.Drawing.Point(369, 34);
            this.listBox_ogrenciListesi.Name = "listBox_ogrenciListesi";
            this.listBox_ogrenciListesi.Size = new System.Drawing.Size(335, 404);
            this.listBox_ogrenciListesi.TabIndex = 2;
            this.listBox_ogrenciListesi.SelectedIndexChanged += new System.EventHandler(this.listBox_ogrenciListesi_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Guncelle);
            this.groupBox3.Controls.Add(this.textBox_devamsizlik);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox_ders5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_ders4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_ders3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox_ders2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_ders1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(749, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 403);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Bilgi Alanı";
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.Location = new System.Drawing.Point(303, 136);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(105, 146);
            this.button_Guncelle.TabIndex = 4;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.UseVisualStyleBackColor = true;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // textBox_devamsizlik
            // 
            this.textBox_devamsizlik.Location = new System.Drawing.Point(24, 375);
            this.textBox_devamsizlik.Name = "textBox_devamsizlik";
            this.textBox_devamsizlik.Size = new System.Drawing.Size(235, 22);
            this.textBox_devamsizlik.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Devamsızlık";
            // 
            // textBox_ders5
            // 
            this.textBox_ders5.Location = new System.Drawing.Point(24, 301);
            this.textBox_ders5.Name = "textBox_ders5";
            this.textBox_ders5.Size = new System.Drawing.Size(235, 22);
            this.textBox_ders5.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ders5";
            // 
            // textBox_ders4
            // 
            this.textBox_ders4.Location = new System.Drawing.Point(24, 231);
            this.textBox_ders4.Name = "textBox_ders4";
            this.textBox_ders4.Size = new System.Drawing.Size(235, 22);
            this.textBox_ders4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ders4";
            // 
            // textBox_ders3
            // 
            this.textBox_ders3.Location = new System.Drawing.Point(24, 168);
            this.textBox_ders3.Name = "textBox_ders3";
            this.textBox_ders3.Size = new System.Drawing.Size(235, 22);
            this.textBox_ders3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ders3";
            // 
            // textBox_ders2
            // 
            this.textBox_ders2.Location = new System.Drawing.Point(24, 97);
            this.textBox_ders2.Name = "textBox_ders2";
            this.textBox_ders2.Size = new System.Drawing.Size(235, 22);
            this.textBox_ders2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ders2";
            // 
            // textBox_ders1
            // 
            this.textBox_ders1.Location = new System.Drawing.Point(24, 44);
            this.textBox_ders1.Name = "textBox_ders1";
            this.textBox_ders1.Size = new System.Drawing.Size(235, 22);
            this.textBox_ders1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ders1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_Sonucgoster);
            this.groupBox4.Controls.Add(this.label_gecmeSonucu);
            this.groupBox4.Controls.Add(this.label_belgeSonucu);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label_ortalamaSonucu);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(39, 478);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1151, 136);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sonuç Göster";
            // 
            // button_Sonucgoster
            // 
            this.button_Sonucgoster.Location = new System.Drawing.Point(27, 46);
            this.button_Sonucgoster.Name = "button_Sonucgoster";
            this.button_Sonucgoster.Size = new System.Drawing.Size(278, 42);
            this.button_Sonucgoster.TabIndex = 1;
            this.button_Sonucgoster.Text = "Sonuçları Göster";
            this.button_Sonucgoster.UseVisualStyleBackColor = true;
            this.button_Sonucgoster.Click += new System.EventHandler(this.button_Sonucgoster_Click);
            // 
            // label_gecmeSonucu
            // 
            this.label_gecmeSonucu.AutoSize = true;
            this.label_gecmeSonucu.Location = new System.Drawing.Point(902, 97);
            this.label_gecmeSonucu.Name = "label_gecmeSonucu";
            this.label_gecmeSonucu.Size = new System.Drawing.Size(99, 16);
            this.label_gecmeSonucu.TabIndex = 0;
            this.label_gecmeSonucu.Text = "Geçme Sonucu";
            // 
            // label_belgeSonucu
            // 
            this.label_belgeSonucu.AutoSize = true;
            this.label_belgeSonucu.Location = new System.Drawing.Point(902, 59);
            this.label_belgeSonucu.Name = "label_belgeSonucu";
            this.label_belgeSonucu.Size = new System.Drawing.Size(91, 16);
            this.label_belgeSonucu.TabIndex = 0;
            this.label_belgeSonucu.Text = "Belge Sonucu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(721, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Geçme Durumu";
            // 
            // label_ortalamaSonucu
            // 
            this.label_ortalamaSonucu.AutoSize = true;
            this.label_ortalamaSonucu.Location = new System.Drawing.Point(902, 18);
            this.label_ortalamaSonucu.Name = "label_ortalamaSonucu";
            this.label_ortalamaSonucu.Size = new System.Drawing.Size(114, 16);
            this.label_ortalamaSonucu.TabIndex = 0;
            this.label_ortalamaSonucu.Text = "Ortalama_Sonucu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(721, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Belge Durumu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(721, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ortalama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 635);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBox_ogrenciListesi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ogrenciOlustur;
        private System.Windows.Forms.TextBox textBox_ogrenciNumarasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ogrenciSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ogrenciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_ogrenciListesi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.TextBox textBox_devamsizlik;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ders5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ders4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ders3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ders2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ders1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_Sonucgoster;
        private System.Windows.Forms.Label label_ortalamaSonucu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_gecmeSonucu;
        private System.Windows.Forms.Label label_belgeSonucu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
    }
}

