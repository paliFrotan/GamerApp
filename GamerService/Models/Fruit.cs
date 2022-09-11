namespace GamerService.Models;

abstract class Fruit
{
    public string Name { get; private set; }
    public string Color { get; private set; }
    public string CountryOfOrigin { get; private set; }
    
    public Fruit(string name,string color, string countryOfOrigin) 
    { 
        Name = name;
        Color = color;
        CountryOfOrigin = countryOfOrigin;
    }
    public string GetDetails()
    {
        return $"I am {Color} {Name} and I am originally from {CountryOfOrigin}!";
    }
    
}
