using System.Collections.Generic;
using LT.Web.Data.Entities;

namespace LT.Web.Data
{
    public interface ILunchTimeRepository
    {
        IEnumerable<Product> GetAllProducts();
        //IEnumerable<Product> GetProductsByCatagory(string catagory);
        //Customer CustomerLoginAsync(string email, int password);
        bool SaveAll();
    }
}