using System;

namespace DotSharp.Day04;

class Property
{
    // Fields and Properties belong HERE, inside the class but outside methods
    public int age;
    private int age1;

    public int Age1
    {
        get { return age1; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Age cannot be negative");
            age1 = value;
        }
    }

	public static void ShowProperty()
	{
		Console.WriteLine("Instead of exposing fields directly, you use properties.");
	}
	
	// Auto implemented property 
	public string Name { get; set; }
	//Read-Only property
	public string NationalID { get; }
	//Write only property
	private string _password;
	public string Password
	{
		set { _password = value; }
	}
	// init-only property (can only be set on object initialization) - C# 9+
        public string Country { get; init; }
		// Constructor to enforce necessary data
        public Property(string nationalID)
        {
            NationalID = nationalID;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age1}");
            Console.WriteLine($"National ID: {NationalID}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine("-----------------------------------");
        }
}
