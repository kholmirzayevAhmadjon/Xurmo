using Xurmo.Domain.Commons;


namespace Xurmo.Domain.Entities;

public class Product : Auditable
{
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public long CadegoryId { get; set; }

    public Category Categories { get; set; }
}
