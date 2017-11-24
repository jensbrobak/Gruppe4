using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LT.WCF.Entities
{
    [DataContract]
    public class Customer 
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Currency { get; set; }
    }
}
