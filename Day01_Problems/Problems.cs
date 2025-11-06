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
		
	}
}