using LunchTime.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LunchTime.Data
{
    public class LunchTimeRepository : ILunchTimeRepository
    {
        private readonly LunchTimeContext _ctx;
        private readonly ILogger<LunchTimeRepository> _logger;

        public LunchTimeRepository(LunchTimeContext ctx, ILogger<LunchTimeRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<Order> GetAllOrders(bool includeItems)
        {
            if (includeItems)
            {
                return _ctx.Orders
                    .Include(o => o.Items)
                    .ThenInclude(i => i.Product)
                    .ToList();
            }
            else
            {
                return _ctx.Orders
                    .ToList();
            }
        }

        public IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems)
        {
            if (includeItems)
            {
                return _ctx.Orders
                    .Where(o => o.Customer.UserName == username)
                    .Include(o => o.Items)
                    .ThenInclude(i => i.Product)
                    .ToList();
            }
            else
            {
                return _ctx.Orders
                    .Where(o => o.Customer.UserName == username)
                    .ToList();
            }
        }

        public Order GetOrderById(string username, int id)
        {
            return _ctx.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .Where(o => o.Id == id && o.Customer.UserName == username)
                .FirstOrDefault(); // returns the first one it finds or null if it didnt find it
        }


        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                _logger.LogInformation("GetAllProducts was called");

                return _ctx.Products
                    //.OrderBy(p => p.Title)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get all products: {ex}");
                return null;
            }
            
        }

        //public Customer CustomerLoginAsync(string email, int password)
        //{
        //    return _ctx.Customers
        //        .SingleOrDefault(c => c.Email.Equals(email) && c.Password == password);
        //}

        //public IEnumerable<Product> GetProductsByCatagory(string catagory)
        //{
        //    //TODO try/catch
        //    return _ctx.Products
        //        //.Where(p => p.Category == catagory)
        //        .ToList();
        //}

        public bool SaveAll()
        {
            try
            {
                _logger.LogInformation("SaveAll was called");
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to save changes: {ex}");
                return false;
            }
        }

        public void AddEntity(object model)
        {
            _ctx.Add(model);
        }

        public void AddOrder(Order newOrder) // Might be here to do a compare to stock and payment or call methods to do so
        {
            using (var dbContextTransaction = _ctx.Database.BeginTransaction())
            {
                try
                {
                    double totalPrice = 0;
                    bool inStock = false;

                    // Convert new products to lookup of product
                    foreach (var item in newOrder.Items)
                    {
                        item.Product = _ctx.Products.Find(item.Product.Id);
                        totalPrice += item.Product.Price;
                        if (_ctx.Products.Find(item.Product.Id).Stock >= item.Quantity)
                        {
                            inStock = true;
                        }
                        else
                        {
                            throw new Exception("Item is not in stock");
                        }
                    }

                    if (newOrder.Customer.Currency >= totalPrice && inStock)
                    {
                        newOrder.Customer.Currency -= totalPrice;
                        foreach (var item in newOrder.Items)
                        {
                            _ctx.Products.Find(item.Product.Id).Stock -= item.Quantity;
                        }
                    }
                    else
                    {
                        throw new Exception("Failed to complete payment");
                    }
                    
                    AddEntity(newOrder);
                    dbContextTransaction.Commit();
                    _logger.LogInformation("Transaction was completed");
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    _logger.LogError($"Failed to complete transaction: {ex}");
                }
            }
        }

        //private void Payment(Order newOrder)
        //{
        //    double totalPrice = 0;

        //    foreach (var item in newOrder.Items)
        //    {
        //        totalPrice += _ctx.Products.Find(item.Product.Id).Price;
        //    }

        //    if (newOrder.Customer.Currency >= totalPrice)
        //    {
        //        newOrder.Customer.Currency -= totalPrice;
        //    }
        //    else
        //    {
        //        throw new Exception("Failed to complete payment");
        //    }
        //}

        //private void CheckStock(Order newOrder)
        //{
        //    if (_ctx.Products.Find(newOrder.Items.).Stock >= item.Quantity)
        //    {
        //        foreach (var item in newOrder.Items)
        //        {
        //            _ctx.Products.Find(item.Product.Id).Stock--;
        //        }
        //    {
                
                    
        //        }
        //        else
        //        {
        //            throw new Exception("Not enough items in stock");
        //        }
        //    }
        //}

        //private void CheckStock(Order newOrder)
        //{
        //    foreach (var item in newOrder.Items)
        //    {
        //        if (_ctx.Products.Find(item.Product.Id).Stock >= item.Quantity)
        //        {
        //            _ctx.Products.Find(item.Product.Id).Stock -= item.Quantity;
        //        }
        //        else
        //        {
        //            throw new Exception("Not enough items in stock");
        //        }
        //    }
        //}
    }
}
