using Microsoft.EntityFrameworkCore;
using Xurmo.Data.AddDbContext;
using Xurmo.Data.IRepastories;
using Xurmo.Domain.Categories;

namespace Xurmo.Data.Repastories;

public class CategoryRepastory : ICategoryRepastory
{
    private readonly XurmoDbContext xurmoDbContext;
    public CategoryRepastory(XurmoDbContext xurmoDbContext)
    {
        this.xurmoDbContext = xurmoDbContext;   
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var exisCategory = await xurmoDbContext.categories.FirstAsync(c => c.Id == id && !c.IsDeleted);
        exisCategory.IsDeleted = true;
        exisCategory.DeletedAt = DateTime.UtcNow;
        await xurmoDbContext.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Category>> GetAllAsync()
    {
        var categories = await xurmoDbContext.categories.ToListAsync();
        return categories;
    }

    public async Task<Category> InsertAsync(Category category)
    {
        var exisCategory = await xurmoDbContext.categories.AddAsync(category);
        await xurmoDbContext.SaveChangesAsync();
        return exisCategory.Entity;
    }

    public async Task<Category> UpdateAsync(long id, Category category)
    {
        var exisCategory = await xurmoDbContext.categories.FirstAsync(c => c.Id == id);

        exisCategory.Id = id;
        exisCategory.Name = category.Name;
        exisCategory.UpdatedAt = DateTime.UtcNow;
        exisCategory.IsDeleted = false;

        await xurmoDbContext.SaveChangesAsync();
        return exisCategory;
    }
}
