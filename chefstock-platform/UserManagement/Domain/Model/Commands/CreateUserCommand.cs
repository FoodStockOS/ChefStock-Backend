using chefstock_platform.UserManagement.Domain.Model.ValueObjects;

namespace chefstock_platform.UserManagement.Domain.Model.Commands;

public record CreateUserCommand(string FirstName, string LastName, string Email, string Password, string Phone, string Address, int RoleId);