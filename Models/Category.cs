using System.ComponentModel.DataAnnotations;

namespace FunicShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên danh mục là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tên danh mục không được vượt quá 100 ký tự.")]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        // Một Category có nhiều Products
        public List<Product>? Products { get; set; }
    }
}
