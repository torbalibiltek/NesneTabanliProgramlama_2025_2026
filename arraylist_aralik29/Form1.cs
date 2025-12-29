using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arraylist_aralik29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sehirler = new ArrayList();
        private void button_ekle_Click(object sender, EventArgs e)
        {sehirler.Add(textBox_sehir_adi.Text);
        }
        private void button_index_goster_Click(object sender, EventArgs e)
        {  int index_no = Convert.ToInt16(textBox_index_no.Text);
            if (index_no < sehirler.Count)
            {MessageBox.Show((string)sehirler[index_no]);
            }else
            MessageBox.Show("Hatalı İndex Girişi");
        }
        private void button_listele_Click(object sender, EventArgs e)
        {
            listbox_listele();
        }

        private void button_araya_ekle_Click(object sender, EventArgs e)
        {
            if (listBox_sehirler.SelectedIndex != -1)
                sehirler.Insert(listBox_sehirler.SelectedIndex, textBox_sehir_adi.Text);
            listbox_listele();
           
        }

        private void listbox_listele()
        {
            listBox_sehirler.Items.Clear();
            for (int i = 0; i < sehirler.Count; i++)
            { listBox_sehirler.Items.Add(sehirler[i]); }
        }
    }
}
