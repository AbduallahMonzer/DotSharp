namespace DotSharp.Day01_Basics;

public static class UserInput
{
    public static void InsertData()
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        Console.WriteLine($"Welcome, {name}!");
    }
}
