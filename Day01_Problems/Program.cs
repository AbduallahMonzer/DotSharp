using System;
using DotSharp.Day01_problems;
namespace Day01_problems;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("======Even Or Odd======");
		Problems.CheckEvenOdd();
		Console.WriteLine("======Max Of Three======");
		Problems.MaxOfThree();
		Console.WriteLine("======Score Grade======");
		Problems.GradeCalc();
		Console.WriteLine("=========Problems Level 2 =========");
		Problems02.multiplicationTable();
		Problems02.SummmN();
	}
}