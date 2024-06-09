namespace chefstock_platform.UserManagement.Interfaces.REST.Resources;

public record UpdateTransactionResource(int Id, int UserId, int ProductId, string TransactionType, DateTime TransactionDate, int Quantity);