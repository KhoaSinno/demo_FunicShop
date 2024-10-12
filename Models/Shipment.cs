using NuGet.Packaging.Signing;
using System.ComponentModel.DataAnnotations;

namespace FunicShop.Models
{
    public class Shipment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ngày nhập không được để trống")]
        [DataType(DataType.Date)]
        public DateTime ReceiptDate { get; set; }

        [Required(ErrorMessage = "Tổng giá không được để trống")]
        [Range(0, double.MaxValue, ErrorMessage = "Tổng giá phải là số")]
        public double TotalPrice { get; set; }

        [Required(ErrorMessage = "Tổng số lượng không được để trống")]
        [Range(0, double.MaxValue, ErrorMessage = "Tổng số lượng phải là số")]
        public int TotalQuantity { get; set; }

        public string? Note { get; set; }

        // Quan hệ với Supplier
        public int SupplierId { get; set; }
        public virtual Supplier? Supplier { get; set; }

        // Quan hệ với Manager (User)
        public int ManagerId { get; set; }
        public virtual User? Manager { get; set; }

        // Quan hệ với Goods và Product
        public virtual ICollection<Goods> Goods { get; set; }
    }
}
