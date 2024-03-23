using Xurmo.Models.Users;

namespace Xurmo.Service.Interfaces;

public interface IUserServise
{
    Task<UserViewModel> CreateAsync(UserCreateModel model);
    Task<UserViewModel> UpdateAsync(long id, UserUpdateModel model);
    Task<bool> DeleteAsync(long id);
    Task<UserViewModel> GetByIdAsync(long id);
    Task<IEnumerable<UserViewModel>> GetAllAsync();
}
