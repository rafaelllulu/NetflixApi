namespace Netflix.Domain.ValueObjects;

public class Password
{
    public Password(string word)
    {
        Word = word;
    }
    public string Word { get; private set; }
}