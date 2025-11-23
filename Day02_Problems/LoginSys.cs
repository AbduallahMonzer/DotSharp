using System;

namespace DotSharp.Day02_Problems;

class MiniProject2
{
	public static void Login()
	{
		string[] usernames = {"admin", "abdullah", "monzer"};
		string[] passwords = {"1234", "monzer", "abdullah"};
		bool logedIn = false;

		while (!logedIn)
		{
			Console.WriteLine("Enter the username:");
			string user = Console.ReadLine();
			Console.WriteLine("Enter the password:");
			string pass = Console.ReadLine();

			for ( int i = 0; i < usernames.Length; i++)
			{
				if ( user == usernames[i] && pass == passwords[i])
				{
					logedIn = true;
					break;
				}
			}
			if (logedIn)
			Console.WriteLine("\nWelcome");
			else
			Console.WriteLine("Acess Denied. Try Again.\n");
		}
	}
}