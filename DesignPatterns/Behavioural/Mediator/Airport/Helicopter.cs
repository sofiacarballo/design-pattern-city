﻿namespace DesignPatterns.Behavioural.Mediator.Airport;

public class Helicopter : Aircraft
{
    public Helicopter(IMediator trafficControlTower) : base(trafficControlTower)
    {
    }

    public void SendMessage()
    {
        var response = trafficControlTower.Notify(this, AircraftEvent.BirdEmergency);
    }
}