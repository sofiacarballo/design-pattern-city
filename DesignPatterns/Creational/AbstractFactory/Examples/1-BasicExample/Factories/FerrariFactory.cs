using DesignPatterns.Creational.AbstractFactory.Examples._1_BasicExample.Abstractions;
using DesignPatterns.Creational.AbstractFactory.Examples._1_BasicExample.Ferrari;

namespace DesignPatterns.Creational.AbstractFactory.Examples._1_BasicExample.Factories;

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