using Netflix.Domain.ValueObjects;
using Netflix.Shared.Entities;

namespace Netflix.Domain.Entities;

public class Actor : Entity
{
    public Actor(Name name, string image, int age)
    {
        Name = name;
        Image = image;
        Age = age;
    }


    public Name Name { get; private set; }
    public string Image { get; private set; }
    public int Age { get; private set; }
}