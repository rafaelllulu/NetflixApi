using Netflix.Shared.Entities;

namespace Netflix.Domain.Entities;

public class Studio : Entity
{
    public Studio(string title, string slug)
    {
        Title = title;
        Slug = slug;
    }
    public string Title { get; private set; }
    public string Slug { get; private set; }

}