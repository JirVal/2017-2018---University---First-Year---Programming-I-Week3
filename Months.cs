using System;

// Program to calculate chosen month
// Author: Jiri Valcikevic
// Created: 12.10.2017 

class Months
{
	static void Main()
	{

			Console.Write("Please, enter the number of month:");
			string userInput = Console.ReadLine();	
			int month = int.Parse(userInput);
		
			if (month == 1)
			{
				Console.WriteLine("The month is January");
			}		
			if (month == 2)
			{
				Console.WriteLine("The month is February");
			}	
			if (month == 3)
			{
				Console.WriteLine("The month is March");
				}	
			if (month == 4)
			{
				Console.WriteLine("The month is April");
			}	
			if (month == 5)
			{
				Console.WriteLine("The month is May");
			}	
			if (month == 6)
			{
				Console.WriteLine("The month is June");
			}	
			if (month == 7)
			{
				Console.WriteLine("The month is July");
			}	
			if (month == 8)
			{
				Console.WriteLine("The month is August");
				}	
			if (month == 9)
			{
				Console.WriteLine("The month is September");
			}	
			if (month == 10)
			{
				Console.WriteLine("The month is October");
			}	
			if (month == 11)
			{
				Console.WriteLine("The month is November");
			}
			if (month == 12)
			{
				Console.WriteLine("The month is December");
			}
			else if (month <= 0)
			{
				Console.WriteLine("Sorry, There is no less months than is 1.");
			}
			if (month >= 13)
			{
				Console.WriteLine("Sorry, There are no more months than is 12.");
			}
	}
}