using System;
using System.Collections.Generic;

namespace DotSharp.Day03;

public static class FieldsDemo
{
	public static void ShowFields()
	{
		List<Employee> emps = new List<Employee>();
		string choice;
		do
		{
			Employee e = new Employee();
			Console.WriteLine("First Name: ");
			e.fName = Console.ReadLine();
			Console.WriteLine("Last Name: ");
			e.lName = Console.ReadLine();

			Console.WriteLine("Wage: ");
			e.wage = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("LoggedHour: ");
			e.LoggedHour = Convert.ToDouble(Console.ReadLine());

			emps.Add(e);

			Console.WriteLine("\nwant to add another person? (Y/N)");
			choice = Console.ReadLine().ToLower();

		} while (choice == "y");
		Console.WriteLine("\n======Employees Data=======");
		foreach (var emp in emps)
		{
			var NetSalary = emp.wage * emp.LoggedHour - (emp.wage * emp.LoggedHour * Employee.TAX);

			Console.WriteLine($"First Name: {emp.fName}");
			Console.WriteLine($"Lasr Name : {emp.lName}");
			Console.WriteLine($"wage : {emp.wage}");
			Console.WriteLine($"LoggedHours : {emp.LoggedHour}");
			Console.WriteLine($"net salary : {NetSalary}");
		}
	}
}