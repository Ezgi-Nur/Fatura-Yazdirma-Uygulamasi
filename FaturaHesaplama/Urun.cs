using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaHesaplama
{
    internal class Urun
    {
        public string isim { get; set; }
        public int miktar { get; set; }
        public decimal fiyat { get; set; }
        public decimal SonFiyat { get; set; }
        public decimal toplamFiyat { get; set; }
        
        public UrunTuruValue urunTuru;
        public int vergi;
        public Urun()
        {
           vergi = vergiHesapla(this);
        }
        
        public int vergiHesapla(Urun U1)
        {
            switch ((int)U1.urunTuru)
            {
                case 0:
                    return 110;
                    break;
                case 1:
                    return 120;
                    break;
                    case 2:
                    return 115;
                    break;
                    case 3:
                    return 105;
                    break;
                case 4:
                    return 110;
                    break;
                default:
                    Console.WriteLine("Geçersiz ürün türü");
                    return 0;
                    break;
            }
        }
       
    }
}
