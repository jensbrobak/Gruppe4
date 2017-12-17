using System.Collections.Generic;
using LunchTime.Data.Entities;
using LunchTime.ViewModels;

namespace LunchTime.Data
{
    public interface ILunchTimeRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Order> GetAllOrders(bool includeItems);
        IEnumerable<Order> GetAllOrdersByUser(string username, bool includeItems);
        Order GetOrderById(string username, int id);
        void AddOrder(Order newOrder);

        bool SaveAll();
        void AddEntity(object model);
        
    }
}