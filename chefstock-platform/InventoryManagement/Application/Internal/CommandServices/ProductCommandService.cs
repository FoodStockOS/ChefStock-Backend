using chefstock_platform.InventoryManagement.Domain.Model.Aggregates;
using chefstock_platform.InventoryManagement.Domain.Model.Commands;
using chefstock_platform.InventoryManagement.Domain.Repositories;
using chefstock_platform.InventoryManagement.Domain.Services;
using chefstock_platform.Shared.Domain.Repositories;

namespace chefstock_platform.InventoryManagement.Application.Internal.CommandServices;

    public class ProductCommandService(IProductRepository productRepository, IUnitOfWork unitOfWork) : IProductCommandService
    {
        public async Task<Product?> Handle(CreateProductCommand command)
        {
            var product = new Product(command);
            try
            {
                await productRepository.AddAsync(product);
                await unitOfWork.CompleteAsync();
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while creating the product: {e.Message}");
                throw;
            }
        }

        public async Task<Product?> Handle(UpdateProductCommand command)
        {
            var product = await productRepository.GetByIdAsync(command.Id);
            if (product != null)
            {
                product.Update(command);
                await productRepository.UpdateAsync(product);
                await unitOfWork.CompleteAsync();
                return product;
            }
            else
            {
                Console.WriteLine($"Product with id {command.Id} not found");
                throw new Exception($"Product with id {command.Id} not found");
            }
        }

        public async Task Handle(DeleteProductCommand command)
        {
            var product = await productRepository.GetByIdAsync(command.Id);
            if (product != null)
            {
                await productRepository.DeleteAsync(product.Id);
                await unitOfWork.CompleteAsync();
            }
            else
            {
                Console.WriteLine($"Product with id {command.Id} not found");
                throw new Exception($"Product with id {command.Id} not found");
            }
        }
    }