using Netflix.Shared.Entities;

namespace Netflix.Domain.Entities;
public class Season : Entity
{
    public Season(Series series, DateTime createDate, int number)
    {
        Series = series;
        CreateDate = createDate;
        Number = number;
    }

    public Series Series { get; private set; }
    public DateTime CreateDate { get; private set; }
    public int Number { get; private set; }
}
