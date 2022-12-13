namespace DesignPatterns.Behavioural.Mediator.Marken;

public abstract class EventPublisher
{
    internal IMediatorMarken eventQueue;

    public EventPublisher(IMediatorMarken eventQueue)
    {
        this.eventQueue = eventQueue;
    }
}