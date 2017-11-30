using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using LT.WCF.Data;
using LT.WCF.Entities;

namespace LT.WCF.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class WcfService : IWcfService, IDisposable
    {
        readonly WcfDbContext _Context = new WcfDbContext();
        private List<OrderItem> oiOrderItems;

        public Customer GetCustomer(Guid id)
        {
            return _Context.Customers.Find(id);
        }
        public List<Order> GetOrders(string id)
        {
            var oQuery = _Context.Orders.Where(o => o.CustomerId == id);

          var doQuery = _Context.Orders.Find(id).Items.ToList();

           // var oQuery = _Context.Orders.Join(_Context.OrderItems, o => o.Id,
          //      oi => oi.Id,
        //        (o, oi) => new {Order = o, OrderItem = oi}).Select(x => x.Order);

           
                //.Join(_Context.OrderItems, oi => oi.Items);

            //var query = db.Categories         // source
            //    .Join(db.CategoryMaps,         // target
            //        c => c.CategoryId,          // FK
            //        cm => cm.ChildCategoryId,   // PK
            //        (c, cm) => new { Category = c, CategoryMaps = cm }) // project result
            //    .Select(x => x.Category);  // select result

            return oQuery.ToList();
        }

        public List<OrderItem> GetOrderItems(int id)
        {
           var oIQuery = _Context.OrderItems.Where(oi => oi.OrderId == id);

            oiOrderItems = oIQuery.ToList();

           // var oIQuery = _Context.OrderItems.Find(id).OrderId;
            
            // var pQuery = _Context.Products.Where();

            return oIQuery.ToList();
        }

        public List<Product> GetProducts(int id)
        {
            //var oiQuery = _Context.OrderItems.Where(oi => oi.OrderId == id);

           // oiOrderItems = oiQuery.ToList();

           // .Where(p => p.Id == id);

            var pQuery = _Context.Products; // define query
            foreach (var product in pQuery) // query executed and data obtained from database
            {
                if (product.Id == id)
                {
                    pQuery.Add(product);
                }
                var products = _Context.Products.ToList();
                return products;
            }


            return null;
        }


        [OperationBehavior(TransactionScopeRequired = true)]
        public void CloseOrder(int id)
        {
            var oQuery = _Context.Orders.Where(o => o.Id == id);

            oQuery.First().OrderStatus = "afsluttet";

            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
