using DesignPatterns.Creational.AbstractFactory.Abstractions;
using DesignPatterns.Creational.AbstractFactory.Factories;

namespace Tests.Creational.AbstractFactory;

public class AbstractFactory
{
    [TestCase(CarType.Tesla, "Tesla")]
    [TestCase(CarType.Ferrari, "Ferrari")]
    public void ShouldDemonstrateAbstractFactoryWorks(CarType type, string messageSection)
    {
        var factory = GetFactoryFromCarType(type);

        var electricCar = factory.CreateElectric();
        var hybridCar = factory.CreateHybrid();

        var electricCarMessage = electricCar.GetName();
        var hybridCarMessage = hybridCar.GetName();
        
        Assert.Multiple(() =>
        {
            Assert.That(electricCarMessage, Does.Contain(messageSection));
            Assert.That(hybridCarMessage, Does.Contain(messageSection));
        });
    }

    private static ICarFactory GetFactoryFromCarType(CarType type)
    {
        return type switch
        {
            CarType.Tesla => new TeslaFactory(),
            CarType.Ferrari => new FerrariFactory(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
    
    public enum CarType
    {
        Tesla,
        Ferrari
    }
}