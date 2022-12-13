namespace DesignPatterns.Creational.AbstractFactory.Abstractions;

public interface ICarFactory
{
    public IHybrid CreateHybrid();
    public IElectric CreateElectric();
}