using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public class ShoppingContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TicaretDb;Trusted_Connection=true");
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}   