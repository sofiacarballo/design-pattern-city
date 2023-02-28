using System.Xml.Schema;

namespace DesignPatterns.Creational.Prototype._1_BasicExample;

public class Sheep : ICloneableObject
{
    public string Breed { get; }
    public string FavouriteFood { get; }
    public string Name { get; set; }
    public Hat Hat { get; set; }

    public Sheep(string breed, string favouriteFood)
    {
        Breed = breed;
        FavouriteFood = favouriteFood;
    }
    
    public Sheep ShallowCopy()
    {
        return (Sheep) this.MemberwiseClone();
    }

    public ICloneableObject Clone()
    {
       Sheep sheep = new Sheep(Breed, FavouriteFood);
       sheep.Name = $"{Name} clone";
       sheep.Hat = new Hat("red");

       return sheep;
    }
}

