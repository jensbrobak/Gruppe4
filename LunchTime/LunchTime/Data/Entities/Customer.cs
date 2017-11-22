using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchTime.Data.Entities
{
    public class Customer : IdentityUser
    {
        //public Customer()
        //{
         
        //}
        //public int Id { get; set; }
        public string Name { get; set; }
        //public string Email { get; set; }
        public int Password { get; set; }
        public double Currency { get; set; }
    }
}
