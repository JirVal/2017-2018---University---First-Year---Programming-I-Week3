using System;

// Program to Calculate positive number of inches
// Author: Jiri Valcikevic
// Created: 12.10.2017


class NegativeInches
{
	static void Main()
	{
				
		string userInput;
		int inches;
		int centimetres;
		double result;
		double conversionFactor = 2.54;
		
		
		Console.Write("Enter a number of inches:");
		userInput = Console.ReadLine();
		inches = int.Parse(userInput);
		centimetres = int.Parse(userInput);
		
		if (inches <= 0)
		{
			Console.Write("Sorry, minimal value is 1 inch");
		}
		
		else
		{	 
		result = inches * conversionFactor;
		Console.WriteLine("inches is = " + result + " centimetres");
		}
		
	}
}	