using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unite05_formUygulamasi_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.CenterToScreen();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("onaylandı  tıklandı");
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("vazgeçildi  tıklandı");
        }

        private void button_ControlBox_Click(object sender, EventArgs e)
        {
            if (this.ControlBox == true)
            { this.ControlBox = false; }
            else { this.ControlBox = true; }
        }

        private void button_CentertToScreen_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            FormB formb = new FormB();
            formb.Show();
        }

        private void button_ShowDialog_Click(object sender, EventArgs e)
        {
            FormB formb = new FormB();
            formb.ShowDialog();
        }
    }
}
