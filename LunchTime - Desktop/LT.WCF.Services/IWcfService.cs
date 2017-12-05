using System;
using System.Collections.Generic;
using System.ServiceModel;
using LT.WCF.Entities;

namespace LT.WCF.Services
{
    [ServiceContract]
    public interface IWcfService
    {
        [OperationContract]
        List<Order> GetOrders(string id);

        [OperationContract]
        List<OrderItem> GetOrderItems(int id);

        [OperationContract]
        List<Product> GetProducts(int id);

        [OperationContract]
        void CloseOrder(int id);
    }
}
