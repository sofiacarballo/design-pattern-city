namespace DesignPatterns.Behavioural.Mediator.Airport;

public abstract class Aircraft
{
   // public int passengers;
    internal IMediator trafficControlTower;
    // internal: kind of public but only for their children. Look fro difference between internal and protected

    public Aircraft(IMediator trafficControlTower)
    {
        this.trafficControlTower = trafficControlTower;
    }
    
    /*
    public void servePeanuts()
    {
        //here you define what to do 
        // all classes that inherit this class will have to servePeanuts exactly this way
    }

    public abstract void serveWater(); //here I define the method that every class that inherits this will need to have but don't define how to implement it

    public virtual void serveBeer()
    {
        // here give definition and the I can overwrite it on the inherited class
    }
    
    //composition over inheritance. With composition you can decouple your code. 
    abstract class does things as interface but also lets you define an specific implementation for their children
    */
}