using Microsoft.EntityFrameworkCore;
using Xurmo.Data.IRepostories;
using Xurmo.Domain.Entities;
using Xurmo.Models.Categories;
using Xurmo.Service.Extentions;
using Xurmo.Service.Interfaces;

namespace Xurmo.Service.Services;

public class CategoryService : ICategoryService
{
    private readonly IRepository<Category> repository;

    public CategoryService(IRepository<Category> repository)
    {
        this.repository = repository;
    }
    public async Task<CategoryViewModel> CreateAsync(CategoryCreateModel model)
    {
        var existCategory = await repository.SelectAllAsQueryable().FirstOrDefaultAsync(c => c.Name == model.Name);

        if(existCategory != null)
        {
            if(existCategory.IsDeleted)
              return  await UpdateAsync(existCategory.Id, model.MapTo<CategoryUpdateModel>());

            throw new Exception("This category is allredy exist ");
        };

        var category = await repository.InsertAsync(model.MapTo<Category>());
        await repository.SavedAsync();
        return category.MapTo<CategoryViewModel>();
        
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var existCategory = await repository.SelectByIddAsync(id)
             ?? throw new Exception($"This category is not found Id = {id}");

        existCategory.IsDeleted = true;
        existCategory.DeletedAt = DateTime.UtcNow;
        await repository.DeleteAsync(existCategory);
        await repository.SavedAsync();
        return true;    
    }

    public Task<IEnumerable<CategoryViewModel>> GetAllAsync()
        => Task.FromResult(repository.SelectAllAsEnumerable().Where(c => !c.IsDeleted).MapTo<CategoryViewModel>());

    public async Task<CategoryViewModel> GetByIdAsync(long id)
    {
        var existCategory = await repository.SelectByIddAsync(id)
            ?? throw new Exception($"This category is not found Id = {id}");

        return existCategory.MapTo<CategoryViewModel>();        
    }

    public async Task<CategoryViewModel> UpdateAsync(long id, CategoryUpdateModel model, bool isDelete = false)
    {
        var existCategory = repository.SelectAllAsQueryable().FirstOrDefault(c => c.Id == id)
            ?? throw new Exception("This uuser is not found");



        if(!isDelete)
        {
            existCategory.IsDeleted = false;
        }

        existCategory.Name = model.Name;
        existCategory.UpdatedAt = DateTime.UtcNow;
        existCategory.Id = id;
        await repository.UpdateAsync(existCategory);
        await repository.SavedAsync();
        return existCategory.MapTo<CategoryViewModel>();
    }
}
