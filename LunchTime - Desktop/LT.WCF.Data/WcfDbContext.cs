using System.Data.Entity;
using LT.WCF.Entities;

namespace LT.WCF.Data
{
    public class WcfDbContext : DbContext
    {
        // Her har vi vores ef dbset klasser som kommunikere med vores entities/modeller ud fra tabeller fra db'en
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Product> Products { get; set; }

        // Metoden OnModelCreating bruger vi til at specificere hvad der skal ske når entity modellerne bliver dannet ud fra db'en
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Her mapper vi OrderItem entity modellen til OrderItem tabellen i db'en
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
        }
    }

}
