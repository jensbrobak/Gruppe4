using System;
using System.Runtime.Serialization;

namespace LT.WCF.Entities
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public string OrderNumber { get; set; }
        [DataMember]
        public string CustomerId { get; set; }
        [DataMember]
        public string OrderStatus { get; set; }
    }
}
