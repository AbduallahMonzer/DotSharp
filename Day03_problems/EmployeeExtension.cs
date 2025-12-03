using DotSharp.Day03;

public static class EmployeeExtension
{
	public static void ApplyRaise(this Employee monz)
	{
		if ( monz.LoggedHour > 160)
		{
			monz.wage *=1.10;
		}
		else if(monz.LoggedHour >= 120 && monz.LoggedHour <=160)
		{
			monz.wage *=1.05;
		}
	}
	public static double GetSalary(this Employee monz)
	{
		return monz.wage * monz.LoggedHour;
	}
}