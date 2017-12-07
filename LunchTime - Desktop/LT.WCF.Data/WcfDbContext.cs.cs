using System.Data.Entity;
using LT.WCF.Entities;

namespace LT.WCF.Data
{
    public class WcfDbContext : DbContext
    {
        // Her har vi vores dbset klasser som kommunikere med vores entities/modeller ud fra tabeller fra db'en
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
