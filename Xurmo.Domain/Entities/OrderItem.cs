using Xurmo.Domain.Commons;

namespace Xurmo.Domain.Entities;

public class OrderItem : Auditable
{
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
    public long OrderId { get; set; }
    public Order Order { get; set; }
    public long ProductId { get; set; }
    public Product Product { get; set; }
}
