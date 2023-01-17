namespace DesignPatterns.Structural.Adapter.Examples._1_BasicExample;

public class EnglishToSpanishAdapter : ISpanishWordGenerator
{
    private readonly EnglishWordGenerator _englishWordGenerator;

    public EnglishToSpanishAdapter(EnglishWordGenerator englishWordGenerator)
    {
        _englishWordGenerator = englishWordGenerator;
    }

    public string GenerateSpanishWord()
    {
        var englishWord = _englishWordGenerator.GenerateWord();
        return englishWord switch
        {
            "Dog" => "Perro",
            "Cat" => "Gato",
            "Person" => "Persona",
            "House" => "Casa",
            "Computer" => "Ordenador",
            _ => throw new Exception("There's no translation for the given word!")
        };
    }
}