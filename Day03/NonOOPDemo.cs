using System;
using System.Collections.Generic;

namespace DotSharp.Day03;

public static class NonOOPDemo
{
    public static void ShowBasicVersion()
    {
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();
        List<double> wages = new List<double>();
        List<double> hours = new List<double>();

        string choice;
        do
        {
            Console.Write("First Name: ");
            firstNames.Add(Console.ReadLine());

            Console.Write("Last Name: ");
            lastNames.Add(Console.ReadLine());

            Console.Write("Wage: ");
            wages.Add(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Logged Hours: ");
            hours.Add(Convert.ToDouble(Console.ReadLine()));

            Console.Write("Add another employee? (Y/N): ");
            choice = Console.ReadLine().ToLower();

        } while (choice == "y");

        Console.WriteLine("\n====== Employees Data (Non-OOP) ======");
        for (int i = 0; i < firstNames.Count; i++)
        {
            double salary = wages[i] * hours[i];
            double tax = salary * 0.03;
            double netSalary = salary - tax;

            Console.WriteLine($"\nEmployee #{i+1}");
            Console.WriteLine($"First Name: {firstNames[i]}");
            Console.WriteLine($"Last Name: {lastNames[i]}");
            Console.WriteLine($"Wage: {wages[i]}");
            Console.WriteLine($"Logged Hours: {hours[i]}");
            Console.WriteLine($"Net Salary: {netSalary}");
        }
    }
}
