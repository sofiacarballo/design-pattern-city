using DesignPatterns.Creational.AbstractFactory.Abstractions;
using DesignPatterns.Creational.AbstractFactory.Ferrari;

namespace DesignPatterns.Creational.AbstractFactory.Factories;

public class FerrariFactory : ICarFactory
{
    public IHybrid CreateHybrid()
    {
        return new Roma();
    }

    public IElectric CreateElectric()
    {
        return new MonzaSP2();
    }
}