using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LT.WCF.Entities
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public int Stock { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}

