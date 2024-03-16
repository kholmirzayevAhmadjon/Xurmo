using Microsoft.EntityFrameworkCore;
using Xurmo.Domain.Configuration;
using Xurmo.Domain.Entities;

namespace Xurmo.Data.AddDbContext;

#pragma warning disable TI4106 // Use XML tags for documenting types and members
public  class XurmoDbContext : DbContext
#pragma warning restore TI4106 // Use XML tags for documenting types and members
{
    public DbSet<Category> categories { get; set; }
    public DbSet<Product> products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Constants.XURMO_DB);
    }
}
