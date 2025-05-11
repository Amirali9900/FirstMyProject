using Microsoft.EntityFrameworkCore;

namespace FirstMyProject.Models
{
    public class CakeShopDbContext : DbContext
    {
        public CakeShopDbContext(DbContextOptions<CakeShopDbContext> options) : base(options)
        {

        }

        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> shoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
