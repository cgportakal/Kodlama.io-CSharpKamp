using System;
using System.Collections.Generic;
using System.Text;

namespace G04Eg01OOP1
{
    /// <summary>
    /// CRUD= Create, Read, Update, Delete operations short name. That will develope here.
    /// </summary>
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
            
            //product.ProductName = "Kamera";
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");

            //product.ProductName = "Kamera";
        }

        public void DoSomething(ref int sayi)
        {
            sayi = 50;
            Console.WriteLine(sayi);//cevap her iki sayı için de 50 olur çünkü refrens ettik.
        }
    }
}
