using System;

namespace DotSharp.Day01_problems;

class Project1
{
	public static void SimpleCalc()
	{
		Console.WriteLine("Enter your first number: ");
		double num1 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Chose which operator ( +, -, *, /, )");
		char op = Console.ReadLine()[0];

		Console.WriteLine("Enter the second number: ");
		double num2 = Convert.ToDouble(Console.ReadLine());

		double result = 0;
		bool valid = true;

		switch (op)
		{
			case '+':
				result = num1 + num2;
				break;
			case '-':
				result = num1 - num2;
				break;
			case '*':
				result = num1 * num2;
				break;
			case '/':
				if (num2 != 0)
					result = num1 / num2;
				else
				{
					Console.WriteLine("Error, cannot divide on zero");
					valid = false;
				}
				break;
			default:
				Console.WriteLine("Invalid Operator");
				valid = false;
				break;
		}
		if (valid)
        {
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
	}
}