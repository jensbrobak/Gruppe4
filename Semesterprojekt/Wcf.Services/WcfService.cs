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
        public List<Order> GetOrders()
        {
            return _Context.Orders.ToList();
        }
        [OperationBehavior(TransactionScopeRequired = true)]
        public void CloseOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
