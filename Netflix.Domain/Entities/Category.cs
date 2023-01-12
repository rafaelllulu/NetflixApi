using Netflix.Domain.Enums;
using Netflix.Shared.Entities;
namespace Netflix.Domain.Entities;

public class Category : Entity
{
    public Category(ECategoryType type, string slug)
    {
        Type = type;
        Slug = slug;
    }

    public ECategoryType Type { get; private set; }
    public string Slug { get; private set; }

}