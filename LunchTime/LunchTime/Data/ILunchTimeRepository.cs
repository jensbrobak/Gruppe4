using System.Collections.Generic;
using LunchTime.Data.Entities;
using LunchTime.ViewModels;

namespace LunchTime.Data
{
    public interface ILunchTimeRepository
    {
        IEnumerable<Product> GetAllProducts();
        //IEnumerable<Product> GetProductsByCatagory(string catagory);
        //Customer CustomerLoginAsync(string email, int password);
        bool SaveAll();
    }
}