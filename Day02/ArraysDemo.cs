namespace DotSharp.Day02;

public static class ArraysDemo
{
	public static void ShowArrays()
	{
		// Single Dim. Array
		string[] friends =  //  we can write : <<new string[5] >> is for specifications but we don't need it
		{
			"Ahmed",
			"Abduallah",
			"Monzer",
			"Haya",
			"Hannah"
		};
		Console.WriteLine(string.Join(", ", friends));
		int[,] suduko =
		{
			{9,5,4,6,7,2,1,4,5},
			{1,4,2,3,5,2,6,9,5},
			{2,1,3,6,4,5,3,2,7},
			{9,7,4,6,2,1,5,9,0},
			{9,5,4,6,7,2,1,4,5},
			{2,1,3,6,4,5,3,2,7},
			{1,4,2,3,5,2,6,9,5}
		};
		Console.WriteLine("\n====Sudouko Grid====");
		for (int i = 0; i < suduko.GetLength(0); i++)
		{
			for (int j = 0; j < suduko.GetLength(1); j++)
				Console.Write(suduko[i, j] + " ");
			Console.WriteLine();
		}
		// Jagged Array
		var jagged = new int[][]
		{
			new int[] {1,2},
			new int[] { 1, 2, 3},
			new int[] {7}
		};
		foreach (var row in jagged)
		{
			Console.WriteLine(string.Join(" ", row));
		}

		//Array range expression
		Console.WriteLine("===== Slicing Expressions =====");
		var slice1 = friends[..2];
		var slice2 = friends[2..^1];
		Console.WriteLine(string.Join(", ", slice1));
		Console.WriteLine(string.Join(", ", slice2));
	}
	
}
