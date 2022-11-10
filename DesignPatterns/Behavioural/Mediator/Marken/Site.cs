﻿namespace DesignPatterns;

public class Site : EventPublisher
{
    public Site(IMediatorMarken eventQueue) : base(eventQueue)
    {
    }

    public void Communicate()
    {
        var response = eventQueue.Publish(this, MarkenEvent.ShipmentCollected);
    }
}