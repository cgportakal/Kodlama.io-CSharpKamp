using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    /// <summary>
    /// SOLID'in O'su uygulandı.
    /// Open Closed Principle Yeni bir özellik ekliyorsan mevcuttaki hiç bir koda dokunamazsın biz de 
    /// 
    /// </summary>
    class ConsoleUIMain
    {
        static void Main(string[] args)
        {
            //2021.02.03 tarihindeki kodlar
            // ProductTest();

            //2021.02.06 tarihindeki kodlar
            //CategoryTest();
            ProductTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            //Önceki derslerdeki durum. Sadece burayı değiştirerek EntityFramework sistemine geçtik
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
    }
}
