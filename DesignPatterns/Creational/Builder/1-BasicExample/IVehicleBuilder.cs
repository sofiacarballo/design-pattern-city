namespace DesignPatterns.Creational.Builder._1_BasicExample;

public interface IVehicleBuilder
{
    public CarBuilder SetSeats(int number);
    public CarBuilder SetEngine(Engine engine);
}