using LT.Web.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LT.Web.Data
{
    public class LunchTimeContext : IdentityDbContext<Customer>
    {
        public LunchTimeContext(DbContextOptions<LunchTimeContext> options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
