namespace unite_4._6_uygulama1
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
            this.textBox_adsoyad = new System.Windows.Forms.TextBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.button_aranan = new System.Windows.Forms.Button();
            this.textBox_aranan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_isimler = new System.Windows.Forms.ListBox();
            this.button_listele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_adsoyad
            // 
            this.textBox_adsoyad.Location = new System.Drawing.Point(119, 30);
            this.textBox_adsoyad.Name = "textBox_adsoyad";
            this.textBox_adsoyad.Size = new System.Drawing.Size(252, 20);
            this.textBox_adsoyad.TabIndex = 0;
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(128, 66);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(157, 25);
            this.button_ekle.TabIndex = 1;
            this.button_ekle.Text = "Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // button_aranan
            // 
            this.button_aranan.Location = new System.Drawing.Point(128, 195);
            this.button_aranan.Name = "button_aranan";
            this.button_aranan.Size = new System.Drawing.Size(97, 22);
            this.button_aranan.TabIndex = 2;
            this.button_aranan.Text = "Arananı Göster";
            this.button_aranan.UseVisualStyleBackColor = true;
            this.button_aranan.Click += new System.EventHandler(this.button_aranan_Click);
            // 
            // textBox_aranan
            // 
            this.textBox_aranan.Location = new System.Drawing.Point(119, 144);
            this.textBox_aranan.Name = "textBox_aranan";
            this.textBox_aranan.Size = new System.Drawing.Size(252, 20);
            this.textBox_aranan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "İndex Değeri Gir";
            // 
            // listBox_isimler
            // 
            this.listBox_isimler.FormattingEnabled = true;
            this.listBox_isimler.Location = new System.Drawing.Point(453, 37);
            this.listBox_isimler.Name = "listBox_isimler";
            this.listBox_isimler.Size = new System.Drawing.Size(282, 134);
            this.listBox_isimler.TabIndex = 6;
            // 
            // button_listele
            // 
            this.button_listele.Location = new System.Drawing.Point(557, 194);
            this.button_listele.Name = "button_listele";
            this.button_listele.Size = new System.Drawing.Size(75, 23);
            this.button_listele.TabIndex = 7;
            this.button_listele.Text = "Listele";
            this.button_listele.UseVisualStyleBackColor = true;
            this.button_listele.Click += new System.EventHandler(this.button_listele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_listele);
            this.Controls.Add(this.listBox_isimler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_aranan);
            this.Controls.Add(this.button_aranan);
            this.Controls.Add(this.button_ekle);
            this.Controls.Add(this.textBox_adsoyad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_adsoyad;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button button_aranan;
        private System.Windows.Forms.TextBox textBox_aranan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_isimler;
        private System.Windows.Forms.Button button_listele;
    }
}

