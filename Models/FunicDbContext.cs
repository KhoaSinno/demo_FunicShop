using Microsoft.EntityFrameworkCore;

namespace FunicShop.Models
{
    public class FunicDbContext : DbContext
    {
        public FunicDbContext(DbContextOptions<FunicDbContext> options)
       : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


    }
}
