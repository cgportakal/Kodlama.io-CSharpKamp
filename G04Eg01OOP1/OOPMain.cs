using System;

namespace G04Eg01OOP1
{
    class OOPMain
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//2 Mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,//5 Kırtasiye
                UnitInStock = 1500,
                ProductName = "Kalem",
                UnitPrice = 5
            };
            ProductManager productManager = new ProductManager();
            string isim = "Cafer";
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);



            //int sayi = 100;
            //productManager.DoSomething(ref sayi);
            //Console.WriteLine(sayi);


            Console.ReadKey();
        }
    }
}
