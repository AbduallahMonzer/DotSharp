using System;
namespace DotSharp.Day01_problems;

class Problems
{
	public static void CheckEvenOdd()
	{
		Console.WriteLine("=====Even Or Odd=====");
		Console.WriteLine("Enter and integer");
		int number = int.Parse(Console.ReadLine());
		if (number % 2 == 0)
		{
			Console.WriteLine($"{number} is Even");
		}
		else
		{
			Console.WriteLine($"{number} is Odd");
		}
	}
	public static void MaxOfThree()
	{
		Console.WriteLine("Enter First number: ");
		double num1 = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter second number: ");
		double num2 = double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Third number: ");
		double num3 = double.Parse(Console.ReadLine());

		double max = num1;
		if (num2 > max)
			max = num2;

		if (num3 > max)
			max = num3;
		
		Console.WriteLine($"The largest number is {max}");
	}
}