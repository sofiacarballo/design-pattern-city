namespace DesignPatterns.Creational.AbstractFactory.Examples._1_BasicExample.Abstractions;

public interface ICarFactory
{
    public IHybrid CreateHybrid();
    public IElectric CreateElectric();
}