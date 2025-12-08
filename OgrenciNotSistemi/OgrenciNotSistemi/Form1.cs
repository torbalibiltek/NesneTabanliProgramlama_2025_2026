using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ogrenci ogrenci;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_ogrenciOlustur_Click(object sender, EventArgs e)
        {
            string ogrenci_adi = textBox_ogrenciAdi.Text;
            string ogrenci_soyadi = textBox_ogrenciSoyadi.Text;
            int ogrenci_numarasi = Convert.ToInt32(textBox_ogrenciNumarasi.Text);

            Ogrenci yeni_ogrenci = new Ogrenci(ogrenci_adi, ogrenci_soyadi, ogrenci_numarasi);

            listBox_ogrenciListesi.Items.Add(yeni_ogrenci);
        }

        private void listBox_ogrenciListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ogrenci = listBox_ogrenciListesi.SelectedItem as Ogrenci;
            textBox_ders1.Text = ogrenci.Ders1.ToString();
            textBox_ders2.Text = ogrenci.Ders2.ToString();
            textBox_ders3.Text = ogrenci.Ders3.ToString();
            textBox_ders4.Text = ogrenci.Ders4.ToString();
            textBox_ders5.Text = ogrenci.Ders5.ToString();
            textBox_devamsizlik.Text = ogrenci.Devamsizlik.ToString();
        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            /*
            ogrenci.Ders1 = Convert.ToInt32(textBox_ders1.Text);
            ogrenci.Ders2 = Convert.ToInt32(textBox_ders2.Text);
            ogrenci.Ders3 = Convert.ToInt32(textBox_ders3.Text);
            ogrenci.Ders4 = Convert.ToInt32(textBox_ders4.Text);
            ogrenci.Ders5 = Convert.ToInt32(textBox_ders4.Text);
            ogrenci.Devamsizlik = Convert.ToDouble(textBox_devamsizlik.Text);
            */
            int ders1_yeni = Convert.ToInt32(textBox_ders1.Text);
            int ders2_yeni = Convert.ToInt32(textBox_ders2.Text);
            int ders3_yeni = Convert.ToInt32(textBox_ders3.Text);
            int ders4_yeni = Convert.ToInt32(textBox_ders4.Text);
            int ders5_yeni = Convert.ToInt32(textBox_ders5.Text);

            double devamsizlik_yeni = Convert.ToDouble(textBox_devamsizlik.Text);

            ogrenci.OgrenciBilgiGuncelle(ders1_yeni, ders2_yeni, ders3_yeni, ders4_yeni, ders5_yeni, devamsizlik_yeni);

            MessageBox.Show("Öğrenci Bilgileri Güncellendi");

        }

        private void button_Sonucgoster_Click(object sender, EventArgs e)
        {
            label_belgeSonucu.Text = ogrenci.BelgeSonucuHesapla();
            label_ortalamaSonucu.Text = ogrenci.Ortalama.ToString();
            label_gecmeSonucu.Text = ogrenci.GecmeSonucuHesapla();
        }
    }
}
