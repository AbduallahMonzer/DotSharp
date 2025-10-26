using DotSharp.Day01;
namespace Day01App;
public class Program
{
	public static void Main()
	{
		Console.WriteLine("==== Day 1: C# basics ====");

DataTypes.ShowDataTypes();
UserInput.InsertData();
OperatorDemo.ShowOperators();
StringsDemo.ShowStrings();
ConditionsDemo.ShowConditions();

var p = new Person { Name = "Monzer" };
p.Greet();
	}
}
