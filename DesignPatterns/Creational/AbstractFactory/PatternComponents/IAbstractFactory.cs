namespace DesignPatterns.Creational.AbstractFactory.PatternComponents;

public interface IAbstractFactory
{
    public IAbstractProduct CreateProductA();
    public IAbstractProduct CreateProductB();
}