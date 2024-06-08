using chefstock_platform.Profiles.Domain.Model.Commands;
using chefstock_platform.Profiles.Domain.Model.ValueObjects;

namespace chefstock_platform.Profiles.Domain.Model.Aggregates;

public class Profile
{
    public Profile()
    {
        Username = new Username();
        EmailAddress = new EmailAddress();
        Password = new Password();
    }

    public Profile(string username, string emailAddress, string password)
    {
        Username = new Username(username);
        EmailAddress = new EmailAddress(emailAddress);
        Password = new Password(password);
    }

    public Profile(CreateProfileCommand command)
    {
        Username = new Username(command.Username);
        EmailAddress = new EmailAddress(command.EmailAddress);
        Password = new Password(command.Password);
    }

    public int Id { get; }
    public Username Username { get; private set; }
    public EmailAddress EmailAddress { get; private set; }
    public Password Password { get; private set; }
}