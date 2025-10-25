namespace DotSharp.Day01_Basics;

public class Person
{
    public string Name { get; set; } = "";

    public void Greet()
    {
        Console.WriteLine($"Hello! Welcome to C#, {Name}!");
    }
}
