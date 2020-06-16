  using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yummy_tummy.Models
{
    [Table("OrderItems")]
    public class OrderItem
    {
       public int OrderItemId { get; set; }
       
       [Required]
       [StringLength(255)]
       public string ItemName { get; set; } 

        [Required]
        public double Price { get; set; }
         [Required]
       public int NumberOfOrders { get; set; }
         [Required]
        public int ItemId { get; set; }

        public int OrderId{get;set;}
    }
}

