using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /// <summary>
    /// Class Çıplak Kalmasın. Yani interface'e bağlanmıyorsa ileride problem yaşama ihtimalimiz çok yüksek.
    /// </summary>
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
