using System;

namespace G02Eg03Classes
{
    class Classes
    {
        static void Main(string[] args)
        {
            string adi = "Cafer";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmet = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmet = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmet = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,
                kurs2,
                kurs3
            };
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmet { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
