using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Wcf.Entities;

namespace Wcf.Services
{
    [ServiceContract]
    public interface IWcfService
    {
        [OperationContract]
        List<Order> GetOrders(Guid id);

        //[OperationContract]
        //List<Customer> GetCustomers();

        [OperationContract]
        Customer GetCustomer(Guid id);

        [OperationContract]
        void CloseOrder(int id);
    }
}
