using Xurmo.Domain.Categories;
using Xurmo.Domain.Products;

namespace Xurmo.Data.IRepastories;

public interface IProductRepastory
{
    Task<Product> InsertAsync(Product product);
    Task<Product> UpdateAsync(long id, Product product);
    Task<bool> DeleteAsync(long id);
    Task<IEnumerable<Product>> GetAllAsync();
}
