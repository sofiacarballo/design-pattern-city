using DesignPatterns.Creational.AbstractFactory.Examples._1_BasicExample.Abstractions;
using DesignPatterns.Creational.AbstractFactory.Examples._1_BasicExample.Tesla;

namespace DesignPatterns.Creational.AbstractFactory.Examples._1_BasicExample.Factories;

public class TeslaFactory : ICarFactory
{
    public IHybrid CreateHybrid()
    {
        return new ModelY();
    }

    public IElectric CreateElectric()
    {
        return new ModelS();
    }
}