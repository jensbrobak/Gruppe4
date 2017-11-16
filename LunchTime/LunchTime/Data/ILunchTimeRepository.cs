using System.Collections.Generic;
using LunchTime.Data.Entities;

namespace LunchTime.Data
{
    public interface ILunchTimeRepository
    {
        IEnumerable<Product> GetAllProducts();
        //IEnumerable<Product> GetProductsByCatagory(string catagory);
        //bool SaveAll();
    }
}