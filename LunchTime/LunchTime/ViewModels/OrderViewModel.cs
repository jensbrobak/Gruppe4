using LunchTime.Data;
using LunchTime.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchTime.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        //public Customer customer { get; set; } //not sure if this is correct way

        [Required]
        [MinLength(4)]
        public string OrderNumber { get; set; }

        public ICollection<OrderItemViewModel> Items { get; set; }

    }
}
