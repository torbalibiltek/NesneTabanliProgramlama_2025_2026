using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikiboyutludizi_22aralik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isimler = new string[3];
        double[,] notlar = new double[3, 4];
        double[] ortalamalar = new double[3];
        int index = 0, g_index = 0;

        private void button_listele_Click(object sender, EventArgs e)
        {
            listBox_liste.Items.Clear();
            for(int i = 0; i < 3; i++)
            {
                string bilgi = isimler[i] + " => " + ortalamalar[i].ToString();
                listBox_liste.Items.Add(bilgi);
            }
        }

        private void button_ortalama_goster_Click(object sender, EventArgs e)
        {
            label_ortalama_sonuc.Text = ortalamalar.Average().ToString();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            if (listBox_liste.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Güncellenecek Öğrenciyi Seçin");
                return;
            }
            string adSoyad = textBox_adsoyad.Text;
            int y1 = int.Parse(textBox_y1.Text);
            int y2 = int.Parse(textBox_y2.Text);
            int s1 = int.Parse(textBox_s1.Text);
            int s2 = int.Parse(textBox_s2.Text);

            double ort = (y1 + y2 + s1 + s2) / 4.0;

            string yeniVeri = adSoyad + "|" + y1 + "," + y2 + "," + s1 + "," + s2 + "|Ort:" + ort.ToString("0.00");

            listBox_liste.Items[listBox_liste.SelectedIndex] = yeniVeri;
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            if (index < 3)
            {
                isimler[index] = textBox_adsoyad.Text;
                notlar[index, 0] = Convert.ToDouble(textBox_y1.Text);
                notlar[index, 1] = Convert.ToDouble(textBox_y2.Text);
                notlar[index, 2] = Convert.ToDouble(textBox_s1.Text);
                notlar[index, 3] = Convert.ToDouble(textBox_s2.Text);
                ortalamalar[index] = (notlar[index, 0] + notlar[index, 1] +
                                        notlar[index, 2] + notlar[index, 3]) / 4;
                index++;
            }
        }
    }
}
