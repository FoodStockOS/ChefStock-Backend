namespace chefstock_platform.InventoryManagement.Interfaces.REST.Resources;

public record CreateProductResource(string Name, int Stock, decimal Price, string Description, DateTime DueDate, int CategoryId, int SupplierId);