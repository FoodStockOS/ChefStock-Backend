namespace chefstock_platform.RestaurantManagement.Interfaces.REST.Resources;

public record EmployeeResource(int Id, string? FirstName, string? LastName, string? Email, string? Phone, string? Position, int RestaurantId);