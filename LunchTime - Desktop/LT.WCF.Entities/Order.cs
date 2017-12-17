using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LT.WCF.Entities
{
    // Vi markere klassen med typen data contract således at vi indikere at WCF klienten og hosten kan kommunikere med denne og sine medlemmer
    [DataContract]
    public class Order
    {
        // Vi markere med typen data member således at vi indikere hvad metoder vi vil have med som skal indgå som medlemmer i datakontrakten
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public string OrderNumber { get; set; }
        [DataMember]
        public ICollection<OrderItem> Items { get; set; }
        [DataMember]
        public string CustomerId { get; set; }
        [DataMember]
        public string OrderStatus { get; set; }
    }
}
