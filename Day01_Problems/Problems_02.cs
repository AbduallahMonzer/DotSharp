using System;
using System.Runtime.ConstrainedExecution;
namespace DotSharp.Day01_problems;

class Problems02
{
	static double num;

	public static void multiplicationTable()
	{
		Console.WriteLine("Enter any number you want: ");
		num = double.Parse(Console.ReadLine());
		for (int mt = 0; mt <= 12; mt++)
		{
			Console.WriteLine($"{mt} * {num}");
			double result = num * mt;
			Console.WriteLine(result);
		}
	}
	public static void SummmN()
	{
		Console.WriteLine("another usage for the last number you entered");
		double sum = 0;
		for (int i = 0; i <= num; i++)
		{
			sum += i;
		}
		Console.WriteLine($"Sum of numbers from 1 to {num} = {sum}");
	}
}