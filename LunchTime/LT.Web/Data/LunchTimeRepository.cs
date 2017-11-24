using System;
using System.Collections.Generic;
using System.Linq;
using LT.Web.Data.Entities;
using Microsoft.Extensions.Logging;

namespace LT.Web.Data
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
            //TODO try/catch
            return _ctx.SaveChanges() > 0;
        }
    }
}
