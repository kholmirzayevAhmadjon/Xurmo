using Microsoft.EntityFrameworkCore;
using Xurmo.Domain.Configuration;
using Xurmo.Domain.Entities;

namespace Xurmo.Data.AddDbContext;

public  class XurmoDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(Constants.XURMO_DB);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .Property(u => u.Id)
            .HasColumnName("id")
            .HasColumnType("integer")
            .IsRequired();

        modelBuilder.Entity<User>()
            .Property(u => u.FirstName)
            .HasColumnName("first_name")
            .HasColumnType("varchar");

        modelBuilder.Entity<User>()
            .Property(u => u.LastName)
            .HasColumnName("last_name")
            .HasColumnType("varchar")
            .IsRequired();

        modelBuilder.Entity<User>()
            .Property(u => u.Email)
            .HasColumnName("email")
            .HasColumnType("varchar")
            .IsRequired();

    }
}
