using DesignPatterns.Structural.Decorator;

var notifier = new Notifier();
var slackDecorator = new SlackDecorator(notifier);
var facebookDecorator = new FacebookDecorator(notifier);

var input = "whatever";
var slackMessage = slackDecorator.Send(input);
var facebookMessage = facebookDecorator.Send("I am fb decorator");

Console.WriteLine(slackMessage);
Console.WriteLine(facebookMessage);