using DotSharp.Day03;
namespace DotSharp;

public class Program
{
	public static void Main()
    {
        //Console.WriteLine("=======Non OOP METHOD======");
        //NonOOPDemo.ShowBasicVersion();
        //Console.WriteLine("======= OOP METHOD======");
        //FieldsDemo.ShowFields();
        var age = 19;
        MethodsDemo.ShowMethods(age);
        Console.WriteLine(age);
        Console.WriteLine($"why the age still {age} while we asked to sum");
        var num = 20;
        string name = "ab";
        double bars = 22.2;
        Console.WriteLine("can you predict which method will be taken here?");
        Console.ReadLine();
        MethodsDemo.ShowMethods(ref num, name);
        Console.WriteLine($"should add ref to pass by refernce {num} and {name} not pass by value");
        Console.WriteLine($"{name} this is the methods overloading");
        Console.WriteLine("The body expression method");
        MethodsDemo.ShowMethods(ref num, name, bars);

        Console.WriteLine("========Constructors========");
        Date d1 = new Date(01,01,2000);
        Console.WriteLine(d1.GetDate());
	}
}
