using Microsoft.EntityFrameworkCore;

namespace FurnitureShop.Models.Context;

public class ShopDbContext(IConfiguration configuration) : DbContext
{
    private readonly IConfiguration _configuration = configuration;

    public DbSet<Furniture> Furniture => Set<Furniture>();
    public DbSet<Order> Orders => Set<Order>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_configuration.GetConnectionString("ShopDB"));
    }
}
