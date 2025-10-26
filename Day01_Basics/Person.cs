namespace DotSharp.Day01;

public class Person
{
    public string Name { get; set; } = "";

    public void Greet()
    {
        Console.WriteLine($"Hello! Welcome to C#, {Name}!");
    }
}
