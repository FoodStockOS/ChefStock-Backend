namespace chefstock_platform.Profiles.Domain.Model.ValueObjects;

public class Password(string Password)
{
    public Password(): this(string.Empty){}
}