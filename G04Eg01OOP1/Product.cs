using System;
using System.Collections.Generic;
using System.Text;

namespace G04Eg01OOP1
{
    /// <summary>
    /// Bu tip class'larda sadece özellik olur.
    /// </summary>
    class Product
    {
        //snippet Hazır kod yazmak için kısaltmalar
        public int Id { get; set; } //Primary Key for Product
        public int CategoryId { get; set; }//Foreign Key for Category
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        //Yazma Teknikleri
        //PascalCase
        //camelCase
        //C# is a case sensitive programming language
    }
}
