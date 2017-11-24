using System;
using Microsoft.AspNetCore.Identity;

namespace LT.Web.Data.Entities
{
    public class Customer : IdentityUser
    {
        public string Name { get; set; }
        public double Currency { get; set; }
    }
}
