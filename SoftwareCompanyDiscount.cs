using System;

// Program to Calculate total prices of goods purchased
// Author: Jiri Valcikevic
// Created: 12.10.2017

class CalculateDiscount

{
	static void Main()
	{
		double price;
		double discount1;
		double discount2;
		double discount3;
		double discount4;
		double discount5;
		double quantity;
		string inputQuantity;

	
		Console.Write("Please, enter the number of copies you purchased:");
		inputQuantity = Console.ReadLine();	
		quantity = double.Parse(inputQuantity);

		price = quantity * 99;
		discount1 = price - (price * 0.1);
		discount2 = price - (price * 0.2);
		discount3 = price - (price * 0.3);
		discount4 = price - (price * 0.4);
		discount5 = price - (price * 0.5);
		
		if (quantity >=1 && quantity <5)
		{
			Console.Write("Your total Price is ");
			Console.Write(price);
			Console.WriteLine("You are not eligible for discount");
		}
		
		if (quantity >= 5 && quantity <= 9)
		{
			Console.Write("Your total Price is ");
			Console.WriteLine(price);
			Console.WriteLine("The amount of discount you can get is 10%");
			Console.Write("Total price with discount = ");
			Console.WriteLine(discount1);
		}
		
		if (quantity >= 10 && quantity <= 19)
		{
			Console.Write("Your total Price is ");
			Console.WriteLine(price);
			Console.WriteLine("The amount of discount you can get is 20%");
			Console.Write("Total price with discount = ");
			Console.WriteLine(discount2);
		}
		if (quantity >= 20 && quantity <= 49)
			{
			Console.Write("Your total Price is ");
			Console.WriteLine(price);
			Console.WriteLine("The amount of discount you can get is 30%");
			Console.Write("Total price with discount = ");
			Console.WriteLine(discount3);
			}
		if (quantity >= 50 && quantity <= 99)
			{
			Console.Write("Your total Price is ");
			Console.WriteLine(price);
			Console.WriteLine("The amount of discount you can get is 40%");
			Console.Write("Total price with discount = ");
			Console.WriteLine(discount4);
			}
		if (quantity >= 100)
			{
			Console.Write("Your total Price is ");
			Console.WriteLine(price);
			Console.WriteLine("The amount of discount you can get is 50%");
			Console.Write("Total price with discount = ");
			Console.WriteLine(discount5);
			}	
		
			
	}
}