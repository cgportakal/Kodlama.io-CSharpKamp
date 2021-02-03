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
            //Önceki derslerdeki durum. Sadece burayı değiştirerek EntityFramework sistemine geçtik
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());
            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //2021.01.03 tarihindeki kodlar
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
