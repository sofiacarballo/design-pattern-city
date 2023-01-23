using DesignPatterns.Creational.AbstractFactory.Abstractions;

namespace DesignPatterns.Creational.AbstractFactory.Tesla;

public class ModelS : IElectric
{
    public string GetName()
    {
        return "I am an electric Tesla Model S car";
    }
}