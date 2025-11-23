using System;
namespace DotSharp.Day02_Problems;

class MiniProject
{
	public static void StudentGrade()
	{
		List<string> names = new List<string>();
		List<int> scores = new List<int>();

		while(true)
		{
			Console.WriteLine("Enter Student Name: ");
			string name = Console.ReadLine().Trim();

			if (name.ToLower() == "stop")
			break;
			Console.Write("Enter Score: ");
			int score = int.Parse(Console.ReadLine());
			
			names.Add(name);
			scores.Add(score);

			Console.WriteLine("Student Added!!\n");
		}
		if(scores.Count == 0)
		{
			Console.WriteLine("No students were entered!!");
			return;
		}

		int total = 0;
		int MaxScore = scores[0];
		int MinScore = scores[0];
		int MaxIndex = 0;
		int MinIndex = 0;

		for (int i = 0; i<scores.Count; i++)
		{
			int score = scores[i];
			total += score;

			if ( score > MaxScore)
			{
				MaxScore = score;
				MaxIndex = i;
			}
			if (score < MinScore)
            {
                MinScore = score;
                MinIndex = i;
            }
		}
		double average = (double)total / scores.Count;

        // --- Output ---
        Console.WriteLine("\n===== CLASS SUMMARY =====");
        Console.WriteLine($"Total Students: {scores.Count}");
        Console.WriteLine($"Average Score : {average:F2}");
        Console.WriteLine($"Top Student   : {names[MaxIndex]} ({MaxScore})");
        Console.WriteLine($"Lowest Score  : {names[MinIndex]} ({MinScore})");

	}
}