using System;
using System.Collections.Generic;

namespace G04Eg02Koleksiyonlar
{
    class KoleksiyonlarMain
    {
        static void Main(string[] args)
        {
            //Arrayler(); Bilerek hatalı yazılmıştır.
            //Arrayler daha sonradan genişletilemezler. Daha sonradan bir şey eklemek istediğimizde problem yaşarız.
            //Bu sebeple collections geliştirilmiş.            
            
            Collections();

        }

        private static void Collections()
        {
            List<string> isimler2 = new List<string> { "Cafer", "Gökmen", "Engin", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }

        private static void Arrayler()
        {
            string[] isimler = new string[] { "Cafer", "Gökmen", "Engin", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[4]);
            //string[] gecici = new string[5];
            //gecici = isimler;
            isimler = new string[6];
            //isimler = gecici;// Bu çalışmaz çünkü arrayler referans tiptir.
            isimler[5] = "İlker";
            Console.WriteLine(isimler[5]);
            Console.WriteLine(isimler[0]);//Null'dur çünkü üstte isimler için 6 adet değer alabilecek yeni bir referans oluşturduk.
            //Bu referansta da öncekiler doğal olarak yoktur.
        }
    }
}
