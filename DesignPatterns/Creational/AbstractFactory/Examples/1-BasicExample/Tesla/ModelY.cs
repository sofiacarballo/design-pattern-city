using DesignPatterns.Creational.AbstractFactory.Examples._1_BasicExample.Abstractions;

namespace DesignPatterns.Creational.AbstractFactory.Examples._1_BasicExample.Tesla;

public class ModelY : IHybrid
{
    public string GetName()
    {
        return "I am a Hybrid Tesla Model Y car";
    }
}