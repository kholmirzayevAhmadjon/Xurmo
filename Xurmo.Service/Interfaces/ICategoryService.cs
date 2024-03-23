using Xurmo.Models.Categories;

namespace Xurmo.Service.Interfaces;

public interface ICategoryService
{
    Task<CategoryViewModel> CreateAsync(CategoryCreateModel model);
    Task<CategoryViewModel> UpdateAsync(long id, CategoryUpdateModel model);
    Task<bool> DeleteAsync(long id);
    Task<CategoryViewModel> GetByIdAsync(long id);
    Task<IEnumerable<CategoryViewModel>> GetAllAsync();
}
