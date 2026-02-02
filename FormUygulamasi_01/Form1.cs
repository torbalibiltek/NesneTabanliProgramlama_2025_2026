using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUygulamasi_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
        int anahtar;
        string deger;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox_OkulNo.Text);
            deger = textBox_AdSoyad.Text;
            ogrenciler.Add(anahtar, deger);
            listele();

        }

        private void listele()
        {
            listBox_OgrencilerListesi.Items.Clear();
            foreach (var ogrenci in ogrenciler)
            {
                listBox_OgrencilerListesi.Items.Add(ogrenci.Key + " " + ogrenci.Value);
            }
        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox_OkulNo.Text);
            deger = textBox_AdSoyad.Text;
            if (ogrenciler.ContainsKey(anahtar))
                ogrenciler[anahtar] = deger;
            else
                MessageBox.Show("GARDAŞ BÖLE Bİ GARDAŞ YOKTURRRRRRRRRR");
            listele();
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox_OkulNo.Text);
            deger = textBox_AdSoyad.Text;
            if (ogrenciler.ContainsKey(anahtar))
                ogrenciler.Remove(anahtar);
            else
                MessageBox.Show("GARDAŞ BÖLE Bİ GARDAŞ YOKTURRRRRRRRRR");
            listele();
        }

        private void button_Ara_Click(object sender, EventArgs e)
        {
            anahtar = int.Parse(textBox_OkulNo.Text);
            bool durum = ogrenciler.ContainsKey(anahtar) ;
            if (durum) 
                MessageBox.Show("öğrenci kayıtlı" + 
                    ogrenciler[anahtar]);
            else
                   MessageBox.Show("öğrenci kayıtlı deel");

        }
    }
}
