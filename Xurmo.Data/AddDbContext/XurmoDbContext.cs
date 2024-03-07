using Microsoft.EntityFrameworkCore;
using Xurmo.Domain.Categories;
using Xurmo.Domain.Configuration;
using Xurmo.Domain.Products;

namespace Xurmo.Data.AddDbContext;

public  class XurmoDbContext : DbContext
{
    public DbSet<Category> categories { get; set; }
    public DbSet<Product> products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Constants.XURMO_DB);
    }
}
