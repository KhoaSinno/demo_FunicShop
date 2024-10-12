using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FunicShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giá không được để trống")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá là số")]
        public double Price { get; set; }

        [Required]
        public string? Unit { get; set; }

        [Required]
        public string? Material { get; set; }
        
        [Required]
        public string? Dimension { get; set; }
        
        public string? Standard { get; set; }
        
        [Required]
        public string? Color { get; set; }

        public string? Type { get; set; }

        public string? Brand { get; set; }

        [Required]
        public string? WarrantyPeriod { get; set; }

        public string? Description { get; set; }

        [Required]
        public bool Active { get; set; }

        public virtual ICollection<string>? Images { get; set; }

        // Khóa ngoại Category
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
