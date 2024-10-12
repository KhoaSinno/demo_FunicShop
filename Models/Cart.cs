using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunicShop.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Tổng tiền phải là số và không được để trống")]
        public double TotalPrice { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Số lượng phải là số và không được để trống")]
        public double totalQuantity { get; set; }
        
        public virtual ICollection<CartItem> CartItems { get; set; }

        // Khóa ngoại Customer (User)
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual User Customer { get; set; }
    }
}
