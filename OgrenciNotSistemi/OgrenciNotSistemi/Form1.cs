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
            int Ders1_yeni = Convert.ToInt32(textBox_ders1.Text);
            int Ders2_yeni = Convert.ToInt32(textBox_ders2.Text);
            int Ders3_yeni = Convert.ToInt32(textBox_ders3.Text);
            int Ders4_yeni = Convert.ToInt32(textBox_ders4.Text);
            int Ders5_yeni = Convert.ToInt32(textBox_ders5.Text);

            double Devamsizlik_yeni = Convert.ToDouble(textBox_devamsizlik.Text);

            ogrenci.OgrenciBilgiGuncelle(Ders1_yeni, Ders2_yeni, Ders3_yeni, Ders4_yeni, Ders5_yeni, Devamsizlik_yeni);

            MessageBox.Show("Öğrenci Bilgileri Güncellendi");

        }
    }
}
