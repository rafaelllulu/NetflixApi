using Netflix.Shared.Entities;

namespace Netflix.Domain.Entites;
public class Genre : Entity
{
    public Genre(string title, string slug)
    {
        Title = title;
        Slug = slug;
    }
    public string Title { get; private set; }
    public string Slug { get; private set; }
}