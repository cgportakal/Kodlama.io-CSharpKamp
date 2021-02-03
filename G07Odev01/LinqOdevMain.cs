using System;
using System.Collections.Generic;
using System.Linq;

namespace G07Odev01Linq
{
    class LinqOdevMain
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="8 GB Ram", UnitPrice=12000, UnitsInStock=15},
                new Product{ProductId=4, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=16000, UnitsInStock=0},
            };

            foreach (var product in products)
            {
                if (product.UnitPrice > 8000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("Linq------------------------");
            var result = products.Where(p => p.UnitPrice > 8000 && p.UnitsInStock > 3);//Foreach döngüsünün Linq ile kısa hali.
            //var result = products.Where(product => product.UnitPrice > 8000 && product.UnitsInStock > 3);//Üsttekinin açık hali
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProduct = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 8000 && product.UnitsInStock > 3)
                {
                    filteredProduct.Add(product);
                }
            }
            return filteredProduct;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 8000 && product.UnitsInStock > 3).ToList();
        }
    }
}
