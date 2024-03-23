using Microsoft.EntityFrameworkCore;
using Xurmo.Domain.Entities;

namespace Xurmo.Data.AddDbContext;

public  class XurmoDbContext : DbContext
{
    public XurmoDbContext(DbContextOptions<XurmoDbContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .HasOne(order => order.User)
            .WithMany(user => user.Orders)
            .HasForeignKey(order => order.User_id);

        modelBuilder.Entity<OrderItem>()
            .HasOne(orderItem => orderItem.Order)
            .WithMany(order => order.OrderItems)
            .HasForeignKey(orderItem => orderItem.OrderId);

        modelBuilder.Entity<OrderItem>()
            .HasOne(orderItem => orderItem.Product)
            .WithMany()
            .HasForeignKey(orderItem => orderItem.ProductId);

        modelBuilder.Entity<Product>()
            .HasOne(product => product.Category)
            .WithMany()
            .HasForeignKey(product => product.CadegoryId);

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Fruits", CreatedAt = DateTime.UtcNow, IsDeleted = false, DeletedAt = null, UpdatedAt= null },
            new Category { Id = 2, Name = "DairyProducts", CreatedAt = DateTime.UtcNow, IsDeleted = false, DeletedAt = null, UpdatedAt= null },
            new Category { Id = 3, Name = "Sweets", CreatedAt = DateTime.UtcNow, IsDeleted = false, DeletedAt = null, UpdatedAt= null },
            new Category { Id = 4, Name = "MeatProducts", CreatedAt = DateTime.UtcNow, IsDeleted = false, DeletedAt = null, UpdatedAt= null }
            );

        modelBuilder.Entity<Product>().HasData(
            new Product {Id = 1, Name ="Apple", CadegoryId =1, Price = 12990, Description = "This is Apple", CreatedAt = DateTime.UtcNow, UpdatedAt = null, DeletedAt = null, IsDeleted = false},
            new Product {Id = 2, Name = "Fig", CadegoryId =1, Price = 32990, Description = "This is Fig", CreatedAt = DateTime.UtcNow, UpdatedAt = null, DeletedAt = null, IsDeleted = false},
            new Product {Id = 3, Name = "Pear", CadegoryId =1, Price = 19990, Description = "This is Pear", CreatedAt = DateTime.UtcNow, UpdatedAt = null, DeletedAt = null, IsDeleted = false},
            new Product {Id = 4, Name = "Carrot", CadegoryId =2, Price = 4990, Description = "This is Carrot", CreatedAt = DateTime.UtcNow, UpdatedAt = null, DeletedAt = null, IsDeleted = false},
            new Product {Id = 5, Name = "Potatoes", CadegoryId =2, Price = 6990, Description = "This is Potatoes", CreatedAt = DateTime.UtcNow, UpdatedAt = null, DeletedAt = null, IsDeleted = false},
            new Product {Id = 6, Name = "ChocolateNestle", CadegoryId =3, Price = 10990, Description = "This is Chocolate Nestle", CreatedAt = DateTime.UtcNow, UpdatedAt = null, DeletedAt = null, IsDeleted = false},
            new Product {Id = 7, Name = "Cake", CadegoryId =3, Price = 129990, Description = "This is Cace", CreatedAt = DateTime.UtcNow, UpdatedAt = null, DeletedAt = null, IsDeleted = false},
            new Product {Id = 8, Name = "Mutton", CadegoryId =4, Price = 100990, Description = "This is Mutton", CreatedAt = DateTime.UtcNow, UpdatedAt = null, DeletedAt = null, IsDeleted = false},
            new Product {Id = 9, Name = "Beef", CadegoryId =4, Price = 105990, Description = "This is Beef", CreatedAt = DateTime.UtcNow, UpdatedAt = null, DeletedAt = null, IsDeleted = false},
            new Product {Id = 10, Name = "Sausage", CadegoryId =4, Price = 72990, Description = "This is Sausage", CreatedAt = DateTime.UtcNow, UpdatedAt = null, DeletedAt = null, IsDeleted = false}
            );
    }

}
