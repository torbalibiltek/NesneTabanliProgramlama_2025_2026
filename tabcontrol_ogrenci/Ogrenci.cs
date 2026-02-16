using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabcontrol_ogrenci
{
    internal class Ogrenci
    {

        
    // Özellikler (Properties)
        public string AdiSoyadi { get; set; }
        public string Sinifi { get; set; }          // örn: "10", "11", "12", "Hazırlık"
        public string Bolumu { get; set; }          // örn: "Sayısal", "Sözel", "Eşit Ağırlık", "Meslek"
        public string Subesi { get; set; }  
        
        public int DersSayisi { get; set; } // örn: "A", "B", "C", "Fen", "Yabancı Dil"

        public int DevamsizlikSayisi { get; set; }
        public bool DisiplinDurumu { get; set; }    // true = temiz / false = cezalı vs.

        // 5 Ders (notları da tutmak istersen diye double olarak yaptım)

        public BindingList<Ders> dersler { get; set; } = new BindingList<Ders>();
        // Varsayılan yapıcı (constructor)
        /*
        public Ogrenci()
        {
            DevamsizlikSayisi = 0;
            DisiplinDurumu = true;  // başlangıçta temiz kabul edelim
                                    // notlar otomatik 0 gelir (double'ın default değeri)
        }
        */

        // Daha kullanışlı bir yapıcı (önerilen)
        public Ogrenci(string adiSoyadi, string sinif, string bolum, string sube)
        {
            AdiSoyadi = adiSoyadi;
            Sinifi = sinif;
            Bolumu = bolum;
            Subesi = sube;

            DevamsizlikSayisi = 0;
            DisiplinDurumu = true;
        }

        // Örnek: Ortalama hesaplayan metod
        public double OrtalamaHesapla()
        {
            double toplam = 0;
            double adet = 0;
            foreach(Ders d in dersler)
            {
                var ort = d.ortalama;
                if(ort.HasValue)
                {
                    toplam += ort.Value;
                    adet++;
                }
            }

            if (adet > 0)
                return toplam / adet;
            return 0;
        }

        // Örnek: Devamsızlık kontrolü
        public string DevamsizlikDurumu()
        {
            if (DevamsizlikSayisi >= 20)
                return "Tehlike! Sınıfta kalma riski çok yüksek.";
            else if (DevamsizlikSayisi >= 10)
                return "Dikkat! Devamsızlık sınırı yaklaşıyor.";
            else
                return "Devamsızlık durumu normal.";
        }

        // Bilgileri güzel yazdırmak için ToString override etmek faydalı olur
        public override string ToString()
        {
            return $"Ad Soyad     : {AdiSoyadi}\n" +
                   $"Sınıf        : {Sinifi} / {Bolumu} / {Subesi}\n";// +
                 //  $"Devamsızlık   : {DevamsizlikSayisi} gün\n" +
                //   $"Disiplin     : {(DisiplinDurumu ? "Temiz" : "Sorunlu")}\n" +
                //   $"Ortalama     : {OrtalamaHesapla():F2}\n" +
                //   $"Mat: {Matematik,4}  Türkçe: {Turkce,4}  Fen: {FenBilimleri,4}\n" +
                //   $"Sos: {SosyalBilgiler,4}  İng: {Ingilizce,4}";
        }
    }



}

