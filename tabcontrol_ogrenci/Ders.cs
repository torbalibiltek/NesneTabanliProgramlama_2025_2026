using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabcontrol_ogrenci
{
    internal class Ders
    {
        public string dersAdi { get; set; }
        public double? puan1 { get; set; }
        public double? puan2 { get; set; }
        public double? puan3 { get; set; }
        public double? puan4 { get; set; }

        public double? ortalama { get {
                double toplam = 0;
                int say = 0;
                if (puan1.HasValue)
                {
                    toplam += puan1.Value;
                    say++;
                }
                if (puan2.HasValue)
                {
                    toplam += puan2.Value;
                    say++;
                }
                if (puan3.HasValue)
                {
                    toplam += puan3.Value;
                    say++;
                }
                if (puan4.HasValue)
                {
                    toplam += puan4.Value;
                    say++;
                }

                if (say > 0) return toplam / say;
                
                return null;
            }  
        }

        public Ders() { 
        

        
        
        }
    }
}
