using MyEcommerce.Domain.Entities;
using System.Data.Entity;


namespace MyEcommerce.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
