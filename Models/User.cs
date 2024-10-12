using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace FunicShop.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(100, ErrorMessage = "Tên không thể dài hơn 100 kí tự")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string? PhoneNumber { get; set; }

        public string? Address { get; set; }

        public string? Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        // Thuộc tính của SaleStaff và Manager
        public string? CitizenId { get; set; }

        [DataType(DataType.Date)]
        public DateTime? IssuingDate { get; set; }

        public string? IssuingPlace { get; set; }

        // Khóa ngoại Role
        [Required]
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        // Thuộc tính điều hướng tới Role
        public virtual Role? Role { get; set; }

        // Quan hệ ngược với Orders mà User là Customer
        [InverseProperty("Customer")]
        public virtual ICollection<Order>? Customers { get; set; }

        // Quan hệ ngược với Orders mà User là SaleStaff
        [InverseProperty("SaleStaff")]
        public virtual ICollection<Order>? SaleStaffOrders { get; set; }
    }
}
