namespace DotSharp.Day02;

public static class ExpressionsDemo
{
	public static void ShowExpressions()
	{
		Console.WriteLine("=== Expressions Demo ===");
		var amount = Math.Cos(30);
		int a = 10, b = 3;

		Console.WriteLine($"Addition: {a + b}");
		Console.WriteLine($"Subtraction: {a - b}");
		Console.WriteLine($"Multiplication: {a * b}");
		Console.WriteLine($"Division: {a / b}");
		Console.WriteLine($"Remainder: {a % b}");

		Console.WriteLine($"Is a > b? {a > b}");

		string message = a > b ? "a is bigger" : "b is bigger";
		Console.WriteLine($"Ternary expression: {message}");

		// Expression statement
		var name = "Abduallah";

		// Assignment 
		name = name + "M.";

		// Call something that change the state
		name = name.ToUpper();

		Console.WriteLine(name);

		// increament & Decrement
		var TotalFriends = 120;
		++TotalFriends;
		Console.WriteLine(TotalFriends);
		--TotalFriends;
		Console.WriteLine(TotalFriends);

		//object instasiation
		object o = new object();

		// now we learned (Declaration (variable), Assignment(value), Expression(sentence with value))

		// Selection
		var mark = 55;
		if (mark >= 60)
		{
			Console.WriteLine("pass");
		}
		else if (mark >= 55)
		{
			Console.WriteLine("you have another chance");
		}
		else
		{
			Console.WriteLine("Fail");
		}
		// There are a lot of cases you can use if alone and if, else, and last case as we did if, else if, else.

		// Switch

		var amountEGY = 100;
		var currType = "USD";
		var output = 0d;

		var EGYtoUSD = 1.41d;
		var EGYtoEUR = 1.19d;
		var EGYtoCAD = 1.38d;

		switch (currType)
		{
			case "USD":
				output = amountEGY * EGYtoUSD;
				Console.WriteLine($"{amountEGY} EGY = ${output} USD");
				break;
			case "EUR":
				output = amountEGY * EGYtoEUR;
				Console.WriteLine($"{amountEGY} EGY = ${output} EUR");
				break;
			case "CAD":
				output = amountEGY * EGYtoCAD;
				Console.WriteLine($"{amountEGY} EGY = ${output} CAD");
				break;
			default:
				Console.WriteLine("Unkown currency type");
				break;
		}
		// Switch based on (type)
		object x = 3;
		switch(x)
		{
			case int i: Console.WriteLine($"It's int, sqr of {i}= {i * i}");
				break;
			case string i: Console.WriteLine($"It's string, captilization of {i}= {i.ToUpper()}");
				break;
		}
	}
}
