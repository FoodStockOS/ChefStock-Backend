namespace chefstock_platform.Products.Domain.Model.Aggregates;

public class Inventory
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
}