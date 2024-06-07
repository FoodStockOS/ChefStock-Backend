using chefstock_platform.Products.Domain.Model.Aggregates;
using chefstock_platform.Products.Domain.Model.Commands;

namespace chefstock_platform.Products.Domain.Services;

public interface IProductCommandService
{
    Task<Product?> Handle(CreateProductCommand command);
    Task<Product?> Handle(UpdateProductCommand command);
    Task Handle(DeleteProductCommand command);
}