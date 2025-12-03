using System;
using DotSharp.Day03;

namespace DotSharp.Day03_problems;

public class Problem1
{
	public static Employee WageTest()
	{
		Employee monz = new Employee();
		monz.fName ="Abdualla";	
		monz.lName = "Monzer";
		monz.LoggedHour = 170;
		monz.wage = 100;
		return monz;
	}
	public static void IncreaseTemp(double t)
	{
		Console.WriteLine("Inside IncreaseTemp (before): " + t);
		t = t+ 5;
		Console.WriteLine("Inside IncreaseTmp (after): " + t);
	}
	public static void IncreaseTempRef(ref double t)
	{
		Console.WriteLine("Inside IncreaseTempRef (before): " + t);
		t = t+ 5;
		Console.WriteLine("Inside IncreaseTempRef (after): " + t);
	}
	public static void Swap(int a, int b)
	{
		Console.WriteLine($"Inside Swap (before): a={a}, b={b}");
		int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"Inside Swap (after): a={a}, b={b}");
	}
	public static void Swap(ref int a, ref int b)
	{
		Console.WriteLine($"Inside SwapRef (before): a={a}, b={b}");
        
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"Inside SwapRef (after): a={a}, b={b}");
	}
	
}
