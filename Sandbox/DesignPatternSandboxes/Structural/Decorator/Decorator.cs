using DesignPatterns.Structural.Decorator.Examples._1_BasicExample;
using Sandbox.Helpers;

namespace Sandbox.DesignPatternSandboxes.Structural.Decorator;

public class Decorator : ExampleRunner
{
    protected override void Run()
    {
        INotifier notifier = new Notifier();
        var facebookDecorator = new FacebookDecorator(notifier);
        var slackDecorator = new SlackDecorator(notifier);

        Console.WriteLine(facebookDecorator.Send("Hello from Facebook"));
        Console.WriteLine(slackDecorator.Send("Hello from Slack"));
    }
}