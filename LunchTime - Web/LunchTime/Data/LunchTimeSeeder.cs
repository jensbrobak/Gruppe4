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
        private readonly UserManager<Customer> _userManager;

        public LunchTimeSeeder(LunchTimeContext ctx, UserManager<Customer> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }

        public async Task Seed()
        {
                _ctx.Database.EnsureCreated();

            var user = await _userManager.FindByEmailAsync("j@mail.com");

            if (user == null)
            {
                user = new Customer()
                {
                    Id = "dmab0916",
                    Name = "John",
                    UserName = "j@mail.com",
                    Email = "j@mail.com",
                    Currency = 30
                };
                var result = await _userManager.CreateAsync(user, "1234567890");

                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Failed to create default user");
                }

            }

            if (!_ctx.Products.Any())
            {
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
                    Customer = user,
                    OrderStatus = "Aktiv",
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
                };
                _ctx.Orders.Add(order1);
                _ctx.SaveChanges();
            }
        }
    }
}
