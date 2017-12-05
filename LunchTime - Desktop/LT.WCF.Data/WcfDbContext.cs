using System.Data.Entity;
using LT.WCF.Entities;

namespace LT.WCF.Data
{
    public class WcfDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
