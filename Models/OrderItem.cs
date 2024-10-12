using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunicShop.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Giá phải là số")]
        public double PriceAtOrder { get; set; }

        [Required]
        public double Subtotal { get; set; } // Fix

        [Required]
        public int Quantity { get; set; }

        // Khóa ngoại Order
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }

        // Khóa ngoại Product
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
