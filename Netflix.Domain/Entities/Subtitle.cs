using Netflix.Shared.Entities;

namespace Netflix.Domain.Entities;

public class Subtitle : Entity
{
    public Subtitle(Language language, string text)
    {
        Language = language;
        Text = text;
    }

    public Language Language { get; }
    public string Text { get; private set; }
    
}