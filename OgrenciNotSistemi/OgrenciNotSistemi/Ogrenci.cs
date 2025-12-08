using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotSistemi
{
    internal class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Numara { get; set; }
        public int Ders1 { get; set; }
        public int Ders2 { get; set; }
        public int Ders3 { get; set; }
        public int Ders4 { get; set; }
        public int Ders5 { get; set; }
        public double Devamsizlik { get; set; }
        public double Ortalama { get; set; }
        public int BelgeDurumu { get; set; }
        public bool GecmeDurumu { get; set; }

        public Ogrenci(string ogrenci_adi, string ogrenci_soyadi, int ogrenci_numarasi) { 
        
            Ad = ogrenci_adi;
            Soyad = ogrenci_soyadi;
            Numara = ogrenci_numarasi;
            Ders1 = 0; 
            Ders2 = 0;
            Ders3 = 0; 
            Ders4 = 0;
            Ders5 = 0;
            Devamsizlik = 0;
        }

        public override string ToString()
        {
            return $"{Numara}. {Ad} {Soyad}";
           // return $"{Numara} numarası olan öğrencinin adı ali, soyadı veli ";
            //return Numara.ToString() + " " + Ad + " " + Soyad;
        }   
    } 
}
