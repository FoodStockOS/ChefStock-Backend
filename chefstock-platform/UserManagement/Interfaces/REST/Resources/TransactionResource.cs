﻿namespace chefstock_platform.UserManagement.Interfaces.REST.Resources;

public record TransactionResource(int TransactionId, int UserId, int ProductId, string? TransactionType, DateTime TransactionDate, int Quantity);