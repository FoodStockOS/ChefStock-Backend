namespace chefstock_platform.Products.Domain.Model.Commands;

public record UpdateProductCommand(int Id, string Name, int Stock, decimal Price, DateTime DueDate);
