namespace DotSharp.Day01_Basics;

public static class DataTypes
{
    public static void ShowDataTypes()
    {
        int myInt = 10;
        double myDouble = myInt; // implicit cast
        double anotherDouble = 29.7;
        int castedInt = (int)anotherDouble;

        Console.WriteLine($"Int: {myInt}, Double: {myDouble}");
        Console.WriteLine($"Double: {anotherDouble}, Casted Int: {castedInt}");
    }
}
