namespace chefstock_platform.Products.Domain.Model.Commands;

public record CreateProductCommand(string? Name, int Stock, decimal Price, DateTime DueDate);
