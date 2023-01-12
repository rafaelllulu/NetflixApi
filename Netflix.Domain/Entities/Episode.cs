using Netflix.Shared.Entities;

namespace Netflix.Domain.Entities;
public class Episode : Entity
{
    public Episode(DateTime duration, Season season, string title, int number)
    {
        Duration = duration;
        Season = season;
        Title = title;
        Number = number;
    }

    public DateTime Duration { get; private set; }
    public Season Season { get; private set; }
    public string Title { get; private set; }
    public int Number { get; private set; }
}