using System;
namespace DotSharp.Day04_problems;

public class Book
{
	public string Author{get;set;}
	public string Title{get;set;}

	private int year;
	public int Year
	{
		get{return year;}
		set
		{
			if ( value <1500 || value > 2025)
			throw new ArgumentException("Year must be between 1500 and 2025.");
			year=value;
		}
	}
	private int pages;
	public int Pages
	{
		get{return pages;}
		set
		{
			if(value <=0)
			throw new ArgumentException("Pages must be greater than zero.");
			pages=value;
		}
	}
	public string ISBN {get;}
	public bool IsAvailable{get; private set;}
	public Book(string isbn)
    {
        ISBN = isbn;
    }

    // Methods
    public void Borrow()
    {
        IsAvailable = false;
    }

    public void Return()
    {
        IsAvailable = true;
    }

	
}