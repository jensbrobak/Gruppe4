using System;
using System.Collections.Generic;

namespace LT.Web.Data.Entities
{
  public class Order
  {
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public string OrderNumber { get; set; }
    public ICollection<OrderItem> Items { get; set; }
    //public Guid CustomerId { get; set; }

      public Customer Customer { get; set; }
      public string OrderStatus { get; set; }
  }
}
