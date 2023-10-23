using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext()
        {
        }

        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-L55F4844\\SQLEXPRESS01;Initial Catalog=ShopingCart;User ID=sa;Password=123456;Encrypt=False");
        }

        public DbSet<Product> Products { get; set; }
        
        
    }
}
