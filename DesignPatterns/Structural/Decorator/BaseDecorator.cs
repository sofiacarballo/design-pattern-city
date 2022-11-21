namespace DesignPatterns.Structural.Decorator;

public abstract class BaseDecorator : INotifier
{
    public INotifier _wrappee;

    public BaseDecorator(INotifier wrappee)
    {
        _wrappee = wrappee;
    }

    public abstract string Send(string message);
    // the reason is abstract is because we are saying that the constructor has to be like the one we have here. The child classes will define how they implement the send method
    
    //  AuditingMassTransitBusControlDecorator : IBusControl
    // How to spot it? The constructor takes the same type that the constructor class belongs to
}