namespace FormUygulamasi_01
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
            this.textBox_OkulNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_AdSoyad = new System.Windows.Forms.TextBox();
            this.button_Ara = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.listBox_OgrencilerListesi = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_OkulNo
            // 
            this.textBox_OkulNo.Location = new System.Drawing.Point(197, 50);
            this.textBox_OkulNo.Name = "textBox_OkulNo";
            this.textBox_OkulNo.Size = new System.Drawing.Size(158, 20);
            this.textBox_OkulNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Okul No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // textBox_AdSoyad
            // 
            this.textBox_AdSoyad.Location = new System.Drawing.Point(197, 96);
            this.textBox_AdSoyad.Name = "textBox_AdSoyad";
            this.textBox_AdSoyad.Size = new System.Drawing.Size(158, 20);
            this.textBox_AdSoyad.TabIndex = 0;
            // 
            // button_Ara
            // 
            this.button_Ara.Location = new System.Drawing.Point(197, 159);
            this.button_Ara.Name = "button_Ara";
            this.button_Ara.Size = new System.Drawing.Size(75, 23);
            this.button_Ara.TabIndex = 2;
            this.button_Ara.Text = "Ara";
            this.button_Ara.UseVisualStyleBackColor = true;
            this.button_Ara.Click += new System.EventHandler(this.button_Ara_Click);
            // 
            // button_Ekle
            // 
            this.button_Ekle.Location = new System.Drawing.Point(197, 215);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(75, 23);
            this.button_Ekle.TabIndex = 2;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.Location = new System.Drawing.Point(197, 278);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.button_Guncelle.TabIndex = 2;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.UseVisualStyleBackColor = true;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.Location = new System.Drawing.Point(197, 342);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(75, 23);
            this.button_Sil.TabIndex = 2;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // listBox_OgrencilerListesi
            // 
            this.listBox_OgrencilerListesi.FormattingEnabled = true;
            this.listBox_OgrencilerListesi.Location = new System.Drawing.Point(376, 57);
            this.listBox_OgrencilerListesi.Name = "listBox_OgrencilerListesi";
            this.listBox_OgrencilerListesi.Size = new System.Drawing.Size(183, 329);
            this.listBox_OgrencilerListesi.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(586, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 329);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox_OgrencilerListesi);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.button_Guncelle);
            this.Controls.Add(this.button_Ekle);
            this.Controls.Add(this.button_Ara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_AdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_OkulNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_OkulNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_AdSoyad;
        private System.Windows.Forms.Button button_Ara;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.ListBox listBox_OgrencilerListesi;
        private System.Windows.Forms.ListBox listBox1;
    }
}

