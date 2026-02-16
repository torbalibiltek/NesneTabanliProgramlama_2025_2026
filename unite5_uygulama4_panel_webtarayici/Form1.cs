using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unite5_uygulama4_panel_webtarayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string homapageAdress = "www.google.com";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_git_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void button_homapage_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(homapageAdress);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
