using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siniflar_3._2._1_dikdortgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_hesapla_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt16(textBox_kenar1.Text);
            b = Convert.ToInt16(textBox_kenar2.Text);

            Dikdortgen dikdortgen1 = new Dikdortgen(a, b);

            label_alan.Text = dikdortgen1.AlanHesapla().ToString();
            label_cevre.Text = dikdortgen1.CevreHesapla().ToString();
        }
    }

    class Dikdortgen
    {

        private int a, b;
        public Dikdortgen(int a, int b)
        {
            this.a = a;
            this.b = b;

        }
        public int AlanHesapla()
        {
            return this.a * this.b;
        }

        public int CevreHesapla()
        {
            return (this.a + this.b)*2;
        }



    }



}
