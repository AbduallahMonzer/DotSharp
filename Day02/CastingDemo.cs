namespace DotSharp.Day02;

public static class CastingDemo
{
    public static void ShowCasting()
    {
        Console.WriteLine("=== Casting Demo ===");

        int myInt = 10;
        double myDouble = myInt; // implicit
        Console.WriteLine($"Implicit casting: int to double = {myDouble}");

        double anotherDouble = 9.75;
        int castedInt = (int)anotherDouble; // explicit
        Console.WriteLine($"Explicit casting: double to int = {castedInt}");

        string numStr = "123";
        int converted = Convert.ToInt32(numStr); // conversion method
        Console.WriteLine($"Converted from string: {converted}");
    }
}
