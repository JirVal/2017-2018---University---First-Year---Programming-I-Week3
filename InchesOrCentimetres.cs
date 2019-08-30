using System;

// Program to convert from inches to centimetres or to convert from centimetres to inches
// Author: Jiri Valcikevic
// Created: 12.10.2017

class convertInchesOrCentimetres
{
	static void Main()
	{
			double inches;
			double selection;
			double centimetres;
			string inputInches;
			string inputCentimetres;
			string inputSelection;
		
			Console.Write("Enter number 1 to convert from inches to centimetres or number 2 to convert from centimetres to inches:");
		
				inputSelection = Console.ReadLine(); 
				selection = double.Parse(inputSelection);
				
			if (selection > 1 || selection < 2)
			{
				Console.Write("Please, choose only a selection between numbers 1 or 2");
				inputSelection = Console.ReadLine(); 
				selection = double.Parse(inputSelection);
			}
				
			if (selection == 1)
			{
				Console.Write("Please enter the number of inches you need to convert ");
			
				inputInches = Console.ReadLine();
				inches = double.Parse(inputInches);
				centimetres = inches * 2.54;
					
				Console.Write("Your answer in centimetres is ");
				Console.WriteLine(centimetres);
			}
	
			if (selection == 2)
			{
				Console.Write("Please enter the number of centimetres you need to convert ");
			
				inputCentimetres = Console.ReadLine();
				centimetres = double.Parse(inputCentimetres);
				inches = centimetres / 2.54;
			
				Console.Write("Your answer in inches is ");
				Console.WriteLine(inches);
			}
			

		
	}
}