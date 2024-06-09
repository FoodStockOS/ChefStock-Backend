using chefstock_platform.InventoryManagement.Domain.Model.Commands;
using chefstock_platform.InventoryManagement.Domain.Repositories;
using chefstock_platform.InventoryManagement.Domain.Services;
using chefstock_platform.Shared.Domain.Repositories;
using chefstock_platform.InventoryManagement.Domain.Model.Entities;

namespace chefstock_platform.InventoryManagement.Application.Internal.CommandServices;

public class SupplierCommandService(ISupplierRepository supplierRepository, IUnitOfWork unitOfWork)
    : ISupplierCommandService
{
    public async Task<Supplier?> Handle(CreateSupplierCommand command)
    {
        var supplier = new Supplier(command);
        try
        {
            await supplierRepository.AddAsync(supplier);
            await unitOfWork.CompleteAsync();
            return supplier;
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while creating the supplier: {e.Message}");
            throw;
        }
    }

    public async Task<Supplier?> Handle(UpdateSupplierCommand command)
    {
        var supplier = await supplierRepository.GetByIdAsync(command.Id);
        if (supplier != null)
        {
            supplier.Update(command);
            await supplierRepository.UpdateAsync(supplier);
            await unitOfWork.CompleteAsync();
            return supplier;
        }
        else
        {
            Console.WriteLine($"Supplier with id {command.Id} not found");
            throw new Exception($"Supplier with id {command.Id} not found");
        }
    }

    public async Task Handle(DeleteSupplierCommand command)
    {
        var supplier = await supplierRepository.GetByIdAsync(command.Id);
        if (supplier != null)
        {
            await supplierRepository.DeleteAsync(supplier.Id);
            await unitOfWork.CompleteAsync();
        }
        else
        {
            Console.WriteLine($"Supplier with id {command.Id} not found");
            throw new Exception($"Supplier with id {command.Id} not found");
        }
    }
}