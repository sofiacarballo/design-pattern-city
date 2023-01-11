using DesignPatterns.Behavioural.Observer.Examples.HelperEntities;

namespace DesignPatterns.Behavioural.Observer.Examples._2_AdvancedExample;

public class YouTubeChannel : CanHaveSubscribers
{
    public string Name { get; }
    private List<Video> Videos { get; } = new();
    
    public YouTubeChannel(string name)
    {
        Name = name;
    }
    
    public Video LatestVideo => Videos.Last();

    public void PublishVideo(Video video)
    {
        Videos.Add(video);
        Notify();
    }
}