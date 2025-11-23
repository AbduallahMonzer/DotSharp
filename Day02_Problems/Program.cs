using System;
using DotSharp.Day02_Problems;
namespace Day02_problems;

public class Program
{
	public static void Main()
	{
		Problem1.Converter();
		Console.WriteLine("======Ternary Expression======");
		Problem1.TernEXp();
		Console.WriteLine("=====Centered Pyramid=====");
		Problem1.StarPyr();
		Console.WriteLine("========Mini Project=======");
		MiniProject.StudentGrade();
		Console.WriteLine("========Login system=======");
		MiniProject2.Login();
	}
}
