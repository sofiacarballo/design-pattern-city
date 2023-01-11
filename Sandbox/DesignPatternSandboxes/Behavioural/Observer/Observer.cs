using DesignPatterns.Behavioural.Observer.Examples._2_AdvancedExample;
using DesignPatterns.Behavioural.Observer.Examples.HelperEntities;
using Sandbox.Helpers;

namespace Sandbox.DesignPatternSandboxes.Behavioural.Observer;

public class Observer : ExampleRunner
{
    protected override void Run()
    {
        var youtubeChannel = new YouTubeChannel("Design Pattern City");
        var cameronsAccount = new YouTubeAccount("Cameron");
        var sofiasAccount = new YouTubeAccount("Sofía");

        youtubeChannel.Attach(cameronsAccount);
        youtubeChannel.Attach(sofiasAccount);

        var video = new Video("You won't believe THIS about the OBSERVER PATTERN!");
        
        youtubeChannel.PublishVideo(video);
        youtubeChannel.Detach(sofiasAccount);

        var video2 = new Video("Is the Singleton pattern DEAD?!");
        youtubeChannel.PublishVideo(video2);

    }
}