using Netflix.Domain.Enums;
using Netflix.Shared.Entities;

namespace Netflix.Domain.Entities;

public class Language : Entity
{
    public Language(ELanguageType type)
    {
        Type = type;
    }

    public ELanguageType Type { get; private set; }
}