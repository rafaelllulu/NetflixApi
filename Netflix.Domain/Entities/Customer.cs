using Netflix.Domain.ValueObjects;
using Netflix.Shared.Entities;

namespace Netflix.Domain.Entites;

public class Customer : Entity
{
    public Customer(Name name, Document document, Email email, Password password, string country)
    {
        Name = name;
        Document = document;
        Email = email;
        Password = password;
        Country = country;
    }
    public Name Name { get; private set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }
    public string Country { get; private set; }
}
