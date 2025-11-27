using System;

namespace DotSharp.Day04_problems;

public class Cart
{
	private string[] items = new string[5];

	public string this[int index]
	{
		get
		{
			if ( index < 0 || index > 4)
				throw new ArgumentException("Index must be between 0 and 4. ");
				return items[index];
		}
		set
		{
			if ( index < 0 || index > 4)
				throw new ArgumentException("Index must be between 0 and 4. ");
				items[index] = value;
		}
	}
	public void ShowItems()
	{
		Console.WriteLine("Shopping Cart Items:");
		for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i}: {items[i]}");
        }
	}
}