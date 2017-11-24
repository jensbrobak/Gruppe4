using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LT.WCF.Entities
{
    [DataContract]
   public class OrderItem
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public Product Product { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public Order Order { get; set; }
    }
}
