using DesignPatterns.Creational.AbstractFactory.Abstractions;

namespace DesignPatterns.Creational.AbstractFactory.Tesla;

public class TeslaCarOne : IHybrid
{
    public string GetName()
    {
        return "I am a Hybrid Tesla Car one";
    }
}