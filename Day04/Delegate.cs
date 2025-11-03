using System;

namespace DotSharp.Day04;

public static class Delegateee
{
	public static int Add(int x)
	{
		return x + 10;
	}
	public static int ProcessNumber(int num)
	{
		return Add(num);
	}
	public delegate int Operation(int z);
	public static int Multiply(int x)
	{
		return x * 10;
	}
	public static int ProcessNumber2(int number, Operation op)
	{
		return op(number);
	}
	
}