﻿namespace Xurmo.Models.OrderItems;

public class OrderItemCreateModel
{
    public int Quantity { get; set; }
    public decimal Amount { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
}
