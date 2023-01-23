using DesignPatterns.Creational.AbstractFactory.Examples._1_BasicExample.Abstractions;

namespace DesignPatterns.Creational.AbstractFactory.Examples._1_BasicExample.Tesla;

public class ModelS : IElectric
{
    public string GetName()
    {
        return "I am an electric Tesla Model S car";
    }
}