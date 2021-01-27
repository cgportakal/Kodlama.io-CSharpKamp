using System;

namespace G04Odev5MyDictionary
{
    class MyDictionaryMain
    {
        static void Main(string[] args)
        {
            MyDictionary_GRUD<int, string> gamersAndKeys = new MyDictionary_GRUD<int, string>();

            gamersAndKeys.Add(4, "Cafer");
            gamersAndKeys.Add(6, "Gökmen");
            gamersAndKeys.Add(5, "Zeynep");
            gamersAndKeys.Add(8, "Betül");

            gamersAndKeys.Print();
        }
    }
}
