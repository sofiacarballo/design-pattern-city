namespace DesignPatterns;

public interface IMediator
{
    AircraftResponse Notify(Aircraft aircraft, AircraftEvent @event);
}