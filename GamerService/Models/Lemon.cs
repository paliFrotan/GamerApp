namespace GamerService.Models;

class Lemon: Fruit
{
	public Lemon(string name, string color, string countryOfOrigin): base(name, color,countryOfOrigin)
	{
	}
	public override string GetDetails()
	{
		return $"I am {Color} {Name} and I am originally from {CountryOfOrigin}!";
	}
}
