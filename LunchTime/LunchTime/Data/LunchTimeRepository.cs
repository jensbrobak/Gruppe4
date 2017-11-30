using LunchTime.Data.Entities;
using LunchTime.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    .Include(c => c.Customer) // shows all customer info - not sure if this is good
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
        public Order GetOrderById(int id)
        {
            return _ctx.Orders
                .Include(c => c.Customer) // shows all customer info - not sure if this is good
                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .Where(o => o.Id == id)
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
    }
}
