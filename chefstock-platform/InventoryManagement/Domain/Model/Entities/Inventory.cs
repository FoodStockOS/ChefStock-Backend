using chefstock_platform.InventoryManagement.Domain.Model.Aggregates;

namespace chefstock_platform.InventoryManagement.Domain.Model.Entities;

public class Inventory
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
}