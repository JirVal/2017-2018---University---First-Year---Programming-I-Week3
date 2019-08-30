using System;

// Program calculate only the result and display it if the user enters a value that is greater than or equal to zero
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
		
		if (inches < 0)
		{
		}
		
		else
		{	 
		result = inches * conversionFactor;
		Console.WriteLine("inches is = " + result + " centimetres");
		}
		
	}
}	