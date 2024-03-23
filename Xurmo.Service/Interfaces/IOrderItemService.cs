using Xurmo.Models.OrderItems;

namespace Xurmo.Service.Interfaces;

public interface IOrderItemService
{
    Task<OrderItemViewModel> CreateAsync(OrderItemCreateModel model);
    Task<OrderItemViewModel> UpdateAsync(long id, OrderItemUpdateModel model);
    Task<bool> DeleteAsync(long id);
    Task<OrderItemViewModel> GetByIdAsync(long id);
    Task<IEnumerable<OrderItemViewModel>> GetAllAsync();
}
