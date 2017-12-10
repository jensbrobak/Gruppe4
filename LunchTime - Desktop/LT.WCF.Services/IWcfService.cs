using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using LT.WCF.Entities;

namespace LT.WCF.Services
{
    // Her markere vi interfacet med typen service contract således at vi danner en WCF service kontrakt
    [ServiceContract]
    public interface IWcfService
    {
        // Vi markere med operation contract for at indikere hvad metoder vi vil have med i service kontrakten
        [OperationContract]
        IQueryable<OrderAndOrderItemsAndProducts> GetOrders(string id);

        [OperationContract]
        void CloseOrder(int id);
    }
}
