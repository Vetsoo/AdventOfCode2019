using System;
using System.Linq;

namespace Day1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the DAY 1!");
			Console.WriteLine("");
			Console.WriteLine("Started reading input...");
			var modulesMass = System.IO.File.ReadAllLines(@"Input/input.txt");
			var totalFuel = modulesMass.Select(m => Math.Floor((double)Convert.ToInt32(m) / 3) - 2).Sum();
			Console.WriteLine(totalFuel);
			Console.ReadLine();
		}
	}
}
