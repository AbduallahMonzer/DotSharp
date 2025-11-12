using System;
using System.Runtime.ConstrainedExecution;
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
	
	public static void GradeCalc()
	{
		Console.WriteLine("Enter your score: ");
		if (!double.TryParse(Console.ReadLine(), out double score))
		{
			Console.WriteLine("Invalid input!");
			return;
		}
		if (score < 0 || score > 100)
		{
			Console.WriteLine("The input should be (0-100)");
			return;
		}
		string grade = score switch
		{
			>= 90 => "A",
			>= 80 => "B",
			>= 70 => "C",
			>= 60 => "D",
			_ => "F"
		};
		Console.WriteLine($"Grade is {grade}");
	}
		
}