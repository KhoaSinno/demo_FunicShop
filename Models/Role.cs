using System.ComponentModel.DataAnnotations;

namespace FunicShop.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên quyền không được để trống")]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<User>? Users { get; set; }
    }
}
