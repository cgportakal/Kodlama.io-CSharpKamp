using System;

namespace G03Odev3ClassMetotDemo
{
    class ClassMetotDemo
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Müşteri bilgilerini manuel olarak girmek ister misiniz? Evet ise E'ye basınız...");
            char cevap = Console.ReadKey().KeyChar;
            if (cevap == 'E' || cevap == 'e')
            {
                Console.WriteLine("ID");
                musteri1.musteriId = Int16.Parse(Console.ReadLine());
                Console.WriteLine("Adınız: ");
                musteri1.musteriAdi = Console.ReadLine();
                Console.WriteLine("Soyadınız: ");
                musteri1.musteriSoyad = Console.ReadLine();
                Console.WriteLine("Telefon: ");
                musteri1.musteriTelefon = Console.ReadLine();
                Console.WriteLine("Adres: ");
                musteri1.musteriAdres = Console.ReadLine();            
            }
            else
            {
                musteri1.musteriId = 1;
                musteri1.musteriAdi = "Cafer";
                musteri1.musteriSoyad = "Portakal";
                musteri1.musteriTelefon = "012345678900";
                musteri1.musteriAdres = "Turkey";
            }

            musteriManager.MusteriEkle(musteri1.musteriId, musteri1.musteriAdi, musteri1.musteriSoyad, musteri1.musteriTelefon, musteri1.musteriAdres);
            Console.ReadKey();
        }
    }
}
