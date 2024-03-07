using Xurmo.Domain.Categories;

namespace Xurmo.Data.IRepastories;

public interface ICategoryRepastory
{
    Task<Category> InsertAsync(Category category);
    Task<Category> UpdateAsync(long id, Category category);
    Task<bool> DeleteAsync(long id);
    Task<IEnumerable<Category>> GetAllAsync();
}
