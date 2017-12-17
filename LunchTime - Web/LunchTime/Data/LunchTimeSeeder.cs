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
            //var user1 = await _userManager.FindByEmailAsync("ps07118@ucn.dk");

            //if (user1 == null)
            //{
            //    user1 = new Customer()
            //    {
            //        Id = "ps07118",
            //        Name = "Storm Kim",
            //        UserName = "ps07118@ucn.dk",
            //        Email = "ps07118@ucn.dk",
            //        Currency = 50
            //    };
            //    var result1 = await _userManager.CreateAsync(user1, "2105851234");

            //    if (result1 != IdentityResult.Success)
            //    {
            //        throw new InvalidOperationException("Failed to create default user");
            //    }
            //}


                _ctx.Database.EnsureCreated();

            var user = await _userManager.FindByEmailAsync("j@mail.com");

            if (user == null)
            {
                user = new Customer()
                {
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
                //Need to create sample data
               //var customer1 = new Customer()
               //{
               //    Name = "John Smith",
               //    Email = "j@mail.com",
               //    Password = "123",
               //    Currency = 30
               //};
               // _ctx.Customers.Add(customer1);

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
                    OrderStatus = "aktiv",
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
                    //Customer = customer1,
                };
                _ctx.Orders.Add(order1);
                _ctx.SaveChanges();
            }
        }
    }
}
