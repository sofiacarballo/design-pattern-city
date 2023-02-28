namespace DesignPatterns.Creational.Builder._1_BasicExample;

public class CarBuilder : IVehicleBuilder
{
    public Car car;

    public CarBuilder()
    {
        car = Reset();
    }
        
    public Car Build()
    {
        Car result = car;

        car = Reset();

        return result;
    }

    public CarBuilder SetSeats(int number)
    {
        car.Seats = number;
        return this;
    }

    public CarBuilder SetEngine(Engine engine)
    {
        car.Engine = engine;
        return this;
    }

    private static Car Reset() => new();
}