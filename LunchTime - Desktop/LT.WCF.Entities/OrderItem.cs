using System.Runtime.Serialization;

namespace LT.WCF.Entities
{
    [DataContract]
    public class OrderItem
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int OrderId { get; set; }
    }
}
