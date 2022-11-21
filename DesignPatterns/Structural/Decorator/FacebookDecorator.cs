namespace DesignPatterns.Structural.Decorator;

public class FacebookDecorator : BaseDecorator
{
    public FacebookDecorator(INotifier wrappee) : base(wrappee)
    {
    }

    public override string Send(string message)
    {
        var facebookMessage = _wrappee.Send(message);
        return $"Facebook decorator: {facebookMessage}";
    }
}