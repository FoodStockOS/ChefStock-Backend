using System.Text.RegularExpressions;

namespace chefstock_platform.UserManagement.Domain.Model.ValueObjects;

public record Email
{
    private static readonly Regex EmailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");

    public Email()
    {

    }

    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Email cannot be empty.", nameof(value));
        }

        if (!EmailRegex.IsMatch(value))
        {
            throw new ArgumentException("Invalid email format.", nameof(value));
        }

        Value = value;
    }

    public string Value { get; private set; } = null!;

    public override string ToString() => Value;
}