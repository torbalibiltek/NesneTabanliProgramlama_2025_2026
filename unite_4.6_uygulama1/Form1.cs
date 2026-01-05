using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unite_4._6_uygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int index = 0;
        private void button_ekle_Click(object sender, EventArgs e)
        {
            if(index <= 4)
            {
                isimler[index] = textBox_adsoyad.Text;
                index++;
            }
        }

        private void button_aranan_Click(object sender, EventArgs e)
        {
            int aranan = Convert.ToInt16(textBox_aranan.Text);
            if (aranan >= 0 && aranan <= 4)
            {
                MessageBox.Show(isimler[aranan]);
            }
            else { MessageBox.Show("Hatalı index girdiniz"); 
            }
        }

        private void button_listele_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < isimler.Length; i++)
            {
                listBox_isimler.Items.Add(isimler[i]);
            }*/
            foreach (string isim in isimler)

            {
                listBox_isimler.Items.Add(isim);
            }
        }
    }
}
