using System;

namespace Day2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the DAY 2!");
			Console.WriteLine("");
			Console.WriteLine("Started reading input...");
			var intCode = System.IO.File.ReadAllText(@"Input/input.txt");
			var intCodeNumbers = intCode.Split(',');
			intCodeNumbers[1] = "12";
			intCodeNumbers[2] = "2";
			var step = 0;
			var code = Convert.ToInt32(intCodeNumbers[step]);
			while (code != 99)
			{
				if (code == 1)
				{
					intCodeNumbers[Convert.ToInt32(intCodeNumbers[step + 3])] = (Convert.ToInt32(intCodeNumbers[Convert.ToInt32(intCodeNumbers[step + 1])]) + Convert.ToInt32(intCodeNumbers[Convert.ToInt32(intCodeNumbers[step + 2])])).ToString();
				}
				if (code == 2)
				{
					intCodeNumbers[Convert.ToInt32(intCodeNumbers[step + 3])] = (Convert.ToInt32(intCodeNumbers[Convert.ToInt32(intCodeNumbers[step + 1])]) * Convert.ToInt32(intCodeNumbers[Convert.ToInt32(intCodeNumbers[step + 2])])).ToString();
				}
				step += 4;
				code = Convert.ToInt32(intCodeNumbers[step]);
			}
			Console.WriteLine(intCodeNumbers[0]);
			Console.ReadLine();
		}
	}
}
