namespace DesignPatterns.Structural.Decorator.Examples._1_BasicExample;

public class SlackDecorator : BaseDecorator
{
    public SlackDecorator(INotifier wrappee) : base(wrappee)
    {
    }

    public override string Send(string message)
    {
        // before open a connection to slack
        var slackMessage = _wrappee.Send(message);
        // after we send the message to the connection to slack
        return $"Slack decorator -> {slackMessage}";
    }
}