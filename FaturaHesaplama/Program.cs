// See https://aka.ms/new-console-template for more information
using FaturaHesaplama;
using System.Collections;
TemelMusteri M1;
Console.WriteLine("Hoşgeldiniz\nBireysel Müşteri:1\nKurumsal Müşteri:2\nMüşteri tipini geçiniz(1/2): ");
int musteriTipi = Convert.ToInt32(Console.ReadLine());
if (musteriTipi == 1)
{
 M1 = new BireyselMusteri();
    M1.indirimYuzdesiHesapla();
}else if (musteriTipi == 2)
{
M1 = new KurumsalMusteri();
    M1.indirimYuzdesiHesapla();
}
else
{
    Console.WriteLine("Lütfen geçerli bir müşteri tipi seçiniz.");
    return;
}
Console.Write("Müşteri ismi: ");
M1.isim = Console.ReadLine();
Console.Write("Müşteri soyismi: ");
M1.soyisim = Console.ReadLine();

decimal total=0;
int bitir = 1;
while(bitir == 1) {
  Urun U1 = new Urun();
    Console.WriteLine("\nGıda:0\nElektronik:1\nGiyim:2\nSağlık:3\nEğitim:4");
Console.Write("Ürün türü seçiniz: ");
U1.urunTuru = (UrunTuruValue)(Convert.ToInt32(Console.ReadLine()));

Console.Write("Ürün adı giriniz: ");
U1.isim = Console.ReadLine();
Console.WriteLine("Ürün fiyatını giriniz: ");
U1.fiyat = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Ürün adedini giriniz: ");
U1.miktar = Convert.ToInt32(Console.ReadLine());
M1.sonFiyat(U1);
    total += U1.toplamFiyat;
    M1.urunEkle(U1);
   
Console.Write("\nÜrün ekle:1\nİşlemi sonlandır:2\nSeçiminiz: ");
bitir = Convert.ToInt32(Console.ReadLine());}
ArrayList list = TemelMusteri.urunListesi;



Console.WriteLine("\nFATURA YAZDIRILIYOR...\n");
Console.WriteLine("-----------------------------------------------------------------------------");
if(musteriTipi == 1)
{
    Console.WriteLine("Bireysel müşteri {0} {1}\nTarih: {2}" , M1.isim, M1.soyisim, DateTime.Now.ToString());
}
else if (musteriTipi == 2)
{
    Console.WriteLine("Kurumsal müşteri {0} {1}\nTarih: {2}", M1.isim, M1.soyisim, DateTime.Now.ToString());
}
Console.WriteLine("-----------------------------------------------------------------------------");

for(int i = 0; i < list.Count; i++)
{
    Console.WriteLine(((Urun)list[i]).isim + "        x" + ((Urun)list[i]).miktar + "        Birim Fiyat: " + ((Urun)list[i]).SonFiyat + "        Toplam Fiyat: " + ((Urun)list[i]).toplamFiyat);

}
Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine("Ödenen toplam ücret: {0}", total);
Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine("\nTeşekkür ederiz...");





