using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
        public ICollection<OrderItem> Items { get; set; }
        [DataMember]
        public string CustomerId { get; set; }
        [DataMember]
        public string OrderStatus { get; set; }
    }
}
