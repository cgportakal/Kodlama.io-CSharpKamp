using System;

namespace ZKampG02O06
{
    class KampG02Od06
    {
        /// <summary>
        /// Kamp Gün 2 Ödev 6
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            UrunListele();

        }

        private static void UrunListele()
        {
            int j = 0;
            Product product1 = new Product();
            product1.urunId = 1;
            product1.urunAdi = "KodFare";
            product1.urunMarkasi = "Kodlama.io";
            product1.urunFiyati = 45.99;
            product1.urunStokAdedi = 1086;

            Product product2 = new Product();
            product2.urunId = 2;
            product2.urunAdi = "KodKlavye";
            product2.urunMarkasi = "Kodlama.io";
            product2.urunFiyati = 64.99;
            product2.urunStokAdedi = 800;

            Product product3 = new Product();
            product3.urunId = 3;
            product3.urunAdi = "KodMonitör";
            product3.urunMarkasi = "Kodlama.io";
            product3.urunFiyati = 899.99;
            product3.urunStokAdedi = 500;

            Product product4 = new Product();
            product4.urunId = 4;
            product4.urunAdi = "KodLaptop";
            product4.urunMarkasi = "Kodlama.io";
            product4.urunFiyati = 12499.99;
            product4.urunStokAdedi = 10;

            Product[] products = new Product[]{
                product1,
                product2,
                product3,
                product4,
            };


            Console.WriteLine("Foreach ile Listeleme:");
            foreach (var product in products)
            {

                Console.WriteLine("Urun ID:" + product.urunId
                                + ", Urun Adı: " + product.urunAdi
                                + ", Urun Markası: " + product.urunMarkasi
                                + ", Urun Fiyatı: " + product.urunFiyati
                                + ", Urun Stok Adedi: " + product.urunStokAdedi);
            }

            int adet = products.Length - 1;
            Console.WriteLine("For ile Listeleme:");
            for (int i = 0; i <= adet; i++)
            {
                Console.WriteLine("Urun ID:" + products[i].urunId
                                + ", Urun Adı: " + products[i].urunAdi
                                + ", Urun Markası: " + products[i].urunMarkasi
                                + ", Urun Fiyatı: " + products[i].urunFiyati
                                + ", Urun Stok Adedi: " + products[i].urunStokAdedi);
            }

            Console.WriteLine("While ile Listeleme:");
            while ((j <= adet))
            {
                Console.WriteLine("Urun ID:" + products[j].urunId
                                + ", Urun Adı: " + products[j].urunAdi
                                + ", Urun Markası: " + products[j].urunMarkasi
                                + ", Urun Fiyatı: " + products[j].urunFiyati
                                + ", Urun Stok Adedi: " + products[j].urunStokAdedi);
                j++;
            }
        }
    }

    class Product
    {
        public int urunId { get; set; }
        public string urunAdi { get; set; }
        public string urunMarkasi { get; set; }
        public double urunFiyati { get; set; }
        public int urunStokAdedi { get; set; }
    }
}