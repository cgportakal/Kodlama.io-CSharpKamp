using System;

namespace G04Eg03GenericsIntro
{
    class GenericsIntro
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            //MyList<int> idler = new MyList<int>();
            isimler.Add("Cafer");
            Console.WriteLine(isimler.Length);
            isimler.Add("Gökmen");
            Console.WriteLine(isimler.Length);
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
