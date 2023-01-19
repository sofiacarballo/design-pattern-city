namespace DesignPatterns.Structural.Adapter.Examples._1_BasicExample;

public class EnglishToSpanishAdapter : ISpanishWordGenerator
{
    private readonly EnglishWordGenerator _englishWordGenerator;

    public EnglishToSpanishAdapter(EnglishWordGenerator englishWordGenerator)
    {
        _englishWordGenerator = englishWordGenerator;
    }

    public SpanishWord GenerateSpanishWord()
    {
        var englishWord = _englishWordGenerator.GenerateWord();
        return englishWord switch
        {
            EnglishWord.Dog => SpanishWord.Perro,
            EnglishWord.Cat => SpanishWord.Gato,
            EnglishWord.Person => SpanishWord.Persona,
            EnglishWord.House => SpanishWord.Casa,
            EnglishWord.Computer => SpanishWord.Ordenador,
            _ => throw new Exception("There's no translation for the given word!")
        };
    }
}