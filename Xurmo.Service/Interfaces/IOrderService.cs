using Xurmo.Models.Orders;

namespace Xurmo.Service.Interfaces;

public interface IOrderService
{
    Task<OrderViewModel> CreateAsync(OrderCreateModel model);
    Task<OrderViewModel> UpdateAsync(long id, OrderUpdateModel model);
    Task<bool> DeleteAsync(long id);
    Task<OrderViewModel> GetByIdAsync(long id);
    Task<IEnumerable<OrderViewModel>> GetAllAsync();
}
