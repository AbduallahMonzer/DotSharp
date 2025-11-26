using System;
using DotSharp.Day03;
using DotSharp.Day03_problems;

class Program
{
	public static void Main()
	{
		Employee monz = Problem1.WageTest();
		Console.WriteLine("Before Raise: " + monz.wage);
		monz.ApplyRaise();
		Console.WriteLine("After raise:" + monz.wage);
		double temp = 30;
		Problem1.IncreaseTemp(temp);
		Console.WriteLine("After IncreaseTemp (PASS BY VALUE): " + temp);
		Problem1.IncreaseTempRef(ref temp);
		Console.WriteLine("After IncreaseTempRef (PASS BY REFERENCE): " + temp);
		Console.WriteLine("==========Example on PBV or PBR============");

		int x = 10;
		int y = 20;

		Console.WriteLine($"Before Swap (VALUE): x={x}, y={y}");
		Problem1.Swap(x, y);
		Console.WriteLine($"After Swap (VALUE): x={x}, y={y}");   // values will NOT change

		Console.WriteLine();

		Console.WriteLine($"Before SwapRef (REFERENCE): x={x}, y={y}");
		Problem1.Swap(ref x, ref y);
		Console.WriteLine($"After SwapRef (REFERENCE): x={x}, y={y}");  // values WILL change
		MiniProject.start();
	}
}
