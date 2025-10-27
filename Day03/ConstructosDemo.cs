using System;

namespace DotSharp.Day03;

public class Date
{
	private static readonly int[] DaysToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
	private static readonly int[] DaysToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };

	private readonly int day = 01;
	private readonly int month = 01;
	private readonly int year = 01;


	public Date(int day, int month, int year)
	{
		var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
		if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
		{
			int[] days = isLeap ? DaysToMonth366 : DaysToMonth365;
			if (day >= 1 && day <= days[month])
			{
				this.day = day;
				this.month = month;
				this.year = year;
			}
		}
	}
	 // Constructor Overload #1 (No parameters → default date)
    public Date() : this(1, 1, 2000) { }

    //  Constructor Overload #2 (Only year → default day & month)
    public Date(int year) : this(1, 1, year) { }

    //  Constructor Overload #3 (Month + Year → default day)
    public Date(int month, int year) : this(1, month, year) { }

	public string GetDate()
	{
		return $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')}";
	}
}