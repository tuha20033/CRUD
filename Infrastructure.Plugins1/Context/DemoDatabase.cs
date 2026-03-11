using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Plugins1.Context;

public class DemoDatabase : DbContext
{
    public DemoDatabase(DbContextOptions<DemoDatabase> options) : base(options)
    {
    }
    public DbSet<CoreBusiness.Inventory> Inventories { get; set; }
    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
       base.OnModelCreating(modelBuilder);

    }
}
