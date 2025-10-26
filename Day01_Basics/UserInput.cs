namespace DotSharp.Day01;

public static class UserInput
{
    public static void InsertData()
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        Console.WriteLine($"Welcome, {name}!");
    }
}
