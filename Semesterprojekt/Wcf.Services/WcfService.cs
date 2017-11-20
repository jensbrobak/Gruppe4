using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Wcf.Data;
using Wcf.Entities;

namespace Wcf.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class WcfService : IWcfService, IDisposable
    {
        readonly WcfDbContext _Context = new WcfDbContext();
       // public List<Customer> GetCustomers()
        //{
          //  return _Context.Customers.ToList();
        //}

        public Customer GetCustomer(Guid id)
        {
            return _Context.Customer.Find(id);
        }
        public List<Order> GetOrders(Guid id)
        {
            var oQuery = _Context.Orders.Where(o => o.CustomerId == id);

            return oQuery.ToList();
        }
        [OperationBehavior(TransactionScopeRequired = true)]
        public void CloseOrder(int id)
        {
            var oQuery = _Context.Orders.Where(o => o.Id == id);

            oQuery.First().OrderStatusId = '1';

            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }
    }
}
