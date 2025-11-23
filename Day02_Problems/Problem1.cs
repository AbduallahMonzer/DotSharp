using System;
namespace DotSharp.Day02_Problems;

class Problem1
{
	public static void Converter()
	{
		Console.WriteLine("Enter any number (decimal): ");
		double num = Convert.ToDouble(Console.ReadLine());

		double rounded = Math.Round(num);
		int CastValue = (int)num;
		string TwoDecimals = num.ToString("F2");
		Console.WriteLine($"\nRounded value: {rounded}");
		Console.WriteLine($"Integer cast value: {CastValue}");
		Console.WriteLine($"Formatted to 2 decimals: {TwoDecimals}");
	}
	public static void TernEXp()
	{
		Console.WriteLine("Enter thre numbers: ");
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());
		int smallest = (a < b) ? (( a < c) ? a:c):(( b < c)? b:c);
		Console.WriteLine($"\nThe smallest number is: {smallest}");
	}
	public static void StarPyr()
	{
		int height = 5;
		for ( int i = 1; i<= height; i++ )
		{
			for ( int s = 1; s<= height - i; s++)
			{
				Console.Write(" ");
			}
			for ( int star = 1; star <= (2 * i - 1 ); star++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}