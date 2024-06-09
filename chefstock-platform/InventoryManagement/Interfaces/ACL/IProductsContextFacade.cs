using chefstock_platform.InventoryManagement.Domain.Model.Aggregates;

namespace chefstock_platform.InventoryManagement.Interfaces.ACL;

public interface IProductsContextFacade
{
    Task<int> CreateProduct(string name, int stock, decimal price, string description, DateTime dueDate, int categoryId, int supplierId);
    Task<Product?> FetchProductById(int id);
    Task<IEnumerable<Product>> FetchAllProducts();
    Task UpdateProduct(int id, string name, int stock, decimal price, string description, DateTime dueDate, int categoryId, int supplierId);
    Task DeleteProduct(int id);
}