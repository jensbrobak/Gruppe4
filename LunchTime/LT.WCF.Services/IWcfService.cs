using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using LT.WCF.Entities;

namespace LT.WCF.Services
{
    [ServiceContract]
    public interface IWcfService
    {
        [OperationContract]
        Customer GetCustomer(string id);

        [OperationContract]
        List<Order> GetOrders(string id);

        [OperationContract]
        void CloseOrder(int id);
    }
}
