/*
* Name: Tiago Miguel Lourenço Vedes de Oliveira
* Course: CSCI 1250, Section 001
* Assignment: Lab 2, Trip
* Date: September 23, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip
*/

//Part 1: Ask the user for his information about his trip. How many miles he did on his trip, the price per gallon of his veichile and how much he paid.

System.Console.WriteLine("===Part 1: Road Trip===");

Console.Write("How many miles is your Trip? ");
int roundTripMiles = Convert.ToInt32(Console.ReadLine());

System.Console.Write("How much Miles per Gallon does your car use? ");
double milePerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Whats the price per Gallon you paid? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = roundTripMiles / milePerGallon;

double fuelCost = gallonsNeeded * pricePerGallon;

System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));

//Part 2: Asking the user Questions about a Pizza Party: asking for number of people attending party, how much pizza ate to give information about number of slices and total slicer per person and cost per price.
System.Console.WriteLine("===Part 2: Pizza Party===");

const int numberOfSlicesPerPizza = 8;

System.Console.Write("How many people are going to the Pizza Pary? ");
int numberOfPeopleAttendingParty = Convert.ToInt32(Console.ReadLine());

System.Console.Write("How many Pizzas were bought for the Party? ");
int numberOfPizzasBought = Convert.ToInt32(Console.ReadLine());

System.Console.Write("How much is the cost of each Pizza? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

double totalSlices = numberOfPizzasBought * numberOfSlicesPerPizza;

double slicesPerPerson = totalSlices / numberOfPeopleAttendingParty;

double pizzaCost = numberOfPizzasBought * pricePerPizza;

System.Console.WriteLine("Total Slices: " + totalSlices.ToString("F2"));
System.Console.WriteLine("Slices per Person: " + slicesPerPerson.ToString("F2"));
System.Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C"));

