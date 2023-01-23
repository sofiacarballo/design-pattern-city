using DesignPatterns.Creational.AbstractFactory.Abstractions;

namespace DesignPatterns.Creational.AbstractFactory.Tesla;

public class ModelY : IHybrid
{
    public string GetName()
    {
        return "I am a Hybrid Tesla Model Y car";
    }
}