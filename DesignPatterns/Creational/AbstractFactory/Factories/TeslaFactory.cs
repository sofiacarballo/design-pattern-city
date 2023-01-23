using DesignPatterns.Creational.AbstractFactory.Abstractions;
using DesignPatterns.Creational.AbstractFactory.Tesla;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

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