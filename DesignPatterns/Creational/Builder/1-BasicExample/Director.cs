namespace DesignPatterns.Creational.Builder._1_BasicExample;

public class Director
{
    public IVehicleBuilder _carBuilder
    {
        get => _carBuilder;
        set { _carBuilder = value; }
    }

    public void BuildMinimalViableCar(int numberOfSeats)
    {
        _carBuilder.SetSeats(numberOfSeats);
    }
        
    public void BuildFullCar(int numberOfSeats, Engine engine)
    {
        _carBuilder.SetSeats(numberOfSeats);
        _carBuilder.SetEngine(engine);
    }
}