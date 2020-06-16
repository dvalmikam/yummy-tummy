using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace yummy_tummy.Controllers.Resources
{
    public class OrderResource
    {
         public int OrderId { get; set; } 
    public double OrderTotal { get; set; }
    public ICollection<OrderItemResource> OrderItems { get; set; }

        public OrderResource()
        {
            OrderItems = new Collection<OrderItemResource>();
        }
    }
}