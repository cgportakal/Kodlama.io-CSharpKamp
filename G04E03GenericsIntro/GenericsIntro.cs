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
        }
    }
}
