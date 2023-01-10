using Netflix.Domain.Enums;
using Netflix.Shared.Entities;


namespace Netflix.Domain.Entites;
public class Video : Entity
{
    public Video(string title, string description, string url, short ageRating, Cast cast, Genre genre, EVideoLanguage language, EVideoType type)
    {
        Title = title;
        Description = description;
        Url = url;
        AgeRating = ageRating;
        Cast = cast;
        Genre = genre;
        Language = language;
        Type = type;
    }

    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Url { get; private set; }
    public short AgeRating { get; private set; }
    public DateTime RealeseDate { get; private set; }
    public Cast Cast { get; private set; }
    public Genre Genre { get; private set; }
    public EVideoLanguage Language { get; private set; }
    public EVideoType Type { get; private set; }

}