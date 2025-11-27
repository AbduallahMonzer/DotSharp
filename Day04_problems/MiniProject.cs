using System;

namespace DotSharp.Day04_Problems
{
    // =============================
    //  Delegate
    // =============================
    public delegate void StudentAction(Student s);

    // =============================
    //  Student Class
    // =============================
    public class Student
    {
        private int[] grades = new int[5]; // indexer storage

        // ------- Properties -------
        public string Name { get; set; }
        public int ID { get; }             // read-only
        public int Age 
        { 
            get => _age; 
            set
            {
                if (value < 5 || value > 120)
                    throw new ArgumentException("Age must be between 5 and 120");
                _age = value;
            } 
        }
        private int _age;

        public double Average
        {
            get
            {
                double sum = 0;
                foreach (var g in grades)
                    sum += g;
                return sum / grades.Length;
            }
        }

        // -------- Constructors --------
        public Student(string name, int age, int id)
        {
            Name = name;
            Age = age;
            ID = id;
        }

        public Student(string name, int id) : this(name, 10, id) { }

        public Student() : this("Unknown", 10, 0) { }

        // -------- Indexer --------
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 4)
                    throw new IndexOutOfRangeException("Grade index must be 0–4");
                return grades[index];
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Grade must be between 0–100");
                grades[index] = value;
            }
        }

        // -------- Display --------
        public void PrintInfo()
        {
            Console.WriteLine($@"
=====================
Student Information
=====================
Name: {Name}
ID:   {ID}
Age:  {Age}
Grades: {string.Join(", ", grades)}
Average: {Average:F2}
");
        }
    }



    // ================================
    //  School Class
    // ================================
    public class School
    {
        private Student[] students = new Student[100];

        public string SchoolName { get; set; }
        public string Location { get; set; }
        public int StudentCount { get; private set; }

        public School(string name, string location)
        {
            SchoolName = name;
            Location = location;
        }

        // -------- Indexer --------
        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= 100)
                    throw new IndexOutOfRangeException("School index must be 0–99");
                return students[index];
            }
            set
            {
                if (index < 0 || index >= 100)
                    throw new IndexOutOfRangeException("School index must be 0–99");
                
                students[index] = value;
                StudentCount++;
            }
        }
    }



    // ===================================
    //        MiniProject Runner
    // ===================================
    public static class MiniProject
    {
        public static void Run()
        {
            Console.WriteLine("\n===== SMART SCHOOL MINI PROJECT =====\n");

            // Create School
            School school = new School("DotSharp Academy", "Cairo");

            // Create Students
            Student s1 = new Student("Omar", 18, 1001);
            Student s2 = new Student("Laila", 17, 1002);
            Student s3 = new Student(); // default constructor

            // Assign Students using Indexer
            school[0] = s1;
            school[1] = s2;
            school[2] = s3;

            // Set grades using Student indexer
            s1[0] = 90; s1[1] = 85; s1[2] = 95; s1[3] = 80; s1[4] = 88;
            s2[0] = 70; s2[1] = 75; s2[2] = 72; s2[3] = 68; s2[4] = 74;

            // Delegates
            StudentAction Promote = (s) =>
            {
                for (int i = 0; i < 5; i++)
                    s[i] = Math.Min(s[i] + 5, 100);
            };

            StudentAction Punish = (s) =>
            {
                for (int i = 0; i < 5; i++)
                    s[i] = Math.Max(s[i] - 5, 0);
            };

            StudentAction Honor = s => 
                Console.WriteLine($"{s.Name} is honored for high performance!");

            StudentAction Show = s => s.PrintInfo();

            // Multicast delegate
            StudentAction review = Promote + Honor + Show;

            // Apply delegate to student 1
            review(s1);

            // Show all students info
            Console.WriteLine("\n===== All Students in School =====");
            school[0].PrintInfo();
            school[1].PrintInfo();
            school[2].PrintInfo();
        }
    }
}
