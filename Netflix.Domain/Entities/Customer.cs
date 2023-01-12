using Netflix.Domain.ValueObjects;
using Netflix.Shared.Entities;

namespace Netflix.Domain.Entities;

public class Customer : Entity
{
    public Customer(Name name, Document document, Email email, Password password, Subscription subscription, string country)
    {
        Name = name;
        Document = document;
        Email = email;
        Password = password;
        Subscription = subscription;
        Country = country;
    }
    public Name Name { get; private set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }
    public Subscription Subscription { get; private set; }
    public string Country { get; private set; }
}
