namespace DotSharp.Day01_Basics;

public static class LoopsDemo
{
    public static void ShowLoops()
    {
        Console.WriteLine("While loop:");
        int i = 0;
        while (i < 3)
        {
            Console.WriteLine(i);
            i++;
        }

        Console.WriteLine("For loop:");
        for (int j = 0; j < 3; j++)
            Console.WriteLine(j);

        Console.WriteLine("Foreach loop:");
        string[] cars = { "BMW", "Ford", "Tesla" };
        foreach (var car in cars)
            Console.WriteLine(car);
    }
}
