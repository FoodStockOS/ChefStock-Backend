using chefstock_platform.Products.Domain.Model.Aggregates;
using chefstock_platform.Products.Domain.Model.Commands;
using chefstock_platform.Products.Domain.Model.Queries;
using chefstock_platform.Products.Domain.Services;

namespace chefstock_platform.Products.Interfaces.ACL.Services;

public class ProductsContextFacade(
    IProductCommandService productCommandService,
    IProductQueryService productQueryService)
    : IProductsContextFacade
{
    public async Task<int> CreateProduct(string name, int stock, decimal price, DateTime dueDate)
    {
        var createProductCommand = new CreateProductCommand(name, stock, price, dueDate);
        var product = await productCommandService.Handle(createProductCommand);
        return product?.Id ?? 0;
    }

    public async Task<Product?> FetchProductById(int id)
    {
        var getProductByIdQuery = new GetProductByIdQuery(id);
        return await productQueryService.Handle(getProductByIdQuery);
    }

    public async Task<IEnumerable<Product>> FetchAllProducts()
    {
        var getAllProductsQuery = new GetAllProductsQuery();
        return await productQueryService.Handle(getAllProductsQuery);
    }

    public async Task UpdateProduct(int id, string name, int stock, decimal price, DateTime dueDate)
    {
        var updateProductCommand = new UpdateProductCommand(id, name, stock, price, dueDate);
        await productCommandService.Handle(updateProductCommand);
    }

    public async Task DeleteProduct(int id)
    {
        var deleteProductCommand = new DeleteProductCommand(id);
        await productCommandService.Handle(deleteProductCommand);
    }
}