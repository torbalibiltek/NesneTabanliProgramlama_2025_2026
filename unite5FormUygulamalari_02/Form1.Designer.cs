namespace unite5FormUygulamalari_02
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
            this.gb_islemci = new System.Windows.Forms.GroupBox();
            this.rbCpur3 = new System.Windows.Forms.RadioButton();
            this.rbCpuR5 = new System.Windows.Forms.RadioButton();
            this.rbCpuI3 = new System.Windows.Forms.RadioButton();
            this.rbCpuI5 = new System.Windows.Forms.RadioButton();
            this.rbCpuI7 = new System.Windows.Forms.RadioButton();
            this.gb_ram = new System.Windows.Forms.GroupBox();
            this.rbRam4 = new System.Windows.Forms.RadioButton();
            this.rbRam8 = new System.Windows.Forms.RadioButton();
            this.rbRam16 = new System.Windows.Forms.RadioButton();
            this.gb_hdd = new System.Windows.Forms.GroupBox();
            this.rbHdd320 = new System.Windows.Forms.RadioButton();
            this.rbHdd500 = new System.Windows.Forms.RadioButton();
            this.rbHdd1000 = new System.Windows.Forms.RadioButton();
            this.gb_ekdonanim = new System.Windows.Forms.GroupBox();
            this.cbWifi = new System.Windows.Forms.CheckBox();
            this.cbWebCam = new System.Windows.Forms.CheckBox();
            this.cbDvd = new System.Windows.Forms.CheckBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.gb_islemci.SuspendLayout();
            this.gb_ram.SuspendLayout();
            this.gb_hdd.SuspendLayout();
            this.gb_ekdonanim.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_islemci
            // 
            this.gb_islemci.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_islemci.Controls.Add(this.rbCpur3);
            this.gb_islemci.Controls.Add(this.rbCpuR5);
            this.gb_islemci.Controls.Add(this.rbCpuI3);
            this.gb_islemci.Controls.Add(this.rbCpuI5);
            this.gb_islemci.Controls.Add(this.rbCpuI7);
            this.gb_islemci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_islemci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_islemci.ForeColor = System.Drawing.Color.Red;
            this.gb_islemci.Location = new System.Drawing.Point(12, 36);
            this.gb_islemci.Name = "gb_islemci";
            this.gb_islemci.Size = new System.Drawing.Size(189, 197);
            this.gb_islemci.TabIndex = 0;
            this.gb_islemci.TabStop = false;
            this.gb_islemci.Text = "İşlemciler";
            // 
            // rbCpur3
            // 
            this.rbCpur3.AutoSize = true;
            this.rbCpur3.Location = new System.Drawing.Point(0, 166);
            this.rbCpur3.Name = "rbCpur3";
            this.rbCpur3.Size = new System.Drawing.Size(123, 21);
            this.rbCpur3.TabIndex = 2;
            this.rbCpur3.TabStop = true;
            this.rbCpur3.Text = "AMD Ryzen 3";
            this.rbCpur3.UseVisualStyleBackColor = true;
            // 
            // rbCpuR5
            // 
            this.rbCpuR5.AutoSize = true;
            this.rbCpuR5.Location = new System.Drawing.Point(0, 136);
            this.rbCpuR5.Name = "rbCpuR5";
            this.rbCpuR5.Size = new System.Drawing.Size(123, 21);
            this.rbCpuR5.TabIndex = 2;
            this.rbCpuR5.TabStop = true;
            this.rbCpuR5.Text = "AMD Ryzen 5";
            this.rbCpuR5.UseVisualStyleBackColor = true;
            // 
            // rbCpuI3
            // 
            this.rbCpuI3.AutoSize = true;
            this.rbCpuI3.Location = new System.Drawing.Point(0, 105);
            this.rbCpuI3.Name = "rbCpuI3";
            this.rbCpuI3.Size = new System.Drawing.Size(114, 21);
            this.rbCpuI3.TabIndex = 2;
            this.rbCpuI3.TabStop = true;
            this.rbCpuI3.Text = "Intel Core i3";
            this.rbCpuI3.UseVisualStyleBackColor = true;
            // 
            // rbCpuI5
            // 
            this.rbCpuI5.AutoSize = true;
            this.rbCpuI5.Location = new System.Drawing.Point(0, 69);
            this.rbCpuI5.Name = "rbCpuI5";
            this.rbCpuI5.Size = new System.Drawing.Size(114, 21);
            this.rbCpuI5.TabIndex = 1;
            this.rbCpuI5.TabStop = true;
            this.rbCpuI5.Text = "Intel Core i5";
            this.rbCpuI5.UseVisualStyleBackColor = true;
            // 
            // rbCpuI7
            // 
            this.rbCpuI7.AutoSize = true;
            this.rbCpuI7.Location = new System.Drawing.Point(6, 31);
            this.rbCpuI7.Name = "rbCpuI7";
            this.rbCpuI7.Size = new System.Drawing.Size(114, 21);
            this.rbCpuI7.TabIndex = 0;
            this.rbCpuI7.TabStop = true;
            this.rbCpuI7.Text = "Intel Core i7";
            this.rbCpuI7.UseVisualStyleBackColor = true;
            // 
            // gb_ram
            // 
            this.gb_ram.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_ram.Controls.Add(this.rbRam4);
            this.gb_ram.Controls.Add(this.rbRam8);
            this.gb_ram.Controls.Add(this.rbRam16);
            this.gb_ram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_ram.ForeColor = System.Drawing.Color.Blue;
            this.gb_ram.Location = new System.Drawing.Point(217, 36);
            this.gb_ram.Name = "gb_ram";
            this.gb_ram.Size = new System.Drawing.Size(209, 197);
            this.gb_ram.TabIndex = 1;
            this.gb_ram.TabStop = false;
            this.gb_ram.Text = "RAM Bellek";
            // 
            // rbRam4
            // 
            this.rbRam4.AutoSize = true;
            this.rbRam4.Location = new System.Drawing.Point(0, 105);
            this.rbRam4.Name = "rbRam4";
            this.rbRam4.Size = new System.Drawing.Size(62, 21);
            this.rbRam4.TabIndex = 0;
            this.rbRam4.TabStop = true;
            this.rbRam4.Text = "4 GB";
            this.rbRam4.UseVisualStyleBackColor = true;
            // 
            // rbRam8
            // 
            this.rbRam8.AutoSize = true;
            this.rbRam8.Location = new System.Drawing.Point(0, 69);
            this.rbRam8.Name = "rbRam8";
            this.rbRam8.Size = new System.Drawing.Size(62, 21);
            this.rbRam8.TabIndex = 0;
            this.rbRam8.TabStop = true;
            this.rbRam8.Text = "8 GB";
            this.rbRam8.UseVisualStyleBackColor = true;
            // 
            // rbRam16
            // 
            this.rbRam16.AutoSize = true;
            this.rbRam16.Location = new System.Drawing.Point(6, 31);
            this.rbRam16.Name = "rbRam16";
            this.rbRam16.Size = new System.Drawing.Size(71, 21);
            this.rbRam16.TabIndex = 0;
            this.rbRam16.TabStop = true;
            this.rbRam16.Text = "16 GB";
            this.rbRam16.UseVisualStyleBackColor = true;
            // 
            // gb_hdd
            // 
            this.gb_hdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_hdd.Controls.Add(this.rbHdd320);
            this.gb_hdd.Controls.Add(this.rbHdd500);
            this.gb_hdd.Controls.Add(this.rbHdd1000);
            this.gb_hdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_hdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_hdd.ForeColor = System.Drawing.Color.Black;
            this.gb_hdd.Location = new System.Drawing.Point(444, 36);
            this.gb_hdd.Name = "gb_hdd";
            this.gb_hdd.Size = new System.Drawing.Size(200, 197);
            this.gb_hdd.TabIndex = 2;
            this.gb_hdd.TabStop = false;
            this.gb_hdd.Text = "Sabit Disk";
            // 
            // rbHdd320
            // 
            this.rbHdd320.AutoSize = true;
            this.rbHdd320.Location = new System.Drawing.Point(6, 105);
            this.rbHdd320.Name = "rbHdd320";
            this.rbHdd320.Size = new System.Drawing.Size(80, 21);
            this.rbHdd320.TabIndex = 0;
            this.rbHdd320.TabStop = true;
            this.rbHdd320.Text = "320 GB";
            this.rbHdd320.UseVisualStyleBackColor = true;
            // 
            // rbHdd500
            // 
            this.rbHdd500.AutoSize = true;
            this.rbHdd500.Location = new System.Drawing.Point(6, 69);
            this.rbHdd500.Name = "rbHdd500";
            this.rbHdd500.Size = new System.Drawing.Size(80, 21);
            this.rbHdd500.TabIndex = 0;
            this.rbHdd500.TabStop = true;
            this.rbHdd500.Text = "500 GB";
            this.rbHdd500.UseVisualStyleBackColor = true;
            // 
            // rbHdd1000
            // 
            this.rbHdd1000.AutoSize = true;
            this.rbHdd1000.Location = new System.Drawing.Point(6, 31);
            this.rbHdd1000.Name = "rbHdd1000";
            this.rbHdd1000.Size = new System.Drawing.Size(60, 21);
            this.rbHdd1000.TabIndex = 0;
            this.rbHdd1000.TabStop = true;
            this.rbHdd1000.Text = "1 TB";
            this.rbHdd1000.UseVisualStyleBackColor = true;
            // 
            // gb_ekdonanim
            // 
            this.gb_ekdonanim.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb_ekdonanim.Controls.Add(this.cbWifi);
            this.gb_ekdonanim.Controls.Add(this.cbWebCam);
            this.gb_ekdonanim.Controls.Add(this.cbDvd);
            this.gb_ekdonanim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_ekdonanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_ekdonanim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_ekdonanim.Location = new System.Drawing.Point(12, 264);
            this.gb_ekdonanim.Name = "gb_ekdonanim";
            this.gb_ekdonanim.Size = new System.Drawing.Size(200, 148);
            this.gb_ekdonanim.TabIndex = 3;
            this.gb_ekdonanim.TabStop = false;
            this.gb_ekdonanim.Text = "Ek Donanımlar";
            // 
            // cbWifi
            // 
            this.cbWifi.AutoSize = true;
            this.cbWifi.Location = new System.Drawing.Point(0, 112);
            this.cbWifi.Name = "cbWifi";
            this.cbWifi.Size = new System.Drawing.Size(124, 21);
            this.cbWifi.TabIndex = 0;
            this.cbWifi.Text = "Wireless Kart";
            this.cbWifi.UseVisualStyleBackColor = true;
            // 
            // cbWebCam
            // 
            this.cbWebCam.AutoSize = true;
            this.cbWebCam.Location = new System.Drawing.Point(0, 76);
            this.cbWebCam.Name = "cbWebCam";
            this.cbWebCam.Size = new System.Drawing.Size(95, 21);
            this.cbWebCam.TabIndex = 0;
            this.cbWebCam.Text = "Web Cam";
            this.cbWebCam.UseVisualStyleBackColor = true;
            // 
            // cbDvd
            // 
            this.cbDvd.AutoSize = true;
            this.cbDvd.Location = new System.Drawing.Point(0, 34);
            this.cbDvd.Name = "cbDvd";
            this.cbDvd.Size = new System.Drawing.Size(89, 21);
            this.cbDvd.TabIndex = 0;
            this.cbDvd.Text = "DVD RW";
            this.cbDvd.UseVisualStyleBackColor = true;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_hesapla.Location = new System.Drawing.Point(280, 298);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(190, 43);
            this.btn_hesapla.TabIndex = 4;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = false;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_sonuc.Location = new System.Drawing.Point(277, 399);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(41, 17);
            this.lbl_sonuc.TabIndex = 5;
            this.lbl_sonuc.Text = "0 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.gb_ekdonanim);
            this.Controls.Add(this.gb_hdd);
            this.Controls.Add(this.gb_ram);
            this.Controls.Add(this.gb_islemci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_islemci.ResumeLayout(false);
            this.gb_islemci.PerformLayout();
            this.gb_ram.ResumeLayout(false);
            this.gb_ram.PerformLayout();
            this.gb_hdd.ResumeLayout(false);
            this.gb_hdd.PerformLayout();
            this.gb_ekdonanim.ResumeLayout(false);
            this.gb_ekdonanim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_islemci;
        private System.Windows.Forms.RadioButton rbCpur3;
        private System.Windows.Forms.RadioButton rbCpuR5;
        private System.Windows.Forms.RadioButton rbCpuI3;
        private System.Windows.Forms.RadioButton rbCpuI5;
        private System.Windows.Forms.RadioButton rbCpuI7;
        private System.Windows.Forms.GroupBox gb_ram;
        private System.Windows.Forms.RadioButton rbRam4;
        private System.Windows.Forms.RadioButton rbRam8;
        private System.Windows.Forms.RadioButton rbRam16;
        private System.Windows.Forms.GroupBox gb_hdd;
        private System.Windows.Forms.RadioButton rbHdd320;
        private System.Windows.Forms.RadioButton rbHdd500;
        private System.Windows.Forms.RadioButton rbHdd1000;
        private System.Windows.Forms.GroupBox gb_ekdonanim;
        private System.Windows.Forms.CheckBox cbWifi;
        private System.Windows.Forms.CheckBox cbWebCam;
        private System.Windows.Forms.CheckBox cbDvd;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

