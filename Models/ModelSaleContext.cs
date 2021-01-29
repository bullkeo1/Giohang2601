using Microsoft.EntityFrameworkCore;

namespace Giohang2601.Models
{
    public class ModelSaleContext :DbContext
    {
        public ModelSaleContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Orders>Orders { get; set; }
    }
}