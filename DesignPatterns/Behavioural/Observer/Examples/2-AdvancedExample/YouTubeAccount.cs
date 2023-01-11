using DesignPatterns.Behavioural.Observer.PatternComponents;

namespace DesignPatterns.Behavioural.Observer.Examples._2_AdvancedExample;

public class YouTubeAccount : IObserver
{
    private string Username { get; }
    
    public YouTubeAccount(string username)
    {
        Username = username;
    }

    public void Update(ISubject subject)
    {
        var youtubeChannel = subject as YouTubeChannel ?? throw new Exception("Notification from unrecognized Subject.");
        Console.WriteLine($"Hey {Username}, there's a new video from {youtubeChannel.Name}: {youtubeChannel.LatestVideo.Title}");
    }
}