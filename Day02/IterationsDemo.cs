namespace DotSharp.Day02;

public static class IterationsDemo
{
	public static void ShowIteration()
	{
		// while && do while
		var counter = 0;
		while (counter < 10)
		{
			Console.WriteLine(counter + " ");
			++counter;
		}
		Console.WriteLine();
		counter = 0;
		do
		{
			Console.Write(counter + " ");
			++counter;
		} while (counter < 10);
		Console.WriteLine("\n");

		// for
		for (var counter1 = 0; counter1 < 14; ++counter1)
		{
			Console.WriteLine(counter1 + " ");
		}
		Console.Write("\ntrying fibonacci");
		//fibonacci number
		for (int counter2 = 0, prev = 0, current = 1; counter2 < 10; ++counter2)
		{
			Console.Write( prev + " ");
			int newFib = current + prev;
			prev = current;
			current = newFib;
		}
		// for each
		Console.WriteLine("\nNew line");
		var arr = new int[] { 1, 2, 3, 4 };
		foreach (var n in arr)
		{
			Console.Write(n + " ");
		}
		for ( var i=0; i<arr.Length; i++)
		{
			Console.Write(arr[i] + " ");
		}
	}
}