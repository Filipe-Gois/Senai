using Microsoft.EntityFrameworkCore;
using WebApiProductManager.Domains;

namespace WebApiProductManager.Contexts
{
    public class ProductManagerContext(DbContextOptions<ProductManagerContext> options) : DbContext(options)
    {
        public DbSet<Product> Product { get; set; }
    }
}
