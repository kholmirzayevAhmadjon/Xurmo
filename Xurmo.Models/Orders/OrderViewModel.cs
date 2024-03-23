using Xurmo.Domain.Entities;

namespace Xurmo.Models.Orders;

public class OrderViewModel
{
    public long Id { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderItem OrderItem { get; set; }
}
