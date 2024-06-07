using chefstock_platform.Products.Domain.Model.Aggregates;
using chefstock_platform.Products.Domain.Model.Queries;
using chefstock_platform.Products.Domain.Repositories;
using chefstock_platform.Products.Domain.Services;

namespace chefstock_platform.Products.Application.Internal.QueryServices;

public class ProductQueryService(IProductRepository productRepository) : IProductQueryService
{
    
    public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery query)
    {
        return await productRepository.ListAsync();
    }

    public async Task<Product?> Handle(GetProductByIdQuery query)
    {
        return await productRepository.FindByIdAsync(query.Id);
    }
}