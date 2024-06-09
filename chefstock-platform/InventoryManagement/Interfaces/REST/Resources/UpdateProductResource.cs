namespace chefstock_platform.Products.Interfaces.REST.Resources;

public record UpdateProductResource(int Id, string Name, int Stock, decimal Price, DateTime DueDate);
