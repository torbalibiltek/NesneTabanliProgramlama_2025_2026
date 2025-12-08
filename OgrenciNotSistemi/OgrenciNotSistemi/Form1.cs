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
    }
}
