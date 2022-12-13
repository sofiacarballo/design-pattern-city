namespace DesignPatterns.Behavioural.Mediator.Airport;

public class Plane : Aircraft
{
    public Plane(IMediator trafficControlTower) : base(trafficControlTower)
    {
    }

    public void Communicate()
    {
        var response = trafficControlTower.Notify(this, AircraftEvent.InformPassengers);
        
        // in this we pass all the info about the plane
        // this plane doesn't care about the rest of the planes, only by itself (can I land?)
        // you only care about sending a request and getting a response. 
    }
}