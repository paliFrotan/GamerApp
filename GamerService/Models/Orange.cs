namespace GamerService.Models;
class Orange : Fruit
{
    public Orange(string name, string color, string countryOfOrigin) : base(name, color, countryOfOrigin)
    {
    }
    public override string GetDetails()
    {
        return $"I am {Color} {Name} and I am originally from {CountryOfOrigin}!";
    }
}
	 
