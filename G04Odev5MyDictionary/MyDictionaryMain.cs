using System;

namespace G04Odev5MyDictionary
{
    class MyDictionaryMain
    {
        static void Main(string[] args)
        {
            MyDictionary_GRUD<string, int> gamersAndKeys = new MyDictionary_GRUD<string, int>();

            gamersAndKeys.Add("Cafer", 4);
            gamersAndKeys.Add("Gökmen", 6);
            gamersAndKeys.Add("Zeynep", 5);
            gamersAndKeys.Add("Betül", 4);

            gamersAndKeys.Print();
        }
    }
}
