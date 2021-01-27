using System;
using System.Collections.Generic;
using System.Text;

namespace G04Odev5MyDictionary
{
    class MyDictionary_GRUD<T_key, T_value>
    {
        T_key[] _key;
        T_value[] _value;
        T_key[] _tempkey;
        T_value[] _tempvalue;
        public MyDictionary_GRUD()
        {
            _key = new T_key[0];
            _value = new T_value[0];
        }
        public void Add(T_key item, T_value item1)
        {
            _tempkey = _key;
            _key = new T_key[_key.Length + 1];
            for (int i = 0; i < _tempkey.Length; i++)
            {
                _key[i] = _tempkey[i];
            }
            _key[_key.Length - 1] = item;

            _tempvalue = _value;
            _value = new T_value[_value.Length + 1];
            for (int i = 0; i < _tempvalue.Length; i++)
            {
                _value[i] = _tempvalue[i];
            }
            _value[_value.Length - 1] = item1;
        }

        public void Print()
        {
            Console.WriteLine("  " + "-----> Eskrim Oyuncuları Ve Tuşlamalar Tablosu <-----\n");
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine("  " + _key[i] + ": " + _value[i] + " tuş");
            }
        }
    }
}
