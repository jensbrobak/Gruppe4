using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wcf.Entities;

namespace Wcf.Data
{
    public class WcfDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // modelBuilder.Entity<Order>().Ignore(o => o.Id );

            //modelBuilder.Entity<Customer>()
             //.Property(c => c.Id) // Client must set the ID.
            // .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

          modelBuilder.Entity<Customer>().Ignore(c => c.FullName);


         //   modelBuilder.Entity<Order>()
           //     .Property(o => o.Id);

            //modelBuilder.Entity<Order>()
            //  .Property(o => o.Id);

        }
    }
}
