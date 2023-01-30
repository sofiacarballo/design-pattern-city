namespace DesignPatterns.Structural.Decorator.Examples._1_BasicExample;

public class FacebookDecorator : BaseDecorator
{
    public FacebookDecorator(INotifier wrappee) : base(wrappee)
    {
    }

    public override string Send(string message)
    {
        var facebookMessage = _wrappee.Send(message);
        return $"Facebook decorator -> {facebookMessage}";
    }
}