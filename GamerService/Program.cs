// See https://aka.ms/new-console-template for more information
using GamerService;
using GamerService.Models;

Console.WriteLine("Hello, World!");
var gamer = new Gamer(18);
Console.WriteLine(gamer.Age);

// cant use this --> gamer.Age = 16;

var wheelOne = new AlloyWheel();
wheelOne.PumpedUpTyre();
Console.WriteLine(wheelOne.IsPumpedUp);
var chooseFruit = new Orange("Orange","orange","Sicily");
Console.WriteLine(chooseFruit.GetDetails());
var secondFruit = new Lemon("Lemon", "yellow", "France");
Console.WriteLine(secondFruit.GetDetails());
