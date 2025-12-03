using System;
using DotSharp.Day04_problems;

namespace DotSharp.Day04_Problems;

class Program
{
	public static void Main()
	{
		Book b = new Book("ISBN-9999");
		b.Title = "The Great Monz";
		b.Author = "Abdullah Monzer";
		b.Year = 2022;
		b.Pages = 578;
		Console.WriteLine("Title: " + b.Title);
        Console.WriteLine("Author: " + b.Author);
        Console.WriteLine("Year: " + b.Year);
        Console.WriteLine("Pages: " + b.Pages);
        Console.WriteLine("ISBN: " + b.ISBN);
        Console.WriteLine("Available: " + b.IsAvailable);
		b.Borrow();
        Console.WriteLine("Available after borrowing: " + b.IsAvailable);

        // Return the book
        b.Return();
        Console.WriteLine("Available after returning: " + b.IsAvailable);

		Console.WriteLine("========== Second Problem========");
		Cart cart = new Cart();

        cart[0] = "Milk";
        cart[1] = "Bread";
        cart[2] = "Eggs";

        cart.ShowItems();
		MiniProject.Run();
	}
}