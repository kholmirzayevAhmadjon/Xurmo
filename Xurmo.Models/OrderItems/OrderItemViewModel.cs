using Xurmo.Domain.Entities;

namespace Xurmo.Models.OrderItems;

public class OrderItemViewModel
{
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
    public Order Order { get; set; }
    public Product Product { get; set; }
}
