using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using LT.WCF.Data;
using LT.WCF.Entities;

namespace LT.WCF.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class WcfService : IWcfService, IDisposable
    {
        readonly WcfDbContext _context = new WcfDbContext();

        public List<Order> GetOrders(string id)
        {
            var oQuery = _context.Orders.Where(o => o.CustomerId == id);

            return oQuery.ToList();
        }

        public List<OrderItem> GetOrderItems(int id)
        {
            
            var oiQuery = _context.OrderItems.Where(oi => oi.OrderId == id);

            return oiQuery.ToList();
        }

        public List<Product> GetProducts(int id)
        {

            var pQuery = _context.Products.Where(p => p.Id == id);

            return pQuery.ToList();

        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void CloseOrder(int id)
        {
            var oQuery = _context.Orders.Where(o => o.Id == id);

            oQuery.First().OrderStatus = "afsluttet";

            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
