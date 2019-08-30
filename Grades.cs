using System;

// Program to Calculate grades
// Author: Jiri Valcikevic
// Created: 12.10.2017 

class Grades
{
	static void Main()
	{

			Console.Write("Please, enter your grades:");
			string userInput = Console.ReadLine();	
			int grade = int.Parse(userInput);
			
			if (grade >= 1 && grade <= 35 )
			{
				Console.WriteLine("Your mark is F");
			}			
			if (grade >= 36 && grade < 40)
			{
				Console.WriteLine("Your mark is E");
			}
			if (grade >= 40 && grade < 50)
			{
				Console.WriteLine("Your mark is D");
			}
			if (grade >= 50 && grade < 60)
			{
				Console.WriteLine("Your mark is C");
			}
			if (grade >= 60 && grade < 70)
			{
				Console.WriteLine("Your mark is B");
			}	
			if (grade >= 70 && grade <=100)
			{
				Console.WriteLine("Your mark is A");
			}
			else if (grade <= 0)
			{
				Console.WriteLine("Sorry, no less marks than 0 can be given.");
			}
			if (grade > 100)
			{
				Console.WriteLine("Sorry, no more marks can be given.");
			}
	}
}