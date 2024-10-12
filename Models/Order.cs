using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunicShop.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public string? CustomerPhoneNumber { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Tổng tiền phải là số")]
        public double TotalPrice { get; set; }

        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        public int OrderStatus { get; set; } // Có thể dùng enum cho OrderStatus

        public string PaymentStatus { get; set; }

        public string PaymentMethod { get; set; }

        public string InvoiceNumber { get; set; }

        public DateTime InvoiceDate { get; set; }

        // Khóa ngoại Customer (User)
        public int? CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Customers")] // Tạo liên kết ngược từ User đến Orders (với vai trò là Customer)
        public virtual User? Customer { get; set; }

        // Khóa ngoại SaleStaff (User)
        public int? SaleStaffId { get; set; }

        [ForeignKey("SaleStaffId")]
        [InverseProperty("SaleStaffOrders")] // Đặt tên phù hợp hơn cho liên kết ngược
        public virtual User? SaleStaff { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
