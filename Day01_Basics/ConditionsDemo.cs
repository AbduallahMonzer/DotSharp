namespace DotSharp.Day01;

public static class ConditionsDemo
{
    public static void ShowConditions()
    {
        int x = 5, y = 10;
        if (x < y)
            Console.WriteLine("x is smaller than y");
        else
            Console.WriteLine("x is not smaller than y");

        string message = x < y ? "x < y" : "x >= y";
        Console.WriteLine(message);
    }
}
