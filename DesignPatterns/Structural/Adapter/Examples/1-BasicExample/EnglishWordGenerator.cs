namespace DesignPatterns.Structural.Adapter.Examples._1_BasicExample;

public class EnglishWordGenerator
{
    private readonly List<EnglishWord> _words;

    public EnglishWordGenerator()
    {
        _words = new List<EnglishWord>()
        {
            EnglishWord.Dog,
            EnglishWord.Cat,
            EnglishWord.Person,
            EnglishWord.House,
            EnglishWord.Computer
        };
    }

    public EnglishWord GenerateWord()
    {
        var randomIndex = new Random().Next(_words.Count);
        return _words[randomIndex];
    }
}