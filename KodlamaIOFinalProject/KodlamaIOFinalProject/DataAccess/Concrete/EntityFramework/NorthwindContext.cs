using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    /// <summary>
    /// Context: Db tabloları ile proje classlarını bağlamak
    /// Bir string'in başına @ koyunca içindeki anlamlı karakterleri yani \ işaretini string kabul et anlamını taşır.
    /// </summary>
    public class NorthwindContext : DbContext
    {
        /// <summary>
        /// Burada veritabanı ve tabloyu seçtik.
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=TOSHIBA-CP;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
