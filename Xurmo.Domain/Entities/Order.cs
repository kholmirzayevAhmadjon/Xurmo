using Xurmo.Domain.Commons;

namespace Xurmo.Domain.Entities;

public class Order : Auditable
{
    public decimal TotalAmount { get; set; }
    public long User_id { get; set; }
    public User User { get; set; }

    public List<OrderItem> OrderItems { get; set; }
}
