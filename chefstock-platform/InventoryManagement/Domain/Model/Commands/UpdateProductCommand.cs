namespace chefstock_platform.InventoryManagement.Domain.Model.Commands;

public record UpdateProductCommand(int Id, string? Name, int Stock, decimal Price,string Description ,DateTime DueDate,int CategoryId, int SupplierId);
