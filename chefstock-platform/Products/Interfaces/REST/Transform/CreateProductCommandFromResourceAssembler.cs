using chefstock_platform.Products.Domain.Model.Commands;
using chefstock_platform.Products.Interfaces.REST.Resources;

namespace chefstock_platform.Products.Interfaces.REST.Transform;

public static class CreateProductCommandFromResourceAssembler
{
    public static CreateProductCommand ToCommandFromResource(CreateProductResource resource)
    {
        return new CreateProductCommand(resource.Name, resource.Stock, resource.Price, resource.DueDate);
    }
}