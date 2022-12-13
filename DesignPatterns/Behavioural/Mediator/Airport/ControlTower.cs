namespace DesignPatterns.Behavioural.Mediator.Airport;

public class ControlTower : IMediator
{
    private RunwayService runwayService { get; set; }
    
    public ControlTower(RunwayService runwayService)
    {
        this.runwayService = runwayService;
    }
    
    // mediator is like an orchestrator that manages communication. Planes don't have to communicate between themselves.
    // you can inject a runwayService so the ControlTower doesn't have all the responsibility
    public AircraftResponse Notify(Aircraft aircraft, AircraftEvent @event)
    {
        switch (@event)
        {
            case AircraftEvent.SayHi:
                return AircraftResponse.Good;

            case AircraftEvent.RequiredLanding:
                if (runwayService.RunwayAvailable())
                {
                    return AircraftResponse.Good;
                }
                break;
            
            default:
                return AircraftResponse.Bad;
        }

        return AircraftResponse.Bad;
    }
}