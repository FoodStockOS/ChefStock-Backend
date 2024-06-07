using chefstock_platform.Products.Domain.Model.Commands;
using chefstock_platform.Products.Interfaces.REST.Resources;

namespace chefstock_platform.Products.Interfaces.REST.Transform;

public class UpdateProductCommandFromResourceAssembler
{
    public static UpdateProductCommand ToCommandFromResource(UpdateProductResource resource)
    {
        return new UpdateProductCommand(resource.Id, resource.Name, resource.Stock, resource.Price, resource.DueDate);
    }
}