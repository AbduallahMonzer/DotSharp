using System;
using DotSharp.Day04;
namespace Day04;

public class Program
{
	public static void Main()
	{
		Property.ShowProperty();
		Property p = new Property("EG2000")
		{
			Name = "Abduallah",
			Age1 = 25,
			Country = "Egypt"
		};
		p.Password = "secretPassword123445";
		p.DisplayInfo();
		Console.WriteLine("=====Indexer=====");
		IpAddr ip = new IpAddr(192, 168, 1, 1);
		Console.WriteLine("Original IP: " + ip);
		Console.WriteLine("First Octet: " + ip[0]);
        Console.WriteLine("Second Octet: " + ip[1]);

        // Changing the last octet
        ip[3] = 100;

        Console.WriteLine("Updated IP: " + ip);
	}
}
