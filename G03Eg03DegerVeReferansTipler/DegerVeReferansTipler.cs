using System;

namespace G03Eg03DegerVeReferansTipler
{
    class DegerVeReferansTipler
    {
        static void Main(string[] args)
        {
            //Değer tipler: int, string, double, bool
            //Referans Tipler: Array, Class, Interface
            //Değer tipler bir birlerinin değerine eşitlenebilir.
            //Referans tipler ise bir birlerinin bellekte refere ettiği yere eşitlenir.

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = ??;

            int[] sayiler1 = new int[] { 10, 20, 30 };
            int[] sayiler2 = new int[] { 100, 200, 300 };

            sayiler1 = sayiler2;
            sayiler2[0] = 999;
            Console.WriteLine(sayiler1[0]);
        }
    }
}
