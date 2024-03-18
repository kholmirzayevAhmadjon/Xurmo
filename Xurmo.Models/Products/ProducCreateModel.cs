namespace Xurmo.Models.Products;

public class ProducCreateModel
{
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public long CadegoryId { get; set; }
}
