using System;
using System.Collections.Generic;
using System.Data.Common;
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

        public Customer GetCustomer(string id)
        {
            return _Context.Customers.Find(id);
        }
        public List<Order> GetOrders(string id)
        {
            var oQuery = _Context.Orders.Where(o => o.CustomerId == id);

            return oQuery.ToList();
        }
        [OperationBehavior(TransactionScopeRequired = true)]
        public void CloseOrder(int id)
        {
            var oQuery = _Context.Orders.Where(o => o.Id == id);

            oQuery.First().OrderStatus = "Afsluttet";

            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
