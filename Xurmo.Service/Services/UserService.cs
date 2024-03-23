using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;
using Xurmo.Data.IRepastories;
using Xurmo.Domain.Entities;
using Xurmo.Models.Users;
using Xurmo.Service.Extentions;
using Xurmo.Service.Interfaces;

namespace Xurmo.Service.Services;

public class UserService : IUserServise
{
    private readonly IRepository<User> repository;

    public UserService(IRepository<User> repository)
    {
        this.repository = repository;
    }

    public async Task<UserViewModel> CreateAsync(UserCreateModel model)
    {
        var existUser = await repository.SelectAllAsQueryable().FirstOrDefaultAsync(u => u.Email == model.Email);
        if(existUser != null)
        {
            await UpdateAsync(existUser.Id, model.MapTo<UserUpdateModel>());
        }

        var user = await repository.InsertAsync(model.MapTo<User>());
        await repository.SavedAsync();
        return user.MapTo<UserViewModel>();
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var exisUser = await repository.SelectByIddAsync(id)
            ?? throw new Exception($"This user is not found ID = {id}");

        exisUser.IsDeleted = true;
        exisUser.DeletedAt = DateTime.UtcNow;
        await repository.DeleteAsync(exisUser);
        await repository.SavedAsync();
        return true;        
    }

    public async Task<IEnumerable<UserViewModel>> GetAll()
    {
        return repository.SelectAllAsEnumerable().Where(u => u.IsDeleted).MapTo<UserViewModel>();
    }

    public async Task<UserViewModel> GetByIdAsync(long id)
    {
        var exisUser = await repository.SelectByIddAsync(id)
            ?? throw new Exception($"This user is not found ID = {id}");

        return exisUser.MapTo<UserViewModel>();
    }

    public async Task<UserViewModel> UpdateAsync(long id, UserUpdateModel model)
    {
        var exisUser = await repository.SelectByIddAsync(id)
            ?? throw new Exception($"This user is not found ID = {id}");

        exisUser.IsDeleted = false;
        exisUser.FirstName = model.FirstName;
        exisUser.LastName = model.LastName;
        exisUser.Email = model.Email;
        exisUser.Password = model.Password;
        exisUser.Phone = model.Phone;
        exisUser.UpdatedAt = DateTime.UtcNow;

        await repository.UpdateAsync(exisUser);
        await repository.SavedAsync();
        return exisUser.MapTo<UserViewModel>();
    }

    public Task<UserViewModel> UserOrders(long id)
    {
        var exisUser = repository.SelectAllAsQueryable().Where(u => u.Id == id)
            .Include(u => u.Orders)
            .ThenInclude(o => o.OrderItems)
            .ToList();

        return (Task<UserViewModel>)exisUser.MapTo<UserViewModel>();
    }
}
