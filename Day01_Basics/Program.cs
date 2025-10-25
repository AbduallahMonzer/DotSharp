using DotSharp.Day01_Basics;
Console.WriteLine("==== Day 1: C# basics ====");

DataTypes.ShowDataTypes();
UserInput.InsertData();
OperatorDemo.ShowOperators();
StringsDemo.ShowStrings();
ConditionsDemo.ShowConditions();
LoopsDemo.ShowLoops();


var p = new Person { Name = "Monzer" };
p.Greet();