namespace DesignPatterns.Structural.Adapter.Examples._1_BasicExample;

public class EnglishWordGenerator
{
    private List<string> Words;

    public EnglishWordGenerator()
    {
        Words = new List<string>()
        {
            "Dog",
            "Cat",
            "Person",
            "House",
            "Computer"
        };
    }

    public string GenerateWord()
    {
        var randomIndex = new Random().Next(Words.Count);
        return Words[randomIndex];
    }
}