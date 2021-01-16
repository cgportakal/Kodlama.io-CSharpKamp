using System;

namespace G02Eg02Donguler
{
    class Donguler
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C#";
            string kurs6 = "C++";

            //Array - Dizi
            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java",
                "Python",
                "C#",
                "C++"
            };

            Console.WriteLine("For Loop");
            for (int i = 0; i <= kurslar.Length-1; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("_________________________");
            
            Console.WriteLine("Foreach Loop");
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
