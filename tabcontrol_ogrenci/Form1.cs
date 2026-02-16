using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabcontrol_ogrenci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ogrenci ogrenci;


        private void button_ogrenciOlustur_Click(object sender, EventArgs e)
        {
            string adsoyad = textBox_adSoyad.Text;
            string sube = comboBox_sube.Text;
            string sinif = comboBox_sinif.Text;
            string bolum = comboBox_bolum.Text;

            ogrenci = new Ogrenci(adsoyad, sube, sinif, bolum);

            textBox_devamsizlik.Text = ogrenci.DevamsizlikSayisi.ToString();

            dataGridView1.DataSource = ogrenci.dersler;

            MessageBox.Show("Öğrenci Oluşturuldu Ders Bilgilerini Girebilirsiniz");

            
            
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            label_sonucGoster.Text = ogrenci.ToString();
            MessageBox.Show(ogrenci.ToString());
        }

        private void button_dersleriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ogrenci.DevamsizlikSayisi = int.Parse(textBox_devamsizlik.Text);
            } catch(FormatException)
            {
                MessageBox.Show("Devamsızlık yanlış girildi");
                return;
            }
            ogrenci.DisiplinDurumu = checkBox_disiplin.Checked;
        }
    }
}
