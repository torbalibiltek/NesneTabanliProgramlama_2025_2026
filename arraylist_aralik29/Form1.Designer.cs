namespace arraylist_aralik29
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
            this.textBox_sehir_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ekle = new System.Windows.Forms.Button();
            this.listBox_sehirler = new System.Windows.Forms.ListBox();
            this.button_listele = new System.Windows.Forms.Button();
            this.button_index_goster = new System.Windows.Forms.Button();
            this.textBox_index_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_araya_ekle = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_ara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_sehir_adi
            // 
            this.textBox_sehir_adi.Location = new System.Drawing.Point(91, 47);
            this.textBox_sehir_adi.Name = "textBox_sehir_adi";
            this.textBox_sehir_adi.Size = new System.Drawing.Size(148, 20);
            this.textBox_sehir_adi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şehir Adı";
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(286, 47);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(108, 19);
            this.button_ekle.TabIndex = 2;
            this.button_ekle.Text = "Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // listBox_sehirler
            // 
            this.listBox_sehirler.FormattingEnabled = true;
            this.listBox_sehirler.Location = new System.Drawing.Point(433, 47);
            this.listBox_sehirler.Name = "listBox_sehirler";
            this.listBox_sehirler.Size = new System.Drawing.Size(144, 212);
            this.listBox_sehirler.TabIndex = 3;
            this.listBox_sehirler.SelectedIndexChanged += new System.EventHandler(this.listBox_sehirler_SelectedIndexChanged);
            // 
            // button_listele
            // 
            this.button_listele.Location = new System.Drawing.Point(624, 53);
            this.button_listele.Name = "button_listele";
            this.button_listele.Size = new System.Drawing.Size(75, 23);
            this.button_listele.TabIndex = 4;
            this.button_listele.Text = "Listele";
            this.button_listele.UseVisualStyleBackColor = true;
            this.button_listele.Click += new System.EventHandler(this.button_listele_Click);
            // 
            // button_index_goster
            // 
            this.button_index_goster.Location = new System.Drawing.Point(303, 72);
            this.button_index_goster.Name = "button_index_goster";
            this.button_index_goster.Size = new System.Drawing.Size(75, 23);
            this.button_index_goster.TabIndex = 5;
            this.button_index_goster.Text = "index Göster";
            this.button_index_goster.UseVisualStyleBackColor = true;
            this.button_index_goster.Click += new System.EventHandler(this.button_index_goster_Click);
            // 
            // textBox_index_no
            // 
            this.textBox_index_no.Location = new System.Drawing.Point(91, 75);
            this.textBox_index_no.Name = "textBox_index_no";
            this.textBox_index_no.Size = new System.Drawing.Size(156, 20);
            this.textBox_index_no.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "index no";
            // 
            // button_araya_ekle
            // 
            this.button_araya_ekle.Location = new System.Drawing.Point(16, 146);
            this.button_araya_ekle.Name = "button_araya_ekle";
            this.button_araya_ekle.Size = new System.Drawing.Size(75, 23);
            this.button_araya_ekle.TabIndex = 7;
            this.button_araya_ekle.Text = "Araya Ekle";
            this.button_araya_ekle.UseVisualStyleBackColor = true;
            this.button_araya_ekle.Click += new System.EventHandler(this.button_araya_ekle_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(97, 146);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(75, 23);
            this.button_guncelle.TabIndex = 7;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = true;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(178, 146);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(75, 23);
            this.button_sil.TabIndex = 7;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_ara
            // 
            this.button_ara.Location = new System.Drawing.Point(259, 146);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(75, 23);
            this.button_ara.TabIndex = 7;
            this.button_ara.Text = "Ara";
            this.button_ara.UseVisualStyleBackColor = true;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_guncelle);
            this.Controls.Add(this.button_araya_ekle);
            this.Controls.Add(this.textBox_index_no);
            this.Controls.Add(this.button_index_goster);
            this.Controls.Add(this.button_listele);
            this.Controls.Add(this.listBox_sehirler);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sehir_adi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_sehir_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.ListBox listBox_sehirler;
        private System.Windows.Forms.Button button_listele;
        private System.Windows.Forms.Button button_index_goster;
        private System.Windows.Forms.TextBox textBox_index_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_araya_ekle;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_ara;
    }
}

