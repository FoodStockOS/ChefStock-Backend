using chefstock_platform.Products.Domain.Model.Aggregates;
using chefstock_platform.Products.Domain.Model.Queries;

namespace chefstock_platform.Products.Domain.Services;

public interface IProductQueryService
{
    Task<IEnumerable<Product>> Handle(GetAllProductsQuery query);
    Task<Product?> Handle(GetProductByIdQuery query);
}