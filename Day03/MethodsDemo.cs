using System;

namespace DotSharp.Day03;

class MethodsDemo
{
	public static void ShowMethods(int age)
	{
		// Methods ->  <Access Modifier>  <Data type>/void  Method Name  (<parameter list>)
		Console.WriteLine("Do something ....");
		age = age + 3;
	}

	public static void ShowMethods(ref int num)
	{
		num = num + 3;
	}
	public static void ShowMethods(ref int num, string name)
	{
		num = num + 3;
		name = "monzer";
	}	

	public static void ShowMethods(ref int num, string name, double bars) => Console.WriteLine($"i'm {name} and {num} i love {bars} bars");
}