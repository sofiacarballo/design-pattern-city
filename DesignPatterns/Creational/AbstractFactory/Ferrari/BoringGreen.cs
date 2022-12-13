using DesignPatterns.Creational.AbstractFactory.Abstractions;

namespace DesignPatterns.Creational.AbstractFactory.Ferrari;

public class BoringGreen : IElectric
{
    public string GetName()
    {
        return "I am a boring green Ferrari car";
    }
}