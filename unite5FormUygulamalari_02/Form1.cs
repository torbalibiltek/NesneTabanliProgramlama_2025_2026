using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unite5FormUygulamalari_02
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

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            decimal tabanfiyat = 0; 
            decimal diskfiyat = 0;
            
            if (rbHdd1000.Checked)
            {
                diskfiyat = 2500;
            }
            else if(rbHdd500.Checked) {
                diskfiyat = 1300;
            }
            else if (rbHdd320.Checked)
            {
                diskfiyat = 650;
            }
            tabanfiyat += diskfiyat;
            

            decimal işlemci = 0;

            if (rbCpuI7.Checked)
            {
                işlemci = 13000;
            }
            else if (rbCpuI5.Checked)
            {
                işlemci = 10000;
            }
            else if (rbCpuI3.Checked)
            {
                işlemci = 9000;
            }
            else if (rbCpuR5.Checked)
            {
                işlemci = 7000;
            }
            else if (rbCpur3.Checked)
            {
                işlemci = 5000;
            }
            tabanfiyat += işlemci;
           

            decimal ramfiyat = 0;
            if (rbRam16.Checked)
            {
                ramfiyat = 5000;
            }
            else if (rbRam8.Checked)
            {
                ramfiyat = 3000;
            }
            else if (rbRam4.Checked) 
            {
                ramfiyat = 1000;
            }
            tabanfiyat += ramfiyat;
            lbl_sonuc.Text = tabanfiyat.ToString() + "TL";
            decimal ekdonanımlarfiyat = 0;
            if (cbDvd.Checked)
            {
                tabanfiyat += 1500;
            }
            if (cbWebCam.Checked)
            {
                tabanfiyat += 1400;
            }
            if (cbWifi.Checked)
            {
                tabanfiyat += 1600;
            }
            tabanfiyat = tabanfiyat+tabanfiyat * 0.18m;
            lbl_sonuc.Text = tabanfiyat.ToString() + "TL";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
