using Xurmo.Models.Products;

namespace Xurmo.Service.Interfaces;

public interface IPoductService
{
    Task<ProductViewModel> CreateAsync(ProductCreateModel model);
    Task<ProductViewModel> UpdateAsync(long id, ProductUpdateModel model);
    Task<bool> DeleteAsync(long id);
    Task<ProductViewModel> GetByIdAsync(long id);
    Task<IEnumerable<ProductViewModel>> GetAllAsync();
}
