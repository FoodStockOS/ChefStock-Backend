using chefstock_platform.Products.Domain.Model.Aggregates;

namespace chefstock_platform.Products.Interfaces.ACL;

public interface IProductsContextFacade
{
    Task<int> CreateProduct(string name, int stock, decimal price, DateTime dueDate);
    Task<Product?> FetchProductById(int id);
    Task<IEnumerable<Product>> FetchAllProducts();
    Task UpdateProduct(int id, string name, int stock, decimal price, DateTime dueDate);
    Task DeleteProduct(int id);
}