using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectModels;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
