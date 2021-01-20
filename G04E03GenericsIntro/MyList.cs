﻿using System;
using System.Collections.Generic;
using System.Text;

namespace G04Eg03GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //Constructor Bir class new'lendiğinde yani nesnesi oluşturulduğunda ilk çalışan metottur.
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
