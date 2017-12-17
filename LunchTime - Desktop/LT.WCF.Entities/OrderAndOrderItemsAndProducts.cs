using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LT.WCF.Entities
{
    // Vi markere klassen med typen data contract således at vi indikere at WCF klienten og hosten kan kommunikere med denne og sine medlemmer
    [DataContract]
    public class OrderAndOrderItemsAndProducts
    {
        // Vi markere med typen data member således at vi indikere hvad metoder vi vil have med som skal indgå som medlemmer i datakontrakten
        [DataMember]
        public DateTime OrdreDato { get; set; }

        [DataMember]
        public int OrdreId { get; set; }

        [DataMember]
        public string ProduktNavn { get; set; }

        [DataMember]
        public string ProduktBeskrivelse { get; set; }

        [DataMember]
        public int ProduktAntal { get; set; }

        [DataMember]
        public string OrdreStatus { get; set; }

    }
}
