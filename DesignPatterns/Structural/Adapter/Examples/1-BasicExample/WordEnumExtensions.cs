namespace DesignPatterns.Structural.Adapter.Examples._1_BasicExample;

public static class WordEnumExtensions  
{
    public static string StringFromEnum(this SpanishWord spanishWord)
    {
        return spanishWord switch
        {
            SpanishWord.Perro => "Perro",
            SpanishWord.Gato => "Gato",
            SpanishWord.Persona => "Persona",
            SpanishWord.Casa => "Casa",
            SpanishWord.Ordenador => "Ordenador"
        };
    }
}