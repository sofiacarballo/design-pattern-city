using DesignPatterns.Creational.AbstractFactory.Abstractions;

namespace DesignPatterns.Creational.AbstractFactory.Tesla;

public class TeslaCarTwo : IElectric
{
    public string GetName()
    {
        return "I am an electric Tesla Car Two";
    }
}