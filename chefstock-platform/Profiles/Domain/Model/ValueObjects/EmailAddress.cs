namespace chefstock_platform.Profiles.Domain.Model.ValueObjects;

public class EmailAddress(string Address)
{
    public EmailAddress(): this(string.Empty){}
}