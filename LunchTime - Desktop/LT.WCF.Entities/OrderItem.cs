using System.Runtime.Serialization;

namespace LT.WCF.Entities
{
    // Vi markere klassen med typen data contract således at vi indikere at WCF klienten og hosten kan kommunikere med denne og sine medlemmer
    [DataContract]
    public class OrderItem
    {
        // Vi markere med typen data member således at vi indikere hvad metoder vi vil have med som skal indgå som medlemmer i datakontrakten
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
