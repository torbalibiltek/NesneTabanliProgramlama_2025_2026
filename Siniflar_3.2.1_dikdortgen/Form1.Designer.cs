namespace Siniflar_3._2._1_dikdortgen
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
            this.button_hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kenar1 = new System.Windows.Forms.TextBox();
            this.textBox_kenar2 = new System.Windows.Forms.TextBox();
            this.label_alan = new System.Windows.Forms.Label();
            this.label_cevre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_hesapla
            // 
            this.button_hesapla.Location = new System.Drawing.Point(75, 150);
            this.button_hesapla.Name = "button_hesapla";
            this.button_hesapla.Size = new System.Drawing.Size(169, 37);
            this.button_hesapla.TabIndex = 0;
            this.button_hesapla.Text = "Hesapla";
            this.button_hesapla.UseVisualStyleBackColor = true;
            this.button_hesapla.Click += new System.EventHandler(this.button_hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çevre";
            // 
            // textBox_kenar1
            // 
            this.textBox_kenar1.Location = new System.Drawing.Point(75, 36);
            this.textBox_kenar1.Name = "textBox_kenar1";
            this.textBox_kenar1.Size = new System.Drawing.Size(197, 20);
            this.textBox_kenar1.TabIndex = 2;
            // 
            // textBox_kenar2
            // 
            this.textBox_kenar2.Location = new System.Drawing.Point(75, 83);
            this.textBox_kenar2.Name = "textBox_kenar2";
            this.textBox_kenar2.Size = new System.Drawing.Size(197, 20);
            this.textBox_kenar2.TabIndex = 2;
            // 
            // label_alan
            // 
            this.label_alan.AutoSize = true;
            this.label_alan.Location = new System.Drawing.Point(583, 36);
            this.label_alan.Name = "label_alan";
            this.label_alan.Size = new System.Drawing.Size(68, 13);
            this.label_alan.TabIndex = 1;
            this.label_alan.Text = "Alan Sonucu";
            // 
            // label_cevre
            // 
            this.label_cevre.AutoSize = true;
            this.label_cevre.Location = new System.Drawing.Point(583, 90);
            this.label_cevre.Name = "label_cevre";
            this.label_cevre.Size = new System.Drawing.Size(75, 13);
            this.label_cevre.TabIndex = 1;
            this.label_cevre.Text = "Çevre Sonucu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_kenar2);
            this.Controls.Add(this.textBox_kenar1);
            this.Controls.Add(this.label_cevre);
            this.Controls.Add(this.label_alan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_hesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_hesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kenar1;
        private System.Windows.Forms.TextBox textBox_kenar2;
        private System.Windows.Forms.Label label_alan;
        private System.Windows.Forms.Label label_cevre;
    }
}

