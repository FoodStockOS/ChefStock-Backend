using chefstock_platform.Products.Domain.Model.Aggregates;
using chefstock_platform.Shared.Domain.Repositories;

namespace chefstock_platform.Products.Domain.Repositories;

public interface IProductRepository : IBaseRepository<Product>
{
    Task<Product?> GetByIdAsync(int id);
    Task UpdateAsync(Product product);
    Task DeleteAsync(int id);
}