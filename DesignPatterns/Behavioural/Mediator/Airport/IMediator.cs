namespace DesignPatterns.Behavioural.Mediator.Airport;

public interface IMediator
{
    AircraftResponse Notify(Aircraft aircraft, AircraftEvent @event);
}