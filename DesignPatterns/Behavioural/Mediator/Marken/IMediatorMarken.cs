namespace DesignPatterns.Behavioural.Mediator.Marken;

public interface IMediatorMarken
{
    MarkenResponse Publish(EventPublisher eventPublisher, MarkenEvent @event);
}