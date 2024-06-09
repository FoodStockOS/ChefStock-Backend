using chefstock_platform.InventoryManagement.Domain.Model.Aggregates;
using chefstock_platform.Products.Interfaces.REST.Resources;

namespace chefstock_platform.Products.Interfaces.REST.Transform;

public static class ProductResourceFromEntityAssembler
{
    public static ProductResource ToResourceFromEntity(Product entity)
    {
        return new ProductResource(entity.Id, entity.Name, entity.Stock, entity.Price, entity.DueDate);
    }
}