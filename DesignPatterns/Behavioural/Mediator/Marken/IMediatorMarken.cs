namespace DesignPatterns;

public interface IMediatorMarken
{
    MarkenResponse Publish(EventPublisher eventPublisher, MarkenEvent @event);
}