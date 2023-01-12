using Netflix.Domain.Enums;
using Netflix.Shared.Entities;


namespace Netflix.Domain.Entities;
public class Movie : Entity
{
    public Movie(string title, string description, string url, short ageRating, Cast cast, Studio studio, Category category, ELanguageType language, DateTime createDate)
    {
        Title = title;
        Description = description;
        AgeRating = ageRating;
        Cast = cast;
        Studio = studio;
        Category = category;
        Language = language;
        CreateDate = createDate;
    }

    public string Title { get; private set; }
    public string Description { get; private set; }
    public short AgeRating { get; private set; }
    public Cast Cast { get; private set; }
    public Studio Studio { get; private set; }
    public Category Category { get; private set; }
    public ELanguageType Language { get; private set; }
    public DateTime CreateDate { get; private set; }

}