namespace DotSharp.Day01;

public static class OperatorDemo
{
    public static void ShowOperators()
    {
        int a = 10, b = 5;
        Console.WriteLine($"a + b = {a + b}");
        Console.WriteLine($"a - b = {a - b}");
        Console.WriteLine($"a * b = {a * b}");
        Console.WriteLine($"a / b = {a / b}");
        Console.WriteLine($"a % b = {a % b}");

        // Logical operators 
        // && and
        int age = 20;
        bool hasID = true;
        if (age >= 18 && hasID)
            Console.WriteLine("Allowed");

        // || OR
        bool IsAdmin = false;
        bool IsManager = true;
        if (IsAdmin || IsManager)
            Console.WriteLine("Access granted");

        // ! Not
        bool isOnline = true;
        Console.WriteLine(!isOnline);
    }
}
