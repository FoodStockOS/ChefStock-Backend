namespace chefstock_platform.InventoryManagement.Domain.Model.Commands;

public record UpdateSupplierCommand(int Id, string SupplierName, string ContactName, string ContactEmail, string Phone, string Address);
