using System;
using System.Collections.Generic;

namespace DotSharp.Day03
{
    public class MiniProject
    {
        static List<Employee> employees = new List<Employee>();

        public static void start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n==== EMPLOYEE PAYROLL SYSTEM ====");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Show All Employees");
                Console.WriteLine("3. Apply Raise To All");
                Console.WriteLine("4. Show Total Salaries");
                Console.WriteLine("5. Show Highest Paid Employee");
                Console.WriteLine("6. Swap Two Employees");
                Console.WriteLine("0. Exit");
                Console.Write("Enter the code: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddEmployee(); break;
                    case 2: ShowAll(); break;
                    case 3: ApplyRaises(); break;
                    case 4: ShowTotalSalaries(); break;
                    case 5: ShowHighestPaid(); break;
                    case 6: SwapTwo(); break;
                }

            } while (choice != 0);
        }

        // ============================
        //        METHODS
        // ============================

        static void AddEmployee()
        {
            Employee e = new Employee();

            Console.Write("First Name: ");
            e.fName = Console.ReadLine();

            Console.Write("Last Name: ");
            e.lName = Console.ReadLine();

            Console.Write("Wage: ");
            e.wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Logged Hours: ");
            e.LoggedHour = Convert.ToDouble(Console.ReadLine());

            employees.Add(e);
            Console.WriteLine("Employee added!");
        }

        static void ShowAll()
        {
            Console.WriteLine("\n=== Employee List ===");

            for (int i = 0; i < employees.Count; i++)
            {
                var e = employees[i];
                Console.WriteLine($"{i + 1}. {e.fName} {e.lName} - " +
                                  $"Wage: {e.wage}, Hours: {e.LoggedHour}, Salary: {e.GetSalary()}");
            }
        }

        static void ApplyRaises()
        {
            foreach (var e in employees)
                e.ApplyRaise();

            Console.WriteLine("Raises applied to all employees!");
        }

        static void ShowTotalSalaries()
        {
            double total = 0;

            foreach (var e in employees)
                total += e.GetSalary();

            Console.WriteLine($"Total Salary for all Employees: {total}");
        }

        static void ShowHighestPaid()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees yet!");
                return;
            }

            Employee highest = employees[0];

            foreach (var e in employees)
                if (e.GetSalary() > highest.GetSalary())
                    highest = e;

            Console.WriteLine($"Highest Paid: {highest.fName} {highest.lName} " +
                            $"with salary {highest.GetSalary()}");
        }

        static void SwapTwo()
{
    Console.Write("Enter index of employee 1: ");
    int i1 = Convert.ToInt32(Console.ReadLine()) - 1;

    Console.Write("Enter index of employee 2: ");
    int i2 = Convert.ToInt32(Console.ReadLine()) - 1;

    SwapEmployees(i1, i2);

    Console.WriteLine("Employees swapped!");
}

static void SwapEmployees(int i1, int i2)
{
    Employee temp = employees[i1];
    employees[i1] = employees[i2];
    employees[i2] = temp;
}

    }
}
