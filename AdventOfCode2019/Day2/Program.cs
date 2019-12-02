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
			for (var x = 0; x < 100; x++)
			{
				for (var y = 0; y < 100; y++)
				{
					var intCode = System.IO.File.ReadAllText(@"Input/input.txt");
					var intCodeNumbers = intCode.Split(',');
					intCodeNumbers[1] = x.ToString();
					intCodeNumbers[2] = y.ToString();
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
					if (intCodeNumbers[0] == "19690720")
						Console.WriteLine(100 * x + y);
				}
			}
			Console.ReadLine();
		}
	}
}
