namespace tabcontrol_ogrenci
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
            this.tabControl_ogrenciBilgileri = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_ogrenciOlustur = new System.Windows.Forms.Button();
            this.comboBox_bolum = new System.Windows.Forms.ComboBox();
            this.comboBox_sube = new System.Windows.Forms.ComboBox();
            this.comboBox_sinif = new System.Windows.Forms.ComboBox();
            this.textBox_adSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_dersleriKaydet = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_dersEkle = new System.Windows.Forms.Button();
            this.tabControl_ogrenciBilgileri.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_ogrenciBilgileri
            // 
            this.tabControl_ogrenciBilgileri.Controls.Add(this.tabPage1);
            this.tabControl_ogrenciBilgileri.Controls.Add(this.tabPage2);
            this.tabControl_ogrenciBilgileri.Controls.Add(this.tabPage3);
            this.tabControl_ogrenciBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_ogrenciBilgileri.Location = new System.Drawing.Point(0, 0);
            this.tabControl_ogrenciBilgileri.Name = "tabControl_ogrenciBilgileri";
            this.tabControl_ogrenciBilgileri.SelectedIndex = 0;
            this.tabControl_ogrenciBilgileri.Size = new System.Drawing.Size(800, 450);
            this.tabControl_ogrenciBilgileri.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_ogrenciOlustur);
            this.tabPage1.Controls.Add(this.comboBox_bolum);
            this.tabPage1.Controls.Add(this.comboBox_sube);
            this.tabPage1.Controls.Add(this.comboBox_sinif);
            this.tabPage1.Controls.Add(this.textBox_adSoyad);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenci Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_ogrenciOlustur
            // 
            this.button_ogrenciOlustur.Location = new System.Drawing.Point(188, 260);
            this.button_ogrenciOlustur.Name = "button_ogrenciOlustur";
            this.button_ogrenciOlustur.Size = new System.Drawing.Size(151, 23);
            this.button_ogrenciOlustur.TabIndex = 14;
            this.button_ogrenciOlustur.Text = "Öğrenci Oluştur";
            this.button_ogrenciOlustur.UseVisualStyleBackColor = true;
            this.button_ogrenciOlustur.Click += new System.EventHandler(this.button_ogrenciOlustur_Click);
            // 
            // comboBox_bolum
            // 
            this.comboBox_bolum.FormattingEnabled = true;
            this.comboBox_bolum.Items.AddRange(new object[] {
            "Bilişim Teknolojileri",
            "Elektrik Elektronik",
            "Makine",
            "Mobilya",
            "Metal"});
            this.comboBox_bolum.Location = new System.Drawing.Point(220, 173);
            this.comboBox_bolum.Name = "comboBox_bolum";
            this.comboBox_bolum.Size = new System.Drawing.Size(121, 21);
            this.comboBox_bolum.TabIndex = 11;
            // 
            // comboBox_sube
            // 
            this.comboBox_sube.FormattingEnabled = true;
            this.comboBox_sube.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBox_sube.Location = new System.Drawing.Point(220, 131);
            this.comboBox_sube.Name = "comboBox_sube";
            this.comboBox_sube.Size = new System.Drawing.Size(121, 21);
            this.comboBox_sube.TabIndex = 12;
            // 
            // comboBox_sinif
            // 
            this.comboBox_sinif.FormattingEnabled = true;
            this.comboBox_sinif.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_sinif.Location = new System.Drawing.Point(220, 93);
            this.comboBox_sinif.Name = "comboBox_sinif";
            this.comboBox_sinif.Size = new System.Drawing.Size(121, 21);
            this.comboBox_sinif.TabIndex = 13;
            // 
            // textBox_adSoyad
            // 
            this.textBox_adSoyad.Location = new System.Drawing.Point(220, 58);
            this.textBox_adSoyad.Name = "textBox_adSoyad";
            this.textBox_adSoyad.Size = new System.Drawing.Size(100, 20);
            this.textBox_adSoyad.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bölüm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şube";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sınıf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad Soyad";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_dersEkle);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button_dersleriKaydet);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox21);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ders Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_dersleriKaydet
            // 
            this.button_dersleriKaydet.Location = new System.Drawing.Point(129, 330);
            this.button_dersleriKaydet.Name = "button_dersleriKaydet";
            this.button_dersleriKaydet.Size = new System.Drawing.Size(169, 23);
            this.button_dersleriKaydet.TabIndex = 4;
            this.button_dersleriKaydet.Text = "Dersleri Kaydet";
            this.button_dersleriKaydet.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(129, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "label10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "label10";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(129, 288);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 20);
            this.textBox21.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sonuçlar";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(710, 238);
            this.listBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // button_dersEkle
            // 
            this.button_dersEkle.Location = new System.Drawing.Point(677, 162);
            this.button_dersEkle.Name = "button_dersEkle";
            this.button_dersEkle.Size = new System.Drawing.Size(75, 23);
            this.button_dersEkle.TabIndex = 6;
            this.button_dersEkle.Text = "Ders Ekle";
            this.button_dersEkle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_ogrenciBilgileri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl_ogrenciBilgileri.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_ogrenciBilgileri;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox_bolum;
        private System.Windows.Forms.ComboBox comboBox_sube;
        private System.Windows.Forms.ComboBox comboBox_sinif;
        private System.Windows.Forms.TextBox textBox_adSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ogrenciOlustur;
        private System.Windows.Forms.Button button_dersleriKaydet;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_dersEkle;
    }
}

