using System;
using System.Collections.Generic;
using System.Text;

namespace G03Odev3ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(int id, string ad, string soyad, string telefon, string adres)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = id;
            musteri1.musteriAdi = ad;
            musteri1.musteriSoyad = soyad;
            musteri1.musteriTelefon = telefon;
            musteri1.musteriAdres = adres;
            Console.WriteLine("Listelemek istiyor musunuz? Evet ise E'ye basınız...");
            char cevap = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (cevap == 'E' || cevap == 'e')
                MusteriListele(musteri1);
            else
                Console.WriteLine("Listelenmeyecek...");
        }

        public void MusteriListele(Musteri musteri1)
        {
            Console.WriteLine("Adı: " + musteri1.musteriAdi +
                  ", Soyadı: " + musteri1.musteriSoyad +
                  ", Telefon: " + musteri1.musteriTelefon +
                  ", Adres: " + musteri1.musteriAdres);
            
            Console.WriteLine("Silmek istiyor musunuz? Evet ise E'ye basınız...");
            char cevap = Console.ReadKey().KeyChar;
            if (cevap == 'E' || cevap == 'e')
                MusteriSilme(musteri1);
            else
                Console.WriteLine("Silinmeyecek...");
            
        }

        public void MusteriSilme(Musteri musteri1)
        {
            musteri1 = null;
            Console.WriteLine();
            Console.WriteLine("Müşteri silindi!");
        }
    }
}
