using LunchTime.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchTime.Data
{
    public class LunchTimeSeeder
    {
        private readonly LunchTimeContext _ctx;

        public LunchTimeSeeder(LunchTimeContext ctx)
        {
            _ctx = ctx;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            if (!_ctx.Products.Any())
            {
                //Need to create sample data
               var customer1 = new Customer()
               {
                   Name = "John Smith",
                   Email = "j@mail.com",
                   Password = 123,
                   Currency = 30
               };
                _ctx.Customers.Add(customer1);

                var product1 = new Product()
                {
                    Name = "Sandwich",
                    Price = 12,
                    Stock = 10,
                    Description = "Kylling beacon sandwich"
                };
                _ctx.Products.Add(product1);

                var product2 = new Product()
                {
                    Name = "Sandwich",
                    Price = 12,
                    Stock = 10,
                    Description = "Røget laks sandwich"
                };
                _ctx.Products.Add(product2);

                var product3 = new Product()
                {
                    Name = "Pizza",
                    Price = 45,
                    Stock = 7,
                    Description = "Pizza med tomat, ost og skinke"
                };
                _ctx.Products.Add(product3);

                var order1 = new Order()
                {
                    OrderDate = DateTime.Now,
                    OrderNumber = "123",
                    Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product = product1,
                            Quantity = 2,
                        },

                        new OrderItem()
                        {
                            Product = product2,
                            Quantity = 3,
                        }
                    },
                    Customer = customer1,
                };
                _ctx.Orders.Add(order1);
                _ctx.SaveChanges();
            }
        }
    }
}
