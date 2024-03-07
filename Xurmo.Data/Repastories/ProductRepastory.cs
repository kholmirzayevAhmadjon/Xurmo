using Microsoft.EntityFrameworkCore;
using Xurmo.Data.AddDbContext;
using Xurmo.Data.IRepastories;
using Xurmo.Domain.Products;

namespace Xurmo.Data.Repastories;

public class ProductRepastory : IProductRepastory
{
    private readonly XurmoDbContext xurmoDbContext;
    public ProductRepastory(XurmoDbContext xurmoDbContext)
    {
        this.xurmoDbContext = xurmoDbContext;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var exisProduct = await xurmoDbContext.products.FirstAsync(x => x.Id == id);
        exisProduct.IsDeleted = true;
        exisProduct.DeletedAt = DateTime.UtcNow;
        await xurmoDbContext.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        var products = await xurmoDbContext.products.ToListAsync();
        return products;
    }

    public async Task<Product> InsertAsync(Product product)
    {
         var exisProduct = await xurmoDbContext.products.AddAsync(product);
         await xurmoDbContext.SaveChangesAsync();
         return exisProduct.Entity;
    }

    public async Task<Product> UpdateAsync(long id, Product product)
    {
        var exisProduct = await xurmoDbContext.products.FirstAsync(x => x.Id == id);

        exisProduct.Id = id;
        exisProduct.Name = product.Name;
        exisProduct.Description = product.Description;
        exisProduct.CadegoryId = product.CadegoryId;
        exisProduct.Price = product.Price;
        exisProduct.UpdatedAt = DateTime.UtcNow;
        exisProduct.IsDeleted = false;

        await xurmoDbContext.SaveChangesAsync();
        return exisProduct;
    }
}
