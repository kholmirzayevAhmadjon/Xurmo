using Xurmo.Domain.Commons;

namespace Xurmo.Domain.Entities;

public class OrderItem : Auditable
{
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
}
