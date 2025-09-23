using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaHesaplama
{
    internal abstract class TemelMusteri
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        protected int indirimYuzdesi;
        public abstract void indirimYuzdesiHesapla();
        public static ArrayList urunListesi = new ArrayList();

        public void urunEkle(Urun U)
        {
            urunListesi.Add(U);
        }
        public void sonFiyat(Urun U)
        {
            U.SonFiyat=  U.fiyat * U.vergi/100 * (100 - this.indirimYuzdesi)/100;
            U.toplamFiyat = U.SonFiyat * U.miktar;
           
        }
    }
}
